using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatSSL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Client_Click(object sender, EventArgs e)
        {
            Form client = new Form1_Client();
            client.Show();
        }

        private void button_Server_Click(object sender, EventArgs e)
        {
            Form server = new Form1_Server();
            server.Show();
        }
    }
}
