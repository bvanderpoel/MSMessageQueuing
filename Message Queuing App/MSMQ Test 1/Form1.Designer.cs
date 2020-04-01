namespace MSMQ_Test_1
{
    partial class FrmMSMQ
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
            this.TxtSend = new System.Windows.Forms.TextBox();
            this.LblSend = new System.Windows.Forms.Label();
            this.LblReceive = new System.Windows.Forms.Label();
            this.TxtReceive = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.BtnReceive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtSend
            // 
            this.TxtSend.Location = new System.Drawing.Point(128, 25);
            this.TxtSend.Name = "TxtSend";
            this.TxtSend.Size = new System.Drawing.Size(303, 20);
            this.TxtSend.TabIndex = 0;
            // 
            // LblSend
            // 
            this.LblSend.AutoSize = true;
            this.LblSend.Location = new System.Drawing.Point(12, 28);
            this.LblSend.Name = "LblSend";
            this.LblSend.Size = new System.Drawing.Size(78, 13);
            this.LblSend.TabIndex = 1;
            this.LblSend.Text = "Message Send";
            // 
            // LblReceive
            // 
            this.LblReceive.AutoSize = true;
            this.LblReceive.Location = new System.Drawing.Point(12, 62);
            this.LblReceive.Name = "LblReceive";
            this.LblReceive.Size = new System.Drawing.Size(93, 13);
            this.LblReceive.TabIndex = 1;
            this.LblReceive.Text = "Message Receive";
            // 
            // TxtReceive
            // 
            this.TxtReceive.Location = new System.Drawing.Point(128, 59);
            this.TxtReceive.Name = "TxtReceive";
            this.TxtReceive.ReadOnly = true;
            this.TxtReceive.Size = new System.Drawing.Size(303, 20);
            this.TxtReceive.TabIndex = 0;
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(454, 23);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 2;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // BtnReceive
            // 
            this.BtnReceive.Location = new System.Drawing.Point(454, 59);
            this.BtnReceive.Name = "BtnReceive";
            this.BtnReceive.Size = new System.Drawing.Size(75, 23);
            this.BtnReceive.TabIndex = 2;
            this.BtnReceive.Text = "Receive";
            this.BtnReceive.UseVisualStyleBackColor = true;
            this.BtnReceive.Click += new System.EventHandler(this.BtnReceive_Click);
            // 
            // FrmMSMQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 116);
            this.Controls.Add(this.BtnReceive);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.LblReceive);
            this.Controls.Add(this.LblSend);
            this.Controls.Add(this.TxtReceive);
            this.Controls.Add(this.TxtSend);
            this.Name = "FrmMSMQ";
            this.Text = "MSMQ Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSend;
        private System.Windows.Forms.Label LblSend;
        private System.Windows.Forms.Label LblReceive;
        private System.Windows.Forms.TextBox TxtReceive;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Button BtnReceive;
    }
}

