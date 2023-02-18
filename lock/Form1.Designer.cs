namespace @lock
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
            this.components = new System.ComponentModel.Container();
            this.txt_paswd = new System.Windows.Forms.TextBox();
            this.txt_DataInOut = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txt_paswd
            // 
            this.txt_paswd.AcceptsTab = true;
            this.txt_paswd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_paswd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_paswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_paswd.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_paswd.Location = new System.Drawing.Point(242, 12);
            this.txt_paswd.Name = "txt_paswd";
            this.txt_paswd.PasswordChar = ' ';
            this.txt_paswd.Size = new System.Drawing.Size(263, 13);
            this.txt_paswd.TabIndex = 0;
            this.txt_paswd.DoubleClick += new System.EventHandler(this.txt_paswd_DoubleClick);
            // 
            // txt_DataInOut
            // 
            this.txt_DataInOut.AcceptsTab = true;
            this.txt_DataInOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DataInOut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_DataInOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DataInOut.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DataInOut.ForeColor = System.Drawing.Color.DarkGreen;
            this.txt_DataInOut.Location = new System.Drawing.Point(1, 31);
            this.txt_DataInOut.Name = "txt_DataInOut";
            this.txt_DataInOut.Size = new System.Drawing.Size(798, 717);
            this.txt_DataInOut.TabIndex = 2;
            this.txt_DataInOut.Text = "";
            this.txt_DataInOut.DoubleClick += new System.EventHandler(this.txt_DataInOut_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 35000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.txt_DataInOut);
            this.Controls.Add(this.txt_paswd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOCK";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_paswd;
        private System.Windows.Forms.RichTextBox txt_DataInOut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

