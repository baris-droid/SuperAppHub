namespace SmartApp
{
    partial class ucDiscordRPC
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new System.Windows.Forms.Label();
            pnlCard = new System.Windows.Forms.Panel();
            lblClientId = new System.Windows.Forms.Label();
            txtClientId = new System.Windows.Forms.TextBox();
            lblImageLink = new System.Windows.Forms.Label();
            txtImageLink = new System.Windows.Forms.TextBox();
            lblDetails = new System.Windows.Forms.Label();
            txtDetails = new System.Windows.Forms.TextBox();
            lblState = new System.Windows.Forms.Label();
            txtState = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnConnect = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDisconnect = new System.Windows.Forms.Button();
            lblStatus = new System.Windows.Forms.Label();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)31)), ((int)((byte)41)), ((int)((byte)55)));
            lblTitle.Location = new System.Drawing.Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(435, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Discord Durum Yönetimi";
            // 
            // pnlCard
            // 
            pnlCard.BackColor = System.Drawing.Color.White;
            pnlCard.Controls.Add(lblClientId);
            pnlCard.Controls.Add(txtClientId);
            pnlCard.Controls.Add(lblImageLink);
            pnlCard.Controls.Add(txtImageLink);
            pnlCard.Controls.Add(lblDetails);
            pnlCard.Controls.Add(txtDetails);
            pnlCard.Controls.Add(lblState);
            pnlCard.Controls.Add(txtState);
            pnlCard.Controls.Add(label1);
            pnlCard.Controls.Add(btnConnect);
            pnlCard.Controls.Add(btnUpdate);
            pnlCard.Controls.Add(btnDisconnect);
            pnlCard.Controls.Add(lblStatus);
            pnlCard.Location = new System.Drawing.Point(25, 70);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new System.Drawing.Size(761, 344);
            pnlCard.TabIndex = 1;
            // 
            // lblClientId
            // 
            lblClientId.AutoSize = true;
            lblClientId.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblClientId.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)114)), ((int)((byte)128)));
            lblClientId.Location = new System.Drawing.Point(20, 20);
            lblClientId.Name = "lblClientId";
            lblClientId.Size = new System.Drawing.Size(90, 28);
            lblClientId.TabIndex = 0;
            lblClientId.Text = "Client ID";
            // 
            // txtClientId
            // 
            txtClientId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtClientId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            txtClientId.Location = new System.Drawing.Point(20, 48);
            txtClientId.Name = "txtClientId";
            txtClientId.Size = new System.Drawing.Size(294, 34);
            txtClientId.TabIndex = 1;
            // 
            // lblImageLink
            // 
            lblImageLink.AutoSize = true;
            lblImageLink.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblImageLink.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)114)), ((int)((byte)128)));
            lblImageLink.Location = new System.Drawing.Point(362, 20);
            lblImageLink.Name = "lblImageLink";
            lblImageLink.Size = new System.Drawing.Size(308, 28);
            lblImageLink.TabIndex = 2;
            lblImageLink.Text = "Resim Anahtarı (LargeImageKey)";
            // 
            // txtImageLink
            // 
            txtImageLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtImageLink.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            txtImageLink.Location = new System.Drawing.Point(362, 48);
            txtImageLink.Name = "txtImageLink";
            txtImageLink.Size = new System.Drawing.Size(372, 34);
            txtImageLink.TabIndex = 3;
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblDetails.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)114)), ((int)((byte)128)));
            lblDetails.Location = new System.Drawing.Point(20, 85);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new System.Drawing.Size(163, 28);
            lblDetails.TabIndex = 4;
            lblDetails.Text = "Üst Yazı (Details)";
            // 
            // txtDetails
            // 
            txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            txtDetails.Location = new System.Drawing.Point(20, 113);
            txtDetails.Name = "txtDetails";
            txtDetails.Size = new System.Drawing.Size(294, 34);
            txtDetails.TabIndex = 5;
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblState.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)114)), ((int)((byte)128)));
            lblState.Location = new System.Drawing.Point(362, 85);
            lblState.Name = "lblState";
            lblState.Size = new System.Drawing.Size(142, 28);
            lblState.TabIndex = 6;
            lblState.Text = "Alt Yazı (State)";
            // 
            // txtState
            // 
            txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            txtState.Location = new System.Drawing.Point(362, 113);
            txtState.Name = "txtState";
            txtState.Size = new System.Drawing.Size(372, 34);
            txtState.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)162));
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)156)), ((int)((byte)163)), ((int)((byte)175)));
            label1.Location = new System.Drawing.Point(20, 155);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(592, 50);
            label1.TabIndex = 8;
            label1.Text = ("\"Bağlan\" butonuna bastıktan sonra \"Durumu Güncelle\" butonuna basarak\ndurumunuzu a" + "yarlayabilirsiniz.");
            // 
            // btnConnect
            // 
            btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
            btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            btnConnect.FlatAppearance.BorderSize = 0;
            btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConnect.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            btnConnect.ForeColor = System.Drawing.Color.White;
            btnConnect.Location = new System.Drawing.Point(20, 210);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new System.Drawing.Size(100, 35);
            btnConnect.TabIndex = 9;
            btnConnect.Text = "Bağlan";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)((byte)16)), ((int)((byte)185)), ((int)((byte)129)));
            btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            btnUpdate.ForeColor = System.Drawing.Color.White;
            btnUpdate.Location = new System.Drawing.Point(135, 210);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(140, 35);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Durumu Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)68)), ((int)((byte)68)));
            btnDisconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDisconnect.Enabled = false;
            btnDisconnect.FlatAppearance.BorderSize = 0;
            btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDisconnect.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            btnDisconnect.ForeColor = System.Drawing.Color.White;
            btnDisconnect.Location = new System.Drawing.Point(290, 210);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new System.Drawing.Size(203, 35);
            btnDisconnect.TabIndex = 11;
            btnDisconnect.Text = "Bağlantıyı Kes";
            btnDisconnect.UseVisualStyleBackColor = false;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)158)), ((int)((byte)11)));
            lblStatus.Location = new System.Drawing.Point(20, 265);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(202, 28);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Durum: Bekleniyor...";
            // 
            // ucDiscordRPC
            // 
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)243)), ((int)((byte)244)), ((int)((byte)246)));
            Controls.Add(pnlCard);
            Controls.Add(lblTitle);
            Size = new System.Drawing.Size(813, 442);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private System.Windows.Forms.Panel pnlCard;
        private Label lblClientId;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label lblImageLink;
        private System.Windows.Forms.TextBox txtImageLink;
        private Label lblDetails;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtState;
        private Label label1; // Bilgi yazısı
        private Label lblStatus;
        private Button btnConnect;
        private Button btnUpdate;
        private System.Windows.Forms.Button btnDisconnect;
    }
}
