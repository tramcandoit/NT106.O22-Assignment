namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Plus = new System.Windows.Forms.Button();
            this.button_Dot = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_Equal = new System.Windows.Forms.Button();
            this.button_Minus = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_Times = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_CE = new System.Windows.Forms.Button();
            this.button3_Divide = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Result.Location = new System.Drawing.Point(11, 60);
            this.textBox_Result.MinimumSize = new System.Drawing.Size(350, 40);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_Result.Size = new System.Drawing.Size(350, 40);
            this.textBox_Result.TabIndex = 0;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.button_Plus);
            this.panel1.Controls.Add(this.button_Dot);
            this.panel1.Controls.Add(this.button_0);
            this.panel1.Controls.Add(this.button_Equal);
            this.panel1.Controls.Add(this.button_Minus);
            this.panel1.Controls.Add(this.button_3);
            this.panel1.Controls.Add(this.button_2);
            this.panel1.Controls.Add(this.button_1);
            this.panel1.Controls.Add(this.button_C);
            this.panel1.Controls.Add(this.button_Times);
            this.panel1.Controls.Add(this.button_6);
            this.panel1.Controls.Add(this.button_5);
            this.panel1.Controls.Add(this.button_4);
            this.panel1.Controls.Add(this.button_CE);
            this.panel1.Controls.Add(this.button3_Divide);
            this.panel1.Controls.Add(this.button_9);
            this.panel1.Controls.Add(this.button_8);
            this.panel1.Controls.Add(this.button_7);
            this.panel1.Controls.Add(this.textBox_Result);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 403);
            this.panel1.TabIndex = 1;
            // 
            // button_Plus
            // 
            this.button_Plus.Location = new System.Drawing.Point(224, 319);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Size = new System.Drawing.Size(65, 65);
            this.button_Plus.TabIndex = 19;
            this.button_Plus.Text = "+";
            this.button_Plus.UseVisualStyleBackColor = true;
            this.button_Plus.Click += new System.EventHandler(this.button_Plus_Click);
            // 
            // button_Dot
            // 
            this.button_Dot.Location = new System.Drawing.Point(153, 319);
            this.button_Dot.Name = "button_Dot";
            this.button_Dot.Size = new System.Drawing.Size(65, 65);
            this.button_Dot.TabIndex = 18;
            this.button_Dot.Text = ".";
            this.button_Dot.UseVisualStyleBackColor = true;
            this.button_Dot.Click += new System.EventHandler(this.button_Dot_Click);
            // 
            // button_0
            // 
            this.button_0.Location = new System.Drawing.Point(11, 319);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(136, 65);
            this.button_0.TabIndex = 16;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_Equal
            // 
            this.button_Equal.Location = new System.Drawing.Point(295, 248);
            this.button_Equal.Name = "button_Equal";
            this.button_Equal.Size = new System.Drawing.Size(65, 136);
            this.button_Equal.TabIndex = 15;
            this.button_Equal.Text = "=";
            this.button_Equal.UseVisualStyleBackColor = true;
            this.button_Equal.Click += new System.EventHandler(this.button_Equal_Click);
            // 
            // button_Minus
            // 
            this.button_Minus.Location = new System.Drawing.Point(224, 248);
            this.button_Minus.Name = "button_Minus";
            this.button_Minus.Size = new System.Drawing.Size(65, 65);
            this.button_Minus.TabIndex = 14;
            this.button_Minus.Text = "-";
            this.button_Minus.UseVisualStyleBackColor = true;
            this.button_Minus.Click += new System.EventHandler(this.button_Minus_Click);
            // 
            // button_3
            // 
            this.button_3.Location = new System.Drawing.Point(153, 248);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(65, 65);
            this.button_3.TabIndex = 13;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(82, 248);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(65, 65);
            this.button_2.TabIndex = 12;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(11, 248);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(65, 65);
            this.button_1.TabIndex = 11;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_C
            // 
            this.button_C.Location = new System.Drawing.Point(295, 177);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(65, 65);
            this.button_C.TabIndex = 10;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // button_Times
            // 
            this.button_Times.Location = new System.Drawing.Point(224, 177);
            this.button_Times.Name = "button_Times";
            this.button_Times.Size = new System.Drawing.Size(65, 65);
            this.button_Times.TabIndex = 9;
            this.button_Times.Text = "*";
            this.button_Times.UseVisualStyleBackColor = true;
            this.button_Times.Click += new System.EventHandler(this.button_Times_Click);
            // 
            // button_6
            // 
            this.button_6.Location = new System.Drawing.Point(153, 177);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(65, 65);
            this.button_6.TabIndex = 8;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_5
            // 
            this.button_5.Location = new System.Drawing.Point(82, 177);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(65, 65);
            this.button_5.TabIndex = 7;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_4
            // 
            this.button_4.Location = new System.Drawing.Point(11, 177);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(65, 65);
            this.button_4.TabIndex = 6;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_CE
            // 
            this.button_CE.Location = new System.Drawing.Point(295, 106);
            this.button_CE.Name = "button_CE";
            this.button_CE.Size = new System.Drawing.Size(65, 65);
            this.button_CE.TabIndex = 5;
            this.button_CE.Text = "CE";
            this.button_CE.UseVisualStyleBackColor = true;
            this.button_CE.Click += new System.EventHandler(this.button_CE_Click);
            // 
            // button3_Divide
            // 
            this.button3_Divide.Location = new System.Drawing.Point(224, 106);
            this.button3_Divide.Name = "button3_Divide";
            this.button3_Divide.Size = new System.Drawing.Size(65, 65);
            this.button3_Divide.TabIndex = 4;
            this.button3_Divide.Text = "/";
            this.button3_Divide.UseVisualStyleBackColor = true;
            this.button3_Divide.Click += new System.EventHandler(this.button3_Divide_Click);
            // 
            // button_9
            // 
            this.button_9.Location = new System.Drawing.Point(153, 106);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(65, 65);
            this.button_9.TabIndex = 3;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_8
            // 
            this.button_8.Location = new System.Drawing.Point(82, 106);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(65, 65);
            this.button_8.TabIndex = 2;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_7
            // 
            this.button_7.Location = new System.Drawing.Point(11, 106);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(65, 65);
            this.button_7.TabIndex = 1;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 403);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Plus;
        private System.Windows.Forms.Button button_Dot;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_Equal;
        private System.Windows.Forms.Button button_Minus;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_Times;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_CE;
        private System.Windows.Forms.Button button3_Divide;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_7;
    }
}

