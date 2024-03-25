using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms.VisualStyles;

namespace Client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            Connect();
        }

        // gui tin di 


        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
            AddMessage("[" + txbUsername.Text + "]: " + txbMessage.Text);
        }

        //Socket //IP

        IPEndPoint IP; 
        Socket client;

        // ket noi toi Server
        void Connect()
        {
            // IP: ip addr server
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối tới server!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // client.Connect(IP);

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        // dong ket noi hien thoi
        void Close()
        {
            client.Close();
        }

        // gui tin
        void Send()
        {
            if (txbMessage.Text != string.Empty)
                client.Send(Serialize("[" + txbUsername.Text + "]: " + txbMessage.Text));
        }
        // nhan tin
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deserialize(data);

                    AddMessage(message);
                }
            }
            catch
            {
                Close();
            }
        }

        // add message vao khung chat
        void AddMessage(string s)
        {

            richTextBox1.Text += s + "\n";
            txbMessage.Text ="";
        }
        // phan manh
        byte[] Serialize(object obj) 
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        // gom manh lai
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }


        // dong ket noi khi dong form
        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
