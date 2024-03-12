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
            this.button_back = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.button_Open = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button_handle_path = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(12, 12);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(51, 29);
            this.button_back.TabIndex = 0;
            this.button_back.Text = "<<";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(69, 12);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(51, 29);
            this.button_next.TabIndex = 1;
            this.button_next.Text = ">>";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(169, 15);
            this.textBox_Path.MinimumSize = new System.Drawing.Size(530, 22);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(530, 22);
            this.textBox_Path.TabIndex = 2;
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(711, 14);
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
            this.label1.Location = new System.Drawing.Point(126, 19);
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
            // button_handle_path
            // 
            this.button_handle_path.Location = new System.Drawing.Point(659, 15);
            this.button_handle_path.Name = "button_handle_path";
            this.button_handle_path.Size = new System.Drawing.Size(40, 23);
            this.button_handle_path.TabIndex = 6;
            this.button_handle_path.Text = "Go";
            this.button_handle_path.UseVisualStyleBackColor = true;
            this.button_handle_path.Click += new System.EventHandler(this.button_handle_path_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button_handle_path;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_handle_path);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.textBox_Path);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_back);
            this.Name = "Form1";
            this.Text = "File Explorer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button_handle_path;
    }
}

