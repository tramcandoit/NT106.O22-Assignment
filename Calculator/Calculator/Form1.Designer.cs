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
            this.button_DE = new System.Windows.Forms.Button();
            this.button3_Divide = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Result
            // 
            this.textBox_Result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Result.Location = new System.Drawing.Point(12, 58);
            this.textBox_Result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Result.MinimumSize = new System.Drawing.Size(393, 40);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_Result.Size = new System.Drawing.Size(393, 46);
            this.textBox_Result.TabIndex = 0;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            this.panel1.Controls.Add(this.button_DE);
            this.panel1.Controls.Add(this.button3_Divide);
            this.panel1.Controls.Add(this.button_9);
            this.panel1.Controls.Add(this.button_8);
            this.panel1.Controls.Add(this.button_7);
            this.panel1.Controls.Add(this.textBox_Result);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 504);
            this.panel1.TabIndex = 1;
            // 
            // button_Plus
            // 
            this.button_Plus.AutoEllipsis = true;
            this.button_Plus.BackColor = System.Drawing.Color.AliceBlue;
            this.button_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Plus.Location = new System.Drawing.Point(252, 399);
            this.button_Plus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Size = new System.Drawing.Size(73, 81);
            this.button_Plus.TabIndex = 19;
            this.button_Plus.Text = "+";
            this.button_Plus.UseVisualStyleBackColor = false;
            this.button_Plus.Click += new System.EventHandler(this.button_Plus_Click);
            // 
            // button_Dot
            // 
            this.button_Dot.AutoEllipsis = true;
            this.button_Dot.BackColor = System.Drawing.Color.AliceBlue;
            this.button_Dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Dot.Location = new System.Drawing.Point(172, 399);
            this.button_Dot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Dot.Name = "button_Dot";
            this.button_Dot.Size = new System.Drawing.Size(73, 81);
            this.button_Dot.TabIndex = 18;
            this.button_Dot.Text = ".";
            this.button_Dot.UseVisualStyleBackColor = false;
            this.button_Dot.Click += new System.EventHandler(this.button_Dot_Click);
            // 
            // button_0
            // 
            this.button_0.AutoEllipsis = true;
            this.button_0.BackColor = System.Drawing.Color.AliceBlue;
            this.button_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_0.Location = new System.Drawing.Point(12, 399);
            this.button_0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(153, 81);
            this.button_0.TabIndex = 16;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = false;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_Equal
            // 
            this.button_Equal.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Equal.ForeColor = System.Drawing.Color.White;
            this.button_Equal.Location = new System.Drawing.Point(332, 310);
            this.button_Equal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Equal.Name = "button_Equal";
            this.button_Equal.Size = new System.Drawing.Size(73, 170);
            this.button_Equal.TabIndex = 15;
            this.button_Equal.Text = "=";
            this.button_Equal.UseVisualStyleBackColor = false;
            this.button_Equal.Click += new System.EventHandler(this.button_Equal_Click);
            // 
            // button_Minus
            // 
            this.button_Minus.AutoEllipsis = true;
            this.button_Minus.BackColor = System.Drawing.Color.AliceBlue;
            this.button_Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Minus.Location = new System.Drawing.Point(252, 310);
            this.button_Minus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Minus.Name = "button_Minus";
            this.button_Minus.Size = new System.Drawing.Size(73, 81);
            this.button_Minus.TabIndex = 14;
            this.button_Minus.Text = "-";
            this.button_Minus.UseVisualStyleBackColor = false;
            this.button_Minus.Click += new System.EventHandler(this.button_Minus_Click);
            // 
            // button_3
            // 
            this.button_3.AutoEllipsis = true;
            this.button_3.BackColor = System.Drawing.Color.AliceBlue;
            this.button_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_3.Location = new System.Drawing.Point(172, 310);
            this.button_3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(73, 81);
            this.button_3.TabIndex = 13;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = false;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_2
            // 
            this.button_2.AutoEllipsis = true;
            this.button_2.BackColor = System.Drawing.Color.AliceBlue;
            this.button_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_2.Location = new System.Drawing.Point(92, 310);
            this.button_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(73, 81);
            this.button_2.TabIndex = 12;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = false;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_1
            // 
            this.button_1.AutoEllipsis = true;
            this.button_1.BackColor = System.Drawing.Color.AliceBlue;
            this.button_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_1.Location = new System.Drawing.Point(12, 310);
            this.button_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(73, 81);
            this.button_1.TabIndex = 11;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_C
            // 
            this.button_C.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_C.ForeColor = System.Drawing.Color.White;
            this.button_C.Location = new System.Drawing.Point(332, 221);
            this.button_C.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(73, 81);
            this.button_C.TabIndex = 10;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = false;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // button_Times
            // 
            this.button_Times.AutoEllipsis = true;
            this.button_Times.BackColor = System.Drawing.Color.AliceBlue;
            this.button_Times.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Times.Location = new System.Drawing.Point(252, 221);
            this.button_Times.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Times.Name = "button_Times";
            this.button_Times.Size = new System.Drawing.Size(73, 81);
            this.button_Times.TabIndex = 9;
            this.button_Times.Text = "×";
            this.button_Times.UseVisualStyleBackColor = false;
            this.button_Times.Click += new System.EventHandler(this.button_Times_Click);
            // 
            // button_6
            // 
            this.button_6.AutoEllipsis = true;
            this.button_6.BackColor = System.Drawing.Color.AliceBlue;
            this.button_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_6.Location = new System.Drawing.Point(172, 221);
            this.button_6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(73, 81);
            this.button_6.TabIndex = 8;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = false;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_5
            // 
            this.button_5.AutoEllipsis = true;
            this.button_5.BackColor = System.Drawing.Color.AliceBlue;
            this.button_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_5.Location = new System.Drawing.Point(92, 221);
            this.button_5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(73, 81);
            this.button_5.TabIndex = 7;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = false;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_4
            // 
            this.button_4.AutoEllipsis = true;
            this.button_4.BackColor = System.Drawing.Color.AliceBlue;
            this.button_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_4.Location = new System.Drawing.Point(12, 221);
            this.button_4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(73, 81);
            this.button_4.TabIndex = 6;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = false;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_DE
            // 
            this.button_DE.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_DE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DE.ForeColor = System.Drawing.Color.White;
            this.button_DE.Location = new System.Drawing.Point(332, 132);
            this.button_DE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_DE.Name = "button_DE";
            this.button_DE.Size = new System.Drawing.Size(73, 81);
            this.button_DE.TabIndex = 5;
            this.button_DE.Text = "DE";
            this.button_DE.UseVisualStyleBackColor = false;
            this.button_DE.Click += new System.EventHandler(this.button_DE_Click);
            // 
            // button3_Divide
            // 
            this.button3_Divide.AutoEllipsis = true;
            this.button3_Divide.BackColor = System.Drawing.Color.AliceBlue;
            this.button3_Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3_Divide.Location = new System.Drawing.Point(252, 132);
            this.button3_Divide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3_Divide.Name = "button3_Divide";
            this.button3_Divide.Size = new System.Drawing.Size(73, 81);
            this.button3_Divide.TabIndex = 4;
            this.button3_Divide.Text = "/";
            this.button3_Divide.UseVisualStyleBackColor = false;
            this.button3_Divide.Click += new System.EventHandler(this.button3_Divide_Click);
            // 
            // button_9
            // 
            this.button_9.AutoEllipsis = true;
            this.button_9.BackColor = System.Drawing.Color.AliceBlue;
            this.button_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_9.Location = new System.Drawing.Point(172, 132);
            this.button_9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(73, 81);
            this.button_9.TabIndex = 3;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = false;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_8
            // 
            this.button_8.AutoEllipsis = true;
            this.button_8.BackColor = System.Drawing.Color.AliceBlue;
            this.button_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_8.Location = new System.Drawing.Point(92, 132);
            this.button_8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(73, 81);
            this.button_8.TabIndex = 2;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = false;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_7
            // 
            this.button_7.AutoEllipsis = true;
            this.button_7.BackColor = System.Drawing.Color.AliceBlue;
            this.button_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_7.Location = new System.Drawing.Point(12, 132);
            this.button_7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(73, 81);
            this.button_7.TabIndex = 1;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = false;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 504);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Button button_DE;
        private System.Windows.Forms.Button button3_Divide;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_7;
    }
}

