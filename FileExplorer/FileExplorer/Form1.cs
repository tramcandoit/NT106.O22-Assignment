using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                webBrowser1.Url = new Uri(folderBrowserDialog.SelectedPath);
                textBox_Path.Text = folderBrowserDialog.SelectedPath;
            }
            
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            if(webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if(webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void OpenFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.SelectedPath = folderPath;
                
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    webBrowser1.Url = new Uri(folderBrowserDialog.SelectedPath);
                    textBox_Path.Text = folderBrowserDialog.SelectedPath;
                }
            }
            else
            {
                MessageBox.Show(string.Format("{0} Directory does not exist!", folderPath));
            }
        }
        
        private void button_handle_path_Click(object sender, EventArgs e)
        {
            OpenFolder(textBox_Path.Text);
        }
    }
}
