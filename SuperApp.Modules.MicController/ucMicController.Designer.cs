namespace SmartApp
{
    partial class ucMicController
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
            pnlActiveCard = new System.Windows.Forms.Panel();
            lblActiveCardTitle = new System.Windows.Forms.Label();
            chkGlobalMute = new System.Windows.Forms.CheckBox();
            lblMicStatusIndicator = new System.Windows.Forms.Label();
            chkEnableToggle = new System.Windows.Forms.CheckBox();
            btnSetToggleKey = new System.Windows.Forms.Button();
            pnlSoonCard = new System.Windows.Forms.Panel();
            lblSoonCardTitle = new System.Windows.Forms.Label();
            lblSoonBadge = new System.Windows.Forms.Label();
            chkEnablePTT = new System.Windows.Forms.CheckBox();
            btnSetHotkey = new System.Windows.Forms.Button();
            pnlActiveCard.SuspendLayout();
            pnlSoonCard.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)31)), ((int)((byte)41)), ((int)((byte)55)));
            lblTitle.Location = new System.Drawing.Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(239, 48);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Ses Denetimi";
            // 
            // pnlActiveCard
            // 
            pnlActiveCard.BackColor = System.Drawing.Color.White;
            pnlActiveCard.Controls.Add(lblActiveCardTitle);
            pnlActiveCard.Controls.Add(chkGlobalMute);
            pnlActiveCard.Controls.Add(lblMicStatusIndicator);
            pnlActiveCard.Controls.Add(chkEnableToggle);
            pnlActiveCard.Controls.Add(btnSetToggleKey);
            pnlActiveCard.Location = new System.Drawing.Point(25, 70);
            pnlActiveCard.Name = "pnlActiveCard";
            pnlActiveCard.Size = new System.Drawing.Size(450, 174);
            pnlActiveCard.TabIndex = 1;
            // 
            // lblActiveCardTitle
            // 
            lblActiveCardTitle.AutoSize = true;
            lblActiveCardTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblActiveCardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)55)), ((int)((byte)65)), ((int)((byte)81)));
            lblActiveCardTitle.Location = new System.Drawing.Point(15, 15);
            lblActiveCardTitle.Name = "lblActiveCardTitle";
            lblActiveCardTitle.Size = new System.Drawing.Size(162, 32);
            lblActiveCardTitle.TabIndex = 0;
            lblActiveCardTitle.Text = "Genel Ayarlar";
            // 
            // chkGlobalMute
            // 
            chkGlobalMute.AutoSize = true;
            chkGlobalMute.Cursor = System.Windows.Forms.Cursors.Hand;
            chkGlobalMute.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
            chkGlobalMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkGlobalMute.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            chkGlobalMute.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)75)), ((int)((byte)85)), ((int)((byte)99)));
            chkGlobalMute.Location = new System.Drawing.Point(20, 50);
            chkGlobalMute.Name = "chkGlobalMute";
            chkGlobalMute.Size = new System.Drawing.Size(269, 32);
            chkGlobalMute.TabIndex = 1;
            chkGlobalMute.Text = "Mikrofonu Tamamen Kapat";
            chkGlobalMute.CheckedChanged += chkGlobalMute_CheckedChanged;
            // 
            // lblMicStatusIndicator
            // 
            lblMicStatusIndicator.AutoSize = true;
            lblMicStatusIndicator.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblMicStatusIndicator.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)16)), ((int)((byte)185)), ((int)((byte)129)));
            lblMicStatusIndicator.Location = new System.Drawing.Point(307, 52);
            lblMicStatusIndicator.Name = "lblMicStatusIndicator";
            lblMicStatusIndicator.Size = new System.Drawing.Size(135, 28);
            lblMicStatusIndicator.TabIndex = 2;
            lblMicStatusIndicator.Text = "Durum: Aktif";
            // 
            // chkEnableToggle
            // 
            chkEnableToggle.AutoSize = true;
            chkEnableToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            chkEnableToggle.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
            chkEnableToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkEnableToggle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            chkEnableToggle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)75)), ((int)((byte)85)), ((int)((byte)99)));
            chkEnableToggle.Location = new System.Drawing.Point(20, 85);
            chkEnableToggle.Name = "chkEnableToggle";
            chkEnableToggle.Size = new System.Drawing.Size(303, 32);
            chkEnableToggle.TabIndex = 3;
            chkEnableToggle.Text = "Susturma Kısayolunu Aktifleştir";
            // 
            // btnSetToggleKey
            // 
            btnSetToggleKey.BackColor = System.Drawing.Color.FromArgb(((int)((byte)249)), ((int)((byte)250)), ((int)((byte)251)));
            btnSetToggleKey.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSetToggleKey.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)209)), ((int)((byte)213)), ((int)((byte)219)));
            btnSetToggleKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSetToggleKey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            btnSetToggleKey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)55)), ((int)((byte)65)), ((int)((byte)81)));
            btnSetToggleKey.Location = new System.Drawing.Point(45, 122);
            btnSetToggleKey.Name = "btnSetToggleKey";
            btnSetToggleKey.Size = new System.Drawing.Size(244, 39);
            btnSetToggleKey.TabIndex = 4;
            btnSetToggleKey.Text = "Kısayol Ata";
            btnSetToggleKey.UseVisualStyleBackColor = false;
            // 
            // pnlSoonCard
            // 
            pnlSoonCard.BackColor = System.Drawing.Color.White;
            pnlSoonCard.Controls.Add(lblSoonCardTitle);
            pnlSoonCard.Controls.Add(lblSoonBadge);
            pnlSoonCard.Controls.Add(chkEnablePTT);
            pnlSoonCard.Controls.Add(btnSetHotkey);
            pnlSoonCard.Location = new System.Drawing.Point(25, 250);
            pnlSoonCard.Name = "pnlSoonCard";
            pnlSoonCard.Size = new System.Drawing.Size(450, 129);
            pnlSoonCard.TabIndex = 0;
            // 
            // lblSoonCardTitle
            // 
            lblSoonCardTitle.AutoSize = true;
            lblSoonCardTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblSoonCardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)156)), ((int)((byte)163)), ((int)((byte)175)));
            lblSoonCardTitle.Location = new System.Drawing.Point(15, 15);
            lblSoonCardTitle.Name = "lblSoonCardTitle";
            lblSoonCardTitle.Size = new System.Drawing.Size(237, 32);
            lblSoonCardTitle.TabIndex = 0;
            lblSoonCardTitle.Text = "Gelişmiş Ses Modları";
            // 
            // lblSoonBadge
            // 
            lblSoonBadge.AutoSize = true;
            lblSoonBadge.BackColor = System.Drawing.Color.FromArgb(((int)((byte)254)), ((int)((byte)243)), ((int)((byte)199)));
            lblSoonBadge.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblSoonBadge.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)217)), ((int)((byte)119)), ((int)((byte)6)));
            lblSoonBadge.Location = new System.Drawing.Point(260, 18);
            lblSoonBadge.Name = "lblSoonBadge";
            lblSoonBadge.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            lblSoonBadge.Size = new System.Drawing.Size(89, 25);
            lblSoonBadge.TabIndex = 1;
            lblSoonBadge.Text = "YAKINDA";
            // 
            // chkEnablePTT
            // 
            chkEnablePTT.AutoSize = true;
            chkEnablePTT.Enabled = false;
            chkEnablePTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkEnablePTT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            chkEnablePTT.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)156)), ((int)((byte)163)), ((int)((byte)175)));
            chkEnablePTT.Location = new System.Drawing.Point(20, 50);
            chkEnablePTT.Name = "chkEnablePTT";
            chkEnablePTT.Size = new System.Drawing.Size(292, 32);
            chkEnablePTT.TabIndex = 2;
            chkEnablePTT.Text = "Bas-Konuş Modunu Aktifleştir";
            // 
            // btnSetHotkey
            // 
            btnSetHotkey.BackColor = System.Drawing.Color.FromArgb(((int)((byte)243)), ((int)((byte)244)), ((int)((byte)246)));
            btnSetHotkey.Enabled = false;
            btnSetHotkey.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)229)), ((int)((byte)231)), ((int)((byte)235)));
            btnSetHotkey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSetHotkey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            btnSetHotkey.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)156)), ((int)((byte)163)), ((int)((byte)175)));
            btnSetHotkey.Location = new System.Drawing.Point(45, 80);
            btnSetHotkey.Name = "btnSetHotkey";
            btnSetHotkey.Size = new System.Drawing.Size(184, 40);
            btnSetHotkey.TabIndex = 3;
            btnSetHotkey.Text = "Tuş Ata (Şu an: V)";
            btnSetHotkey.UseVisualStyleBackColor = false;
            // 
            // ucMicController
            // 
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)243)), ((int)((byte)244)), ((int)((byte)246)));
            Controls.Add(pnlSoonCard);
            Controls.Add(pnlActiveCard);
            Controls.Add(lblTitle);
            Size = new System.Drawing.Size(904, 407);
            pnlActiveCard.ResumeLayout(false);
            pnlActiveCard.PerformLayout();
            pnlSoonCard.ResumeLayout(false);
            pnlSoonCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;

        // Aktif Ayarlar Kartı
        private System.Windows.Forms.Panel pnlActiveCard;
        private Label lblActiveCardTitle;
        private CheckBox chkGlobalMute;
        private CheckBox chkEnableToggle;
        private System.Windows.Forms.Button btnSetToggleKey;
        private System.Windows.Forms.Label lblMicStatusIndicator;

        // Yakında (Coming Soon) Kartı
        private System.Windows.Forms.Panel pnlSoonCard;
        private Label lblSoonCardTitle;
        private System.Windows.Forms.Label lblSoonBadge;
        private CheckBox chkEnablePTT;
        private System.Windows.Forms.Button btnSetHotkey;
    }
}
