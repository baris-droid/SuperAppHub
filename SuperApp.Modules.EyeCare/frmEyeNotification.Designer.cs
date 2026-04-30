namespace SmartApp
{
    partial class frmEyeNotification
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
            lblTitle = new System.Windows.Forms.Label();
            lblMessage = new System.Windows.Forms.Label();
            pnlAccent = new System.Windows.Forms.Panel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(381, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Göz Dinlendirme Molası";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)209)), ((int)((byte)213)), ((int)((byte)219)));
            lblMessage.Location = new System.Drawing.Point(22, 55);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new System.Drawing.Size(319, 32);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Lütfen 20 saniye uzağa bak...";
            // 
            // pnlAccent
            // 
            pnlAccent.BackColor = System.Drawing.Color.FromArgb(((int)((byte)16)), ((int)((byte)185)), ((int)((byte)129)));
            pnlAccent.Dock = System.Windows.Forms.DockStyle.Left;
            pnlAccent.Location = new System.Drawing.Point(0, 0);
            pnlAccent.Name = "pnlAccent";
            pnlAccent.Size = new System.Drawing.Size(6, 110);
            pnlAccent.TabIndex = 2;
            // 
            // frmEyeNotification
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)31)), ((int)((byte)41)), ((int)((byte)55)));
            ClientSize = new System.Drawing.Size(456, 110);
            Controls.Add(lblMessage);
            Controls.Add(lblTitle);
            Controls.Add(pnlAccent);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "Göz Sağlığı Bildirimi";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMessage;
        private Label lblTitle;
        private Panel pnlAccent;
    }
}