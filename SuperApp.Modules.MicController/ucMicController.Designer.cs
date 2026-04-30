namespace SmartApp
{
    partial class ucMicController
    {
        private System.ComponentModel.IContainer components = null;

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
            this.pnlActiveCard = new System.Windows.Forms.Panel();
            this.lblActiveCardTitle = new System.Windows.Forms.Label();
            this.chkGlobalMute = new System.Windows.Forms.CheckBox();
            this.lblMicStatusIndicator = new System.Windows.Forms.Label();
            this.chkEnableToggle = new System.Windows.Forms.CheckBox();
            this.btnSetToggleKey = new System.Windows.Forms.Button();
            this.pnlSoonCard = new System.Windows.Forms.Panel();
            this.lblSoonCardTitle = new System.Windows.Forms.Label();
            this.lblSoonBadge = new System.Windows.Forms.Label();
            this.chkEnablePTT = new System.Windows.Forms.CheckBox();
            this.btnSetHotkey = new System.Windows.Forms.Button();
            
            this.pnlActiveCard.SuspendLayout();
            this.pnlSoonCard.SuspendLayout();
            this.SuspendLayout();
            
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 32);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Ses Denetimi";
            
            // 
            // pnlActiveCard
            // 
            this.pnlActiveCard.Controls.Add(this.lblActiveCardTitle);
            this.pnlActiveCard.Controls.Add(this.chkGlobalMute);
            this.pnlActiveCard.Controls.Add(this.lblMicStatusIndicator);
            this.pnlActiveCard.Controls.Add(this.chkEnableToggle);
            this.pnlActiveCard.Controls.Add(this.btnSetToggleKey);
            this.pnlActiveCard.Location = new System.Drawing.Point(25, 80);
            this.pnlActiveCard.Name = "pnlActiveCard";
            this.pnlActiveCard.Size = new System.Drawing.Size(500, 180);
            this.pnlActiveCard.TabIndex = 1;
            
            // 
            // lblActiveCardTitle
            // 
            this.lblActiveCardTitle.AutoSize = true;
            this.lblActiveCardTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblActiveCardTitle.Location = new System.Drawing.Point(15, 15);
            this.lblActiveCardTitle.Name = "lblActiveCardTitle";
            this.lblActiveCardTitle.Size = new System.Drawing.Size(109, 21);
            this.lblActiveCardTitle.TabIndex = 0;
            this.lblActiveCardTitle.Text = "Genel Ayarlar";
            
            // 
            // chkGlobalMute
            // 
            this.chkGlobalMute.AutoSize = true;
            this.chkGlobalMute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkGlobalMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkGlobalMute.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.chkGlobalMute.Location = new System.Drawing.Point(20, 50);
            this.chkGlobalMute.Name = "chkGlobalMute";
            this.chkGlobalMute.Size = new System.Drawing.Size(206, 24);
            this.chkGlobalMute.TabIndex = 1;
            this.chkGlobalMute.Text = "Mikrofonu Tamamen Kapat";
            this.chkGlobalMute.UseVisualStyleBackColor = true;
            
            // 
            // lblMicStatusIndicator
            // 
            this.lblMicStatusIndicator.AutoSize = true;
            this.lblMicStatusIndicator.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblMicStatusIndicator.Location = new System.Drawing.Point(240, 52);
            this.lblMicStatusIndicator.Name = "lblMicStatusIndicator";
            this.lblMicStatusIndicator.Size = new System.Drawing.Size(98, 20);
            this.lblMicStatusIndicator.TabIndex = 2;
            this.lblMicStatusIndicator.Text = "Durum: Aktif";
            
            // 
            // chkEnableToggle
            // 
            this.chkEnableToggle.AutoSize = true;
            this.chkEnableToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkEnableToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkEnableToggle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.chkEnableToggle.Location = new System.Drawing.Point(20, 85);
            this.chkEnableToggle.Name = "chkEnableToggle";
            this.chkEnableToggle.Size = new System.Drawing.Size(232, 24);
            this.chkEnableToggle.TabIndex = 3;
            this.chkEnableToggle.Text = "Susturma Kısayolunu Aktifleştir";
            this.chkEnableToggle.UseVisualStyleBackColor = true;
            
            // 
            // btnSetToggleKey
            // 
            this.btnSetToggleKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetToggleKey.FlatAppearance.BorderSize = 1;
            this.btnSetToggleKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetToggleKey.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.btnSetToggleKey.Location = new System.Drawing.Point(45, 120);
            this.btnSetToggleKey.Name = "btnSetToggleKey";
            this.btnSetToggleKey.Size = new System.Drawing.Size(260, 40);
            this.btnSetToggleKey.TabIndex = 4;
            this.btnSetToggleKey.Text = "Kısayol Ata";
            this.btnSetToggleKey.UseVisualStyleBackColor = false;
            
            // 
            // pnlSoonCard
            // 
            this.pnlSoonCard.Controls.Add(this.lblSoonCardTitle);
            this.pnlSoonCard.Controls.Add(this.lblSoonBadge);
            this.pnlSoonCard.Controls.Add(this.chkEnablePTT);
            this.pnlSoonCard.Controls.Add(this.btnSetHotkey);
            this.pnlSoonCard.Location = new System.Drawing.Point(25, 280);
            this.pnlSoonCard.Name = "pnlSoonCard";
            this.pnlSoonCard.Size = new System.Drawing.Size(500, 140);
            this.pnlSoonCard.TabIndex = 0;
            
            // 
            // lblSoonCardTitle
            // 
            this.lblSoonCardTitle.AutoSize = true;
            this.lblSoonCardTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblSoonCardTitle.Location = new System.Drawing.Point(15, 15);
            this.lblSoonCardTitle.Name = "lblSoonCardTitle";
            this.lblSoonCardTitle.Size = new System.Drawing.Size(159, 21);
            this.lblSoonCardTitle.TabIndex = 0;
            this.lblSoonCardTitle.Text = "Gelişmiş Ses Modları";
            
            // 
            // lblSoonBadge
            // 
            this.lblSoonBadge.AutoSize = true;
            this.lblSoonBadge.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblSoonBadge.Location = new System.Drawing.Point(185, 18);
            this.lblSoonBadge.Name = "lblSoonBadge";
            this.lblSoonBadge.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblSoonBadge.Size = new System.Drawing.Size(63, 17);
            this.lblSoonBadge.TabIndex = 1;
            this.lblSoonBadge.Text = "YAKINDA";
            
            // 
            // chkEnablePTT
            // 
            this.chkEnablePTT.AutoSize = true;
            this.chkEnablePTT.Enabled = false;
            this.chkEnablePTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkEnablePTT.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.chkEnablePTT.Location = new System.Drawing.Point(20, 50);
            this.chkEnablePTT.Name = "chkEnablePTT";
            this.chkEnablePTT.Size = new System.Drawing.Size(222, 24);
            this.chkEnablePTT.TabIndex = 2;
            this.chkEnablePTT.Text = "Bas-Konuş Modunu Aktifleştir";
            this.chkEnablePTT.UseVisualStyleBackColor = true;
            
            // 
            // btnSetHotkey
            // 
            this.btnSetHotkey.Enabled = false;
            this.btnSetHotkey.FlatAppearance.BorderSize = 1;
            this.btnSetHotkey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetHotkey.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.btnSetHotkey.Location = new System.Drawing.Point(45, 85);
            this.btnSetHotkey.Name = "btnSetHotkey";
            this.btnSetHotkey.Size = new System.Drawing.Size(260, 40);
            this.btnSetHotkey.TabIndex = 3;
            this.btnSetHotkey.Text = "Tuş Ata (Şu an: V)";
            this.btnSetHotkey.UseVisualStyleBackColor = false;
            
            // 
            // ucMicController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSoonCard);
            this.Controls.Add(this.pnlActiveCard);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.Name = "ucMicController";
            this.Size = new System.Drawing.Size(750, 480);
            
            this.pnlActiveCard.ResumeLayout(false);
            this.pnlActiveCard.PerformLayout();
            this.pnlSoonCard.ResumeLayout(false);
            this.pnlSoonCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlActiveCard;
        private System.Windows.Forms.Label lblActiveCardTitle;
        private System.Windows.Forms.CheckBox chkGlobalMute;
        private System.Windows.Forms.CheckBox chkEnableToggle;
        private System.Windows.Forms.Button btnSetToggleKey;
        private System.Windows.Forms.Label lblMicStatusIndicator;
        private System.Windows.Forms.Panel pnlSoonCard;
        private System.Windows.Forms.Label lblSoonCardTitle;
        private System.Windows.Forms.Label lblSoonBadge;
        private System.Windows.Forms.CheckBox chkEnablePTT;
        private System.Windows.Forms.Button btnSetHotkey;
    }
}