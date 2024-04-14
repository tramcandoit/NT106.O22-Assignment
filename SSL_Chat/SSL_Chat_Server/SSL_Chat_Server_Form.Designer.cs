namespace SSL_Chat_Server
{
    partial class SSL_Chat_Server_Form
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
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.button_Listen = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(73, 29);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.ReadOnly = true;
            this.textBox_IP.Size = new System.Drawing.Size(100, 22);
            this.textBox_IP.TabIndex = 0;
            this.textBox_IP.Text = "127.0.0.1";
            // 
            // button_Listen
            // 
            this.button_Listen.Location = new System.Drawing.Point(218, 28);
            this.button_Listen.Name = "button_Listen";
            this.button_Listen.Size = new System.Drawing.Size(75, 23);
            this.button_Listen.TabIndex = 1;
            this.button_Listen.Text = "Listen";
            this.button_Listen.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(36, 72);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(732, 352);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // SSL_Chat_Server_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button_Listen);
            this.Controls.Add(this.textBox_IP);
            this.Name = "SSL_Chat_Server_Form";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Button button_Listen;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

