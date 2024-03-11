namespace FileExplorer
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
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.button_Open = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(12, 12);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(51, 29);
            this.button_Back.TabIndex = 0;
            this.button_Back.Text = "<<";
            this.button_Back.UseVisualStyleBackColor = true;
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(69, 12);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(51, 29);
            this.button_Next.TabIndex = 1;
            this.button_Next.Text = ">>";
            this.button_Next.UseVisualStyleBackColor = true;
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(176, 19);
            this.textBox_Path.MinimumSize = new System.Drawing.Size(530, 22);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.ReadOnly = true;
            this.textBox_Path.Size = new System.Drawing.Size(530, 22);
            this.textBox_Path.TabIndex = 2;
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(712, 17);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(76, 26);
            this.button_Open.TabIndex = 3;
            this.button_Open.Text = "Open";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Path:";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(14, 54);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(773, 383);
            this.webBrowser1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.textBox_Path);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_Back);
            this.Name = "Form1";
            this.Text = "File Explorer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

