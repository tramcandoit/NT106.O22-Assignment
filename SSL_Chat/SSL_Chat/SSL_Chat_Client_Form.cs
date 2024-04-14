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
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSL_Chat
{
    public partial class SSL_Chat_Client_Form : Form
    {
        private TcpClient tcpClient;
        private StreamReader sReader;
        private StreamWriter sWriter;
        private SslStream mySslStream;
        private Thread clientThread;
        private int serverPort = 8000;
        private bool stopTcpClient = true;
        public const int BufferSize = 4096;
        public const int FileBufferSize = 3072;
        private string SaveFileName = string.Empty;
        private MemoryStream fileSaveMemoryStream;
        public enum
            MessageType
        {
            Text,
            FileEof,// EOL, EOF
            FilePart,
        }

        public SSL_Chat_Client_Form()
        {
            InitializeComponent();
        }

        static bool ValidateCertificate(Object sender,
            X509Certificate certificate, X509Chain chain,
            SslPolicyErrors sslPolicyErrors)
        {
            // For this sample under Windows 7 I also get
            // a remote cert not available error, so we
            // just do a return true here to signal that
            // we are trusting things. In the real world,
            // this would be very bad practice.
            //            return true;
            //            if (sslPolicyErrors == SslPolicyErrors.None)
            //            { return true; }
            // we don't have a proper certificate tree
            if (sslPolicyErrors ==
                SslPolicyErrors.RemoteCertificateChainErrors)
            { return true; }
            if (sslPolicyErrors == SslPolicyErrors.None)
            { return true; }
            return false;
        }
        [STAThread]

        private void ClientRecv()
        {
            //            NetworkStream networkStream = tcpClient.GetStream();
            //StreamReader sr = new StreamReader(networkStream);
            try
            {
                while (!stopTcpClient && tcpClient.Connected)
                {
                    Application.DoEvents();
                    //string data = sr.ReadLine();
                    //                    using (SslStream ssl = new SslStream(networkStream, false, ValidateCertificate))
                    //                    {
                    //                        ssl.AuthenticateAsServer(getServerCert(),
                    //                            true, SslProtocols.Tls12, false);
                    byte[] readBuffers = new byte[BufferSize];
                    //                        while (networkStream.DataAvailable)
                    //                        {
                    //                            networkStream.Read(readBuffers, 0, BufferSize);
                    //                            //tmp = Encoding.UTF8.GetString(readBuffers).Replace("\0", string.Empty);
                    //                        }
                    var inputBytes = 0;
                    while (inputBytes == 0)
                    {
                        inputBytes = mySslStream.Read(readBuffers, 0,
                            readBuffers.Length);
                    }
                    string headerAndMessage = Encoding.UTF8.GetString(readBuffers, 0, inputBytes).Replace("\0", string.Empty);
                    //                        string headerAndMessage = Encoding.UTF8.GetString(readBuffers).Replace("\0", string.Empty);

                    string[] arrPayload = headerAndMessage.Split(';');
                    if (arrPayload.Length >= 3)
                    {
                        string senderUsername = arrPayload[0];
                        MessageType msgType = (MessageType)Enum.Parse(typeof(MessageType), arrPayload[1], true);
                        if (msgType == MessageType.Text)
                        {
                            string content = arrPayload[2].Replace("\0", string.Empty);
                            string formattedMsg = $"{senderUsername}: {content} \n";
                            UpdateChatHistoryThreadSafe(formattedMsg);
                        }
                        else if (msgType == MessageType.FilePart)
                        {

                            if (string.IsNullOrEmpty(SaveFileName))
                            {
                                string message = "Receive incoming file ";
                                string caption = "File sent request";
                                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                DialogResult result;
                                result = MessageBox.Show(message, caption, buttons);
                                if (result == DialogResult.Yes)
                                {
                                    SaveFileDialog DialogSave = new SaveFileDialog();
                                    DialogSave.Filter = "All files (*.*)|*.*";
                                    DialogSave.RestoreDirectory = true;
                                    DialogSave.Title = "Where do you want to save the file?";
                                    DialogSave.InitialDirectory = @"C:/";
                                    if (DialogSave.ShowDialog() == DialogResult.OK)
                                    {
                                        SaveFileName = DialogSave.FileName;
                                        fileSaveMemoryStream = new MemoryStream();
                                    }

                                }
                            }

                            byte[] filePart = Encoding.UTF8.GetBytes(arrPayload[2].Replace("\0", string.Empty));

                            fileSaveMemoryStream?.Write(filePart, 0, filePart.Length);



                        }
                        else if (msgType == MessageType.FileEof)
                        {
                            if (string.IsNullOrEmpty(SaveFileName))
                            {
                                string message = "Receive incoming file ";
                                string caption = "File sent request";
                                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                DialogResult result;
                                result = MessageBox.Show(message, caption, buttons);
                                if (result == DialogResult.Yes)
                                {
                                    SaveFileDialog DialogSave = new SaveFileDialog();
                                    DialogSave.Filter = "All files (*.*)|*.*";
                                    DialogSave.RestoreDirectory = true;
                                    DialogSave.Title = "Where do you want to save the file?";
                                    DialogSave.InitialDirectory = @"C:/";

                                    Invoke((Action)(() =>
                                    {
                                        if (DialogSave.ShowDialog() == DialogResult.OK)
                                        {
                                            SaveFileName = DialogSave.FileName;
                                        }
                                    }));


                                }
                            }

                            byte[] finalFilePart =
                                Encoding.UTF8.GetBytes(arrPayload[2].Replace("\0", string.Empty));

                            if (fileSaveMemoryStream != null)
                            {
                                fileSaveMemoryStream.Write(finalFilePart, 0, finalFilePart.Length);
                                using (FileStream fs = File.OpenWrite(SaveFileName))
                                {
                                    fileSaveMemoryStream.WriteTo(fs);
                                }
                            }
                            else
                            {
                                using (FileStream fs = File.OpenWrite(SaveFileName))
                                {
                                    fs.Write(finalFilePart, 0, finalFilePart.Length);
                                }

                            }

                            fileSaveMemoryStream = null;
                            SaveFileName = null;

                        }
                    }

                }
                //                }
            }
            catch (SocketException sockEx)
            {
                tcpClient.Close();
                //sr.Close();

            }
        }

        private delegate void SafeCallDelegate(string text);

        private delegate void SaveFileConfirmDialogDelegate(DialogResult result);
        private void UpdateChatHistoryThreadSafe(string text)
        {
            if (richTextBox1.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateChatHistoryThreadSafe);
                richTextBox1.Invoke(d, new object[] { text });
            }
            else
            {
                richTextBox1.Text += text;
            }
        }

        private static X509Certificate getServerCert()
        {
            X509Store store = new X509Store(StoreName.My,
                StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);

            X509Certificate2 foundCertificate = null;
            foreach (X509Certificate2 currentCertificate
                in store.Certificates)
            {
                if (currentCertificate.IssuerName.Name
                    != null && currentCertificate.IssuerName.
                        Name.Equals("CN=MySslSocketCertificate"))
                {
                    foundCertificate = currentCertificate;
                    break;
                }
            }


            return foundCertificate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NetworkStream ns = tcpClient.GetStream();
                string allInOneMsg = $"{textBox3.Text};{MessageType.Text.ToString()};{sendMsgTextBox.Text}";
                byte[] sendingBytes = Encoding.UTF8.GetBytes(allInOneMsg);
                ns.Write(sendingBytes, 0, sendingBytes.Length);
                //                sWriter.WriteLine($"{textBox3.Text};{sendMsgTextBox.Text}");
                sendMsgTextBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Close(object sender, FormClosingEventArgs e)
        {

        }
        private static string ServerCertificateName =
            "MySslSocketCertificate";
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                stopTcpClient = false;
                var clientCertificate = getServerCert();
                var clientCertificateCollection = new
                    X509CertificateCollection(new X509Certificate[]
                        { clientCertificate });

                this.tcpClient = new TcpClient();
                this.tcpClient.Connect(new IPEndPoint(IPAddress.Parse(textBox_IP.Text), serverPort));
                this.sWriter = new StreamWriter(tcpClient.GetStream())
                {
                    AutoFlush = true
                };
                this.mySslStream = new SslStream(tcpClient.GetStream());
                this.mySslStream.AuthenticateAsClient(ServerCertificateName,
                    clientCertificateCollection, SslProtocols.Tls12, false);
                //                sWriter.WriteLine(this.textBox1.Text);
                this.mySslStream.Write(Encoding.UTF8.GetBytes(this.textBox1.Text));
                clientThread = new Thread(this.ClientRecv);
                clientThread.Start();
                MessageBox.Show("Connected");
            }
            catch (SocketException sockEx)
            {
                MessageBox.Show(sockEx.Message, "Network error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileContent = string.Empty;
            string filePath = string.Empty;
            byte[] sendingBuffer = null;
            try
            {
                NetworkStream networkStream = tcpClient.GetStream();
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        // filePath = openFileDialog.FileName
                        byte[] headerBytes = Encoding.UTF8.GetBytes($"{textBox3.Text};{MessageType.FilePart};");
                        byte[] uNameHeader = Encoding.UTF8.GetBytes("user");
                        using (Stream fileStream = openFileDialog.OpenFile())
                        {
                            int NoOfPackets = Convert.ToInt32
                                (Math.Ceiling(Convert.ToDouble(fileStream.Length) / Convert.ToDouble(FileBufferSize)));
                            //networkStream.WriteByte(headerBytes.Concat(Encoding.UTF8.GetBytes(NoOfPackets.to).ToArray());
                            progressBar1.Maximum = NoOfPackets;
                            int TotalLength = (int)fileStream.Length, CurrentPacketLength, counter = 0;
                            for (int i = 0; i < NoOfPackets; i++)
                            {
                                if (TotalLength > FileBufferSize)
                                {
                                    CurrentPacketLength = FileBufferSize;
                                    TotalLength = TotalLength - CurrentPacketLength;
                                }
                                else
                                {
                                    CurrentPacketLength = TotalLength;
                                    headerBytes = Encoding.UTF8.GetBytes($"{textBox3.Text};{MessageType.FileEof};");

                                }

                                sendingBuffer = new byte[CurrentPacketLength];
                                fileStream.Read(sendingBuffer, 0, CurrentPacketLength);

                                byte[] sendingBytes = headerBytes.Concat(sendingBuffer).ToArray();
                                networkStream.Write(sendingBytes, 0, (int)sendingBytes.Length);
                                if (progressBar1.Value >= progressBar1.Maximum)
                                    progressBar1.Value = progressBar1.Minimum;
                                progressBar1.PerformStep();
                            }


                        }


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
