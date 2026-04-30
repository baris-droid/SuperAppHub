namespace SmartApp
{
    partial class ucNetworkPower
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
            lblPageTitle = new System.Windows.Forms.Label();
            pnlCard = new System.Windows.Forms.Panel();
            lblCardTitle = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            numThreshold = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            numWaitTime = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            cmbActionType = new System.Windows.Forms.ComboBox();
            btnToggleMonitor = new System.Windows.Forms.Button();
            lblStatus = new System.Windows.Forms.Label();
            pnlAlert = new System.Windows.Forms.Panel();
            lblAlertIcon = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numThreshold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWaitTime).BeginInit();
            pnlAlert.SuspendLayout();
            SuspendLayout();
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)31)), ((int)((byte)41)), ((int)((byte)55)));
            lblPageTitle.Location = new System.Drawing.Point(20, 20);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new System.Drawing.Size(350, 48);
            lblPageTitle.TabIndex = 2;
            lblPageTitle.Text = "Ağ ve Güç Yönetimi";
            // 
            // pnlCard
            // 
            pnlCard.BackColor = System.Drawing.Color.White;
            pnlCard.Controls.Add(lblCardTitle);
            pnlCard.Controls.Add(label1);
            pnlCard.Controls.Add(numThreshold);
            pnlCard.Controls.Add(label2);
            pnlCard.Controls.Add(numWaitTime);
            pnlCard.Controls.Add(label3);
            pnlCard.Controls.Add(cmbActionType);
            pnlCard.Controls.Add(btnToggleMonitor);
            pnlCard.Controls.Add(lblStatus);
            pnlCard.Location = new System.Drawing.Point(25, 70);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new System.Drawing.Size(564, 240);
            pnlCard.TabIndex = 1;
            // 
            // lblCardTitle
            // 
            lblCardTitle.AutoSize = true;
            lblCardTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblCardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)55)), ((int)((byte)65)), ((int)((byte)81)));
            lblCardTitle.Location = new System.Drawing.Point(15, 15);
            lblCardTitle.Name = "lblCardTitle";
            lblCardTitle.Size = new System.Drawing.Size(237, 32);
            lblCardTitle.TabIndex = 0;
            lblCardTitle.Text = "Otomasyon Kuralları";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)114)), ((int)((byte)128)));
            label1.Location = new System.Drawing.Point(20, 55);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(247, 28);
            label1.TabIndex = 1;
            label1.Text = "Minimum Hız Sınırı (KB/s)";
            // 
            // numThreshold
            // 
            numThreshold.DecimalPlaces = 2;
            numThreshold.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            numThreshold.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numThreshold.Location = new System.Drawing.Point(20, 83);
            numThreshold.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numThreshold.Name = "numThreshold";
            numThreshold.Size = new System.Drawing.Size(190, 34);
            numThreshold.TabIndex = 2;
            numThreshold.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)114)), ((int)((byte)128)));
            label2.Location = new System.Drawing.Point(288, 55);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(231, 28);
            label2.TabIndex = 3;
            label2.Text = "Bekleme Süresi (Saniye)";
            // 
            // numWaitTime
            // 
            numWaitTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            numWaitTime.Location = new System.Drawing.Point(288, 83);
            numWaitTime.Maximum = new decimal(new int[] { 86400, 0, 0, 0 });
            numWaitTime.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numWaitTime.Name = "numWaitTime";
            numWaitTime.Size = new System.Drawing.Size(190, 34);
            numWaitTime.TabIndex = 4;
            numWaitTime.Value = new decimal(new int[] { 180, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            label3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)114)), ((int)((byte)128)));
            label3.Location = new System.Drawing.Point(20, 115);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(197, 28);
            label3.TabIndex = 5;
            label3.Text = "Gerçekleşecek İşlem";
            // 
            // cmbActionType
            // 
            cmbActionType.BackColor = System.Drawing.Color.FromArgb(((int)((byte)249)), ((int)((byte)250)), ((int)((byte)251)));
            cmbActionType.Cursor = System.Windows.Forms.Cursors.Hand;
            cmbActionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbActionType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbActionType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            cmbActionType.Items.AddRange(new object[] { "Uyku Modu (Sleep)", "Bilgisayarı Kapat (Shutdown)" });
            cmbActionType.Location = new System.Drawing.Point(20, 142);
            cmbActionType.Name = "cmbActionType";
            cmbActionType.Size = new System.Drawing.Size(410, 36);
            cmbActionType.TabIndex = 6;
            // 
            // btnToggleMonitor
            // 
            btnToggleMonitor.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
            btnToggleMonitor.Cursor = System.Windows.Forms.Cursors.Hand;
            btnToggleMonitor.FlatAppearance.BorderSize = 0;
            btnToggleMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnToggleMonitor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            btnToggleMonitor.ForeColor = System.Drawing.Color.White;
            btnToggleMonitor.Location = new System.Drawing.Point(20, 190);
            btnToggleMonitor.Name = "btnToggleMonitor";
            btnToggleMonitor.Size = new System.Drawing.Size(150, 35);
            btnToggleMonitor.TabIndex = 7;
            btnToggleMonitor.Text = "İzlemeyi Başlat";
            btnToggleMonitor.UseVisualStyleBackColor = false;
            btnToggleMonitor.Click += btnToggleMonitor_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)158)), ((int)((byte)11)));
            lblStatus.Location = new System.Drawing.Point(180, 193);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(189, 28);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Durum: Bekleniyor";
            // 
            // pnlAlert
            // 
            pnlAlert.BackColor = System.Drawing.Color.FromArgb(((int)((byte)254)), ((int)((byte)242)), ((int)((byte)242)));
            pnlAlert.Controls.Add(lblAlertIcon);
            pnlAlert.Controls.Add(label4);
            pnlAlert.Location = new System.Drawing.Point(25, 325);
            pnlAlert.Name = "pnlAlert";
            pnlAlert.Size = new System.Drawing.Size(564, 64);
            pnlAlert.TabIndex = 0;
            // 
            // lblAlertIcon
            // 
            lblAlertIcon.AutoSize = true;
            lblAlertIcon.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblAlertIcon.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)38)), ((int)((byte)38)));
            lblAlertIcon.Location = new System.Drawing.Point(10, 10);
            lblAlertIcon.Name = "lblAlertIcon";
            lblAlertIcon.Size = new System.Drawing.Size(56, 38);
            lblAlertIcon.TabIndex = 0;
            lblAlertIcon.Text = "⚠";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)153)), ((int)((byte)27)), ((int)((byte)27)));
            label4.Location = new System.Drawing.Point(61, 7);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(494, 50);
            label4.TabIndex = 1;
            label4.Text = ("Gerçekleşecek işlem olarak \"Bilgisayarı Kapat\" seçeneğinin\nçalışması için uygulam" + "ayı Yönetici Olarak çalıştırmanız gerekir.");
            // 
            // ucNetworkPower
            // 
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)243)), ((int)((byte)244)), ((int)((byte)246)));
            Controls.Add(pnlAlert);
            Controls.Add(pnlCard);
            Controls.Add(lblPageTitle);
            Size = new System.Drawing.Size(904, 407);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numThreshold).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWaitTime).EndInit();
            pnlAlert.ResumeLayout(false);
            pnlAlert.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageTitle;

        // Ayarlar Kartı
        private System.Windows.Forms.Panel pnlCard;
        private Label lblCardTitle;
        private Label label1; // Hız sınırı label
        private System.Windows.Forms.NumericUpDown numThreshold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numWaitTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbActionType;
        private System.Windows.Forms.Button btnToggleMonitor;
        private Label lblStatus;

        // Uyarı Kartı (Alert Box)
        private System.Windows.Forms.Panel pnlAlert;
        private System.Windows.Forms.Label lblAlertIcon;
        private System.Windows.Forms.Label label4;
    }
}
