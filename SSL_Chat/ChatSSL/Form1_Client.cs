using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatSSL
{
    public partial class Form1_Client : Form
    {
        private TcpClient tcpClient = new TcpClient();
        private SslStream sslStream;
        private NetworkStream networkStream;
        private Thread responseThread;
        public Form1_Client()
        {
            InitializeComponent();
            richTextBox2.DetectUrls = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!tcpClient.Connected)
            {
                MessageBox.Show("Chưa kết nối đến máy chủ.");
                return;
            }

            try
            {
                byte[] data = Encoding.UTF8.GetBytes("\n" + yournameTxtBox.Text + ": " + richTextBox1.Text);
                sslStream.Write(data, 0, data.Length);
                sslStream.Flush();

                UpdateTextBox("\n" + yournameTxtBox.Text + ": " + richTextBox1.Text);

                richTextBox1.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra khi gửi tin nhắn: " + ex.Message);
            }
        }

        private void UpdateTextBox(string text)
        {
            if (richTextBox2.InvokeRequired)
            {
                richTextBox2.Invoke((MethodInvoker)delegate {
                    UpdateTextBox(text);
                });
            }
            else
            {
                richTextBox2.Text += text;
            }
        }

        private void ReceiveResponses()
        {
            try
            {
                while (tcpClient.Connected)
                {
                    if (networkStream.DataAvailable)
                    {
                        byte[] data = new byte[2048];
                        int dataSize = networkStream.Read(data, 0, data.Length);

                        string receivedMessage = Encoding.UTF8.GetString(data, 0, dataSize).Trim();

                        UpdateTextBox($"\n {receivedMessage}");
                    }
                }
            }
            catch (IOException)
            {
                UpdateTextBox("Kết nối đã bị đóng.\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra trong quá trình nhận dữ liệu từ máy chủ: " + ex.Message);
            }
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            try
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(textBox1.Text), int.Parse(textBox2.Text));
                tcpClient.Connect(ipep);

                networkStream = tcpClient.GetStream();
                sslStream = new SslStream(networkStream, false);
                sslStream.AuthenticateAsClient("MySslSocketCertificate");

                responseThread = new Thread(ReceiveResponses);
                responseThread.Start();

                MessageBox.Show("Kết nối thành công!");
            }
            catch (AuthenticationException authEx)
            {
                MessageBox.Show("Xác thực SSL/TLS thất bại: " + authEx.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Hãy nhập đúng địa chỉ IP và port.");
            }
            catch (SocketException)
            {
                MessageBox.Show("Kết nối tới máy chủ thất bại. Hãy kiểm tra lại địa chỉ IP và port.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra khi thiết lập kết nối: " + ex.Message);
            }
        }

        private void Form1_Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            responseThread.Abort();
        }
    }
}
