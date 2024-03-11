using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double FirstNum, SecNum;
        string Sign;
        public double Calculate(string s)
        {
            double res = 0;
            if (s == "+")
                res = FirstNum + SecNum;
            else if (s == "-")
                res = FirstNum - SecNum;
            else if (s == "*")
                res = FirstNum * SecNum;
            else if (s == "/")
                res = FirstNum / SecNum;
            return res;
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "1";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "1";
            }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "2";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "2";
            }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "3";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "3";
            }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "4";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "4";
            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "5";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "5";
            }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "6";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "6";
            }
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "7";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "7";
            }
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "8";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "8";
            }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "9";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "9";
            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "0";
        }

        private void button_Dot_Click(object sender, EventArgs e)
        {   
            textBox_Result.Text = textBox_Result.Text + ".";

        }

        private void button_Minus_Click(object sender, EventArgs e)
        {
            FirstNum = Double.Parse(textBox_Result.Text);
            textBox_Result.Text = "0";
            Sign = "-";
        }

        private void button_Times_Click(object sender, EventArgs e)
        {
            FirstNum = Double.Parse(textBox_Result.Text);
            textBox_Result.Text = "0";
            Sign = "*";
        }

        private void button3_Divide_Click(object sender, EventArgs e)
        {
            FirstNum = Double.Parse(textBox_Result.Text);
            textBox_Result.Text = "0";
            Sign = "/";
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button_Equal_Click(object sender, EventArgs e)
        {
            SecNum = Double.Parse(textBox_Result.Text);
            textBox_Result.Text = Calculate(Sign).ToString();
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button_Plus_Click(object sender, EventArgs e)
        {
            FirstNum = Double.Parse(textBox_Result.Text);
            textBox_Result.Text = "0";
            Sign = "+";
        }
    }
}
