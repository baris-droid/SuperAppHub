namespace SmartApp
{
    partial class ucDiscordRPC
    {
        /// <summary> 
        /// Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        /// <param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblClientId = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.lblImageLink = new System.Windows.Forms.Label();
            this.txtImageLink = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(298, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Discord Durum Yönetimi";
            
            // 
            // pnlCard
            // 
            this.pnlCard.Controls.Add(this.lblClientId);
            this.pnlCard.Controls.Add(this.txtClientId);
            this.pnlCard.Controls.Add(this.lblImageLink);
            this.pnlCard.Controls.Add(this.txtImageLink);
            this.pnlCard.Controls.Add(this.lblDetails);
            this.pnlCard.Controls.Add(this.txtDetails);
            this.pnlCard.Controls.Add(this.lblState);
            this.pnlCard.Controls.Add(this.txtState);
            this.pnlCard.Controls.Add(this.label1);
            this.pnlCard.Controls.Add(this.btnConnect);
            this.pnlCard.Controls.Add(this.btnUpdate);
            this.pnlCard.Controls.Add(this.btnDisconnect);
            this.pnlCard.Controls.Add(this.lblStatus);
            this.pnlCard.Location = new System.Drawing.Point(25, 80);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(680, 360);
            this.pnlCard.TabIndex = 1;
            
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblClientId.Location = new System.Drawing.Point(20, 20);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(59, 17);
            this.lblClientId.TabIndex = 0;
            this.lblClientId.Text = "Client ID";
            
            // 
            // txtClientId
            // 
            this.txtClientId.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.txtClientId.Location = new System.Drawing.Point(20, 45);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(300, 27);
            this.txtClientId.TabIndex = 1;
            
            // 
            // lblImageLink
            // 
            this.lblImageLink.AutoSize = true;
            this.lblImageLink.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblImageLink.Location = new System.Drawing.Point(350, 20);
            this.lblImageLink.Name = "lblImageLink";
            this.lblImageLink.Size = new System.Drawing.Size(206, 17);
            this.lblImageLink.TabIndex = 2;
            this.lblImageLink.Text = "Resim Anahtarı (LargeImageKey)";
            
            // 
            // txtImageLink
            // 
            this.txtImageLink.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.txtImageLink.Location = new System.Drawing.Point(350, 45);
            this.txtImageLink.Name = "txtImageLink";
            this.txtImageLink.Size = new System.Drawing.Size(300, 27);
            this.txtImageLink.TabIndex = 3;
            
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblDetails.Location = new System.Drawing.Point(20, 95);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(107, 17);
            this.lblDetails.TabIndex = 4;
            this.lblDetails.Text = "Üst Yazı (Details)";
            
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.txtDetails.Location = new System.Drawing.Point(20, 120);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(300, 27);
            this.txtDetails.TabIndex = 5;
            
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblState.Location = new System.Drawing.Point(350, 95);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(94, 17);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "Alt Yazı (State)";
            
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.txtState.Location = new System.Drawing.Point(350, 120);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(300, 27);
            this.txtState.TabIndex = 7;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 162);
            this.label1.Location = new System.Drawing.Point(20, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "\"Bağlan\" butonuna bastıktan sonra \"Durumu Güncelle\" butonuna basarak\r\ndurumunuzu ayarlayabilirsiniz.";
            
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(20, 240);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(120, 38);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Bağlan";
            this.btnConnect.UseVisualStyleBackColor = false;
            
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(150, 240);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 38);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Durumu Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnDisconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.FlatAppearance.BorderSize = 0;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.btnDisconnect.ForeColor = System.Drawing.Color.White;
            this.btnDisconnect.Location = new System.Drawing.Point(310, 240);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(150, 38);
            this.btnDisconnect.TabIndex = 11;
            this.btnDisconnect.Text = "Bağlantıyı Kes";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.lblStatus.Location = new System.Drawing.Point(20, 310);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(147, 20);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Durum: Bekleniyor...";
            
            // 
            // ucDiscordRPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.Name = "ucDiscordRPC";
            this.Size = new System.Drawing.Size(750, 480);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label lblImageLink;
        private System.Windows.Forms.TextBox txtImageLink;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDisconnect;
    }
}