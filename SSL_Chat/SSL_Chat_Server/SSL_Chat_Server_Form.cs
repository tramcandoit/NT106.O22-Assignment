using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Threading;
using Byte = System.Byte;


namespace SSL_Chat_Server
{
    public partial class SSL_Chat_Server_Form : Form
    {
        public SSL_Chat_Server_Form()
        {
            InitializeComponent();
        }

        private Thread listenThread;
        private TcpListener tcpListener;
        private bool stopChatServer = true;
        private readonly int _serverPort = 8000;
        private Dictionary<string, SslStream> dict = new Dictionary<string, SslStream>();
        public const int BufferSize = 4096;

        public enum
            MessageType
        {
            Text,
            FileEof,
            FilePart,
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

        static bool ValidateCertificate(Object sender,
            X509Certificate certificate, X509Chain chain,
            SslPolicyErrors sslPolicyErrors)
        {
            if (sslPolicyErrors ==
                SslPolicyErrors.RemoteCertificateChainErrors)
            { return true; }
            if (sslPolicyErrors == SslPolicyErrors.None)
            { return true; }
            return false;
        }

        private byte[] buffer = new byte[BufferSize];

        private void OnAcceptedTcpClient(IAsyncResult ar)
        {
            TcpListener listener = (TcpListener)ar.AsyncState;
            TcpClient client = listener.EndAcceptTcpClient(ar);
            //            StreamWriter sw = new StreamWriter(client.GetStream());
            //            sw.AutoFlush = true;
            var serverCertificate = getServerCert();

            SslStream ssl = new SslStream(client.GetStream(), false, ValidateCertificate);

            ssl.AuthenticateAsServer(serverCertificate,
                true, SslProtocols.Tls12, false);
            var inputBytes = 0;
            while (inputBytes == 0)
            {
                inputBytes = ssl.Read(this.buffer, 0,
                    this.buffer.Length);
            }
            string username = Encoding.UTF8.GetString(this.buffer, 0, inputBytes);
            //                string username = ssl.Read();

            if (string.IsNullOrEmpty(username))
            {
                ssl.Write(Encoding.UTF8.GetBytes("Please pick a username\n"));
                client.Close();
            }
            else
            {
                if (!dict.ContainsKey(username))
                {
                    byte[] buffer = new byte[BufferSize];
                    client.Client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, OnClientReceive,
                        Tuple.Create(username, client, ssl, buffer));

                    dict.Add(username, ssl);
                }
                else
                {
                    ssl.Write(Encoding.UTF8.GetBytes("Username already exist, pick another one\n"));
                    client.Close();
                }
            }
            listener.BeginAcceptTcpClient(this.OnAcceptedTcpClient, listener);

            //            ssl.Flush();
        }

        public void Listen()
        {
            try
            {
                tcpListener = new TcpListener(new IPEndPoint(IPAddress.Parse(textBox_IP.Text), _serverPort));
                tcpListener.Start();

                tcpListener.BeginAcceptTcpClient(new AsyncCallback(OnAcceptedTcpClient), tcpListener);
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public byte[] GetReceivedData(byte[] buffer, Socket clientSocket, IAsyncResult ar)
        {
            int nBytesRec = 0;
            try
            {
                //                using (NetworkStream ns = new NetworkStream(clientSocket))
                //                {
                //                    using (SslStream ssl = new SslStream(ns, false, ValidateCertificate))
                //                    {
                //                        ssl.AuthenticateAsServer(getServerCert(),
                //                            true, SslProtocols.Tls12, false);
                nBytesRec = clientSocket.EndReceive(ar);
                //                    }
                //                }
            }
            catch { }
            byte[] byReturn = new byte[nBytesRec];

            Array.Copy(buffer, byReturn, nBytesRec);


            return byReturn;
        }

        private static string ServerCertificateName =
            "MySslSocketCertificate";

        private void OnClientReceive(IAsyncResult ar)
        {
            Tuple<string, TcpClient, SslStream, byte[]> state = (Tuple<string, TcpClient, SslStream, byte[]>)ar.AsyncState;
            string username = state.Item1;
            TcpClient client = state.Item2;
            SslStream mySsl = state.Item3;
            byte[] buffer = state.Item4;
            byte[] forwardBuffer = this.GetReceivedData(buffer, client.Client, ar);
            try
            {
                string headerAndMessage = Encoding.UTF8.GetString(forwardBuffer);
                string[] arrPayload = headerAndMessage.Split(';');
                if (arrPayload.Length >= 3)
                {
                    string friendUsername = arrPayload[0];
                    MessageType msgType = (MessageType)Enum.Parse(typeof(MessageType), arrPayload[1], true);
                    if (msgType == MessageType.Text)
                    {
                        string content = arrPayload[2].Replace("\0", string.Empty);
                        string forwardHeaderAndMessage = $"{username};{MessageType.Text};{content}";
                        if (dict.TryGetValue(friendUsername, out SslStream friendSsl))
                        {
                            //                            StreamWriter sw = new StreamWriter(friendTcpClient.GetStream());
                            //                            using (SslStream friendSsl =
                            //                                new SslStream(friendTcpClient.GetStream(), false, ValidateCertificate))
                            //                            {
                            //                                var clientCertificate = getServerCert();
                            //                                var clientCertificateCollection = new
                            //                                    X509CertificateCollection(new X509Certificate[]
                            //                                        { clientCertificate });
                            //                                friendSsl.AuthenticateAsClient(ServerCertificateName,
                            //                                    clientCertificate   HeaderAndMessage + "\n"));
                            //                                friendSsl.Flush();
                            //                            }

                        }

                        //                        StreamWriter sw2 = new StreamWriter(client.GetStream());
                        //                        sw2.WriteLine(forwardHeaderAndMessage);
                        //                        sw2.AutoFlush = true;
                        mySsl.Write(Encoding.UTF8.GetBytes(forwardHeaderAndMessage + "\n"));

                        UpdateChatHistoryThreadSafe(forwardHeaderAndMessage);
                    }
                    else if (msgType == MessageType.FilePart || msgType == MessageType.FileEof)
                    {
                        //                        if (dict.TryGetValue(friendUsername, out TcpClient friendTcpClient))
                        //                        {
                        //                            NetworkStream ns = friendTcpClient.GetStream();
                        //                            byte[] forwardBytes = Encoding.UTF8.GetBytes(headerAndMessage);
                        //                            ns.Write(forwardBytes, 0, forwardBytes.Length);
                        //
                        //                        }
                    }
                }
                client.Client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, OnClientReceive, Tuple.Create(username, client, mySsl, buffer));

            }
            catch (SocketException sockEx)
            {
                MessageBox.Show(sockEx.Message);
                client.Close();
            }
        }


        private delegate void SafeCallDelegate(string text);

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

    }
}
