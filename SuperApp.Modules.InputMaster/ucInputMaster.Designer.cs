namespace SmartApp
{
    partial class ucInputMaster
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
            pnlControl = new System.Windows.Forms.Panel();
            btnToggleInput = new System.Windows.Forms.Button();
            lblStatus = new System.Windows.Forms.Label();
            pnlScrollCard = new System.Windows.Forms.Panel();
            lblScrollIcon = new System.Windows.Forms.Label();
            lblScrollTitle = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            numScrollMult = new System.Windows.Forms.NumericUpDown();
            btnSetScrollKey = new System.Windows.Forms.Button();
            pnlVolumeCard = new System.Windows.Forms.Panel();
            lblVolumeIcon = new System.Windows.Forms.Label();
            lblVolumeTitle = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            numVolSens = new System.Windows.Forms.NumericUpDown();
            btnSetVolumeKey = new System.Windows.Forms.Button();
            pnlControl.SuspendLayout();
            pnlScrollCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numScrollMult).BeginInit();
            pnlVolumeCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numVolSens).BeginInit();
            SuspendLayout();
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)31)), ((int)((byte)41)), ((int)((byte)55)));
            lblPageTitle.Location = new System.Drawing.Point(20, 20);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new System.Drawing.Size(433, 48);
            lblPageTitle.TabIndex = 3;
            lblPageTitle.Text = "Giriş ve Kısayol Yönetimi";
            // 
            // pnlControl
            // 
            pnlControl.BackColor = System.Drawing.Color.White;
            pnlControl.Controls.Add(btnToggleInput);
            pnlControl.Controls.Add(lblStatus);
            pnlControl.Location = new System.Drawing.Point(25, 74);
            pnlControl.Name = "pnlControl";
            pnlControl.Size = new System.Drawing.Size(450, 70);
            pnlControl.TabIndex = 2;
            // 
            // btnToggleInput
            // 
            btnToggleInput.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
            btnToggleInput.Cursor = System.Windows.Forms.Cursors.Hand;
            btnToggleInput.FlatAppearance.BorderSize = 0;
            btnToggleInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnToggleInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            btnToggleInput.ForeColor = System.Drawing.Color.White;
            btnToggleInput.Location = new System.Drawing.Point(15, 15);
            btnToggleInput.Name = "btnToggleInput";
            btnToggleInput.Size = new System.Drawing.Size(200, 40);
            btnToggleInput.TabIndex = 0;
            btnToggleInput.Text = "Kısayolları Başlat";
            btnToggleInput.UseVisualStyleBackColor = false;
            btnToggleInput.Click += btnToggleInput_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)158)), ((int)((byte)11)));
            lblStatus.Location = new System.Drawing.Point(230, 20);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(216, 30);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Durum: Durduruldu";
            // 
            // pnlScrollCard
            // 
            pnlScrollCard.BackColor = System.Drawing.Color.White;
            pnlScrollCard.Controls.Add(lblScrollIcon);
            pnlScrollCard.Controls.Add(lblScrollTitle);
            pnlScrollCard.Controls.Add(label1);
            pnlScrollCard.Controls.Add(numScrollMult);
            pnlScrollCard.Controls.Add(btnSetScrollKey);
            pnlScrollCard.Location = new System.Drawing.Point(25, 155);
            pnlScrollCard.Name = "pnlScrollCard";
            pnlScrollCard.Size = new System.Drawing.Size(215, 184);
            pnlScrollCard.TabIndex = 1;
            // 
            // lblScrollIcon
            // 
            lblScrollIcon.AutoSize = true;
            lblScrollIcon.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblScrollIcon.Location = new System.Drawing.Point(10, 10);
            lblScrollIcon.Name = "lblScrollIcon";
            lblScrollIcon.Size = new System.Drawing.Size(55, 38);
            lblScrollIcon.TabIndex = 0;
            lblScrollIcon.Text = "🖱️";
            // 
            // lblScrollTitle
            // 
            lblScrollTitle.AutoSize = true;
            lblScrollTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblScrollTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)55)), ((int)((byte)65)), ((int)((byte)81)));
            lblScrollTitle.Location = new System.Drawing.Point(58, 13);
            lblScrollTitle.Name = "lblScrollTitle";
            lblScrollTitle.Size = new System.Drawing.Size(152, 30);
            lblScrollTitle.TabIndex = 1;
            lblScrollTitle.Text = "Fare Kaydırma";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)114)), ((int)((byte)128)));
            label1.Location = new System.Drawing.Point(15, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 25);
            label1.TabIndex = 2;
            label1.Text = "Hız Çarpanı";
            // 
            // numScrollMult
            // 
            numScrollMult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            numScrollMult.Location = new System.Drawing.Point(15, 75);
            numScrollMult.Name = "numScrollMult";
            numScrollMult.Size = new System.Drawing.Size(185, 34);
            numScrollMult.TabIndex = 3;
            numScrollMult.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // btnSetScrollKey
            // 
            btnSetScrollKey.BackColor = System.Drawing.Color.FromArgb(((int)((byte)249)), ((int)((byte)250)), ((int)((byte)251)));
            btnSetScrollKey.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSetScrollKey.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)209)), ((int)((byte)213)), ((int)((byte)219)));
            btnSetScrollKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSetScrollKey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            btnSetScrollKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)55)), ((int)((byte)65)), ((int)((byte)81)));
            btnSetScrollKey.Location = new System.Drawing.Point(15, 117);
            btnSetScrollKey.Name = "btnSetScrollKey";
            btnSetScrollKey.Size = new System.Drawing.Size(185, 43);
            btnSetScrollKey.TabIndex = 4;
            btnSetScrollKey.Text = "Scroll Kısayolu Ata";
            btnSetScrollKey.UseVisualStyleBackColor = false;
            btnSetScrollKey.Click += btnSetScrollKey_Click;
            // 
            // pnlVolumeCard
            // 
            pnlVolumeCard.BackColor = System.Drawing.Color.White;
            pnlVolumeCard.Controls.Add(lblVolumeIcon);
            pnlVolumeCard.Controls.Add(lblVolumeTitle);
            pnlVolumeCard.Controls.Add(label2);
            pnlVolumeCard.Controls.Add(numVolSens);
            pnlVolumeCard.Controls.Add(btnSetVolumeKey);
            pnlVolumeCard.Location = new System.Drawing.Point(260, 155);
            pnlVolumeCard.Name = "pnlVolumeCard";
            pnlVolumeCard.Size = new System.Drawing.Size(215, 184);
            pnlVolumeCard.TabIndex = 0;
            // 
            // lblVolumeIcon
            // 
            lblVolumeIcon.AutoSize = true;
            lblVolumeIcon.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblVolumeIcon.Location = new System.Drawing.Point(10, 10);
            lblVolumeIcon.Name = "lblVolumeIcon";
            lblVolumeIcon.Size = new System.Drawing.Size(55, 38);
            lblVolumeIcon.TabIndex = 0;
            lblVolumeIcon.Text = "🔊";
            // 
            // lblVolumeTitle
            // 
            lblVolumeTitle.AutoSize = true;
            lblVolumeTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblVolumeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)55)), ((int)((byte)65)), ((int)((byte)81)));
            lblVolumeTitle.Location = new System.Drawing.Point(60, 13);
            lblVolumeTitle.Name = "lblVolumeTitle";
            lblVolumeTitle.Size = new System.Drawing.Size(103, 30);
            lblVolumeTitle.TabIndex = 1;
            lblVolumeTitle.Text = "Ses Ayarı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)114)), ((int)((byte)128)));
            label2.Location = new System.Drawing.Point(15, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(162, 25);
            label2.TabIndex = 2;
            label2.Text = "Direnç / Hassasiyet";
            // 
            // numVolSens
            // 
            numVolSens.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            numVolSens.Location = new System.Drawing.Point(15, 75);
            numVolSens.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numVolSens.Name = "numVolSens";
            numVolSens.Size = new System.Drawing.Size(185, 34);
            numVolSens.TabIndex = 3;
            numVolSens.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // btnSetVolumeKey
            // 
            btnSetVolumeKey.BackColor = System.Drawing.Color.FromArgb(((int)((byte)249)), ((int)((byte)250)), ((int)((byte)251)));
            btnSetVolumeKey.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSetVolumeKey.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)209)), ((int)((byte)213)), ((int)((byte)219)));
            btnSetVolumeKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSetVolumeKey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            btnSetVolumeKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)55)), ((int)((byte)65)), ((int)((byte)81)));
            btnSetVolumeKey.Location = new System.Drawing.Point(15, 117);
            btnSetVolumeKey.Name = "btnSetVolumeKey";
            btnSetVolumeKey.Size = new System.Drawing.Size(185, 43);
            btnSetVolumeKey.TabIndex = 4;
            btnSetVolumeKey.Text = "Ses Kısayolu Ata";
            btnSetVolumeKey.UseVisualStyleBackColor = false;
            btnSetVolumeKey.Click += btnSetVolumeKey_Click;
            // 
            // ucInputMaster
            // 
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)243)), ((int)((byte)244)), ((int)((byte)246)));
            Controls.Add(pnlVolumeCard);
            Controls.Add(pnlScrollCard);
            Controls.Add(pnlControl);
            Controls.Add(lblPageTitle);
            Size = new System.Drawing.Size(904, 407);
            pnlControl.ResumeLayout(false);
            pnlControl.PerformLayout();
            pnlScrollCard.ResumeLayout(false);
            pnlScrollCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numScrollMult).EndInit();
            pnlVolumeCard.ResumeLayout(false);
            pnlVolumeCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numVolSens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageTitle;

        // Üst Kontrol Paneli (Şalter)
        private System.Windows.Forms.Panel pnlControl;
        private Button btnToggleInput;
        private System.Windows.Forms.Label lblStatus;

        // Scroll Kartı
        private System.Windows.Forms.Panel pnlScrollCard;
        private Label lblScrollIcon;
        private System.Windows.Forms.Label lblScrollTitle;
        private Label label1;
        private System.Windows.Forms.NumericUpDown numScrollMult;
        private System.Windows.Forms.Button btnSetScrollKey;

        // Volume Kartı
        private System.Windows.Forms.Panel pnlVolumeCard;
        private Label lblVolumeIcon;
        private System.Windows.Forms.Label lblVolumeTitle;
        private Label label2;
        private System.Windows.Forms.NumericUpDown numVolSens;
        private System.Windows.Forms.Button btnSetVolumeKey;
    }
}
