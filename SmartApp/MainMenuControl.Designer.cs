namespace SmartApp
{
    partial class MainMenuControl
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlSettingsCard = new System.Windows.Forms.Panel();
            this.chkDarkMode = new System.Windows.Forms.CheckBox();
            this.chkMinimizeToTray = new System.Windows.Forms.CheckBox();
            this.lblSettingsTitle = new System.Windows.Forms.Label();
            this.pnlInfoCard = new System.Windows.Forms.Panel();
            this.lblInfoDesc = new System.Windows.Forms.Label();
            this.lblInfoTitle = new System.Windows.Forms.Label();
            this.pnlSettingsCard.SuspendLayout();
            this.pnlInfoCard.SuspendLayout();
            this.SuspendLayout();
            
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(359, 32);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Kontrol Paneline Hoş Geldiniz";
            
            // 
            // pnlSettingsCard
            // 
            this.pnlSettingsCard.Controls.Add(this.chkDarkMode);
            this.pnlSettingsCard.Controls.Add(this.chkMinimizeToTray);
            this.pnlSettingsCard.Controls.Add(this.lblSettingsTitle);
            this.pnlSettingsCard.Location = new System.Drawing.Point(25, 80);
            this.pnlSettingsCard.Name = "pnlSettingsCard";
            this.pnlSettingsCard.Size = new System.Drawing.Size(500, 135);
            this.pnlSettingsCard.TabIndex = 1;
            
            // 
            // chkDarkMode
            // 
            this.chkDarkMode.AutoSize = true;
            this.chkDarkMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDarkMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDarkMode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.chkDarkMode.Location = new System.Drawing.Point(20, 85);
            this.chkDarkMode.Name = "chkDarkMode";
            this.chkDarkMode.Size = new System.Drawing.Size(155, 23);
            this.chkDarkMode.TabIndex = 4;
            this.chkDarkMode.Text = "Karanlık Tema Kullan";
            this.chkDarkMode.UseVisualStyleBackColor = true;
            this.chkDarkMode.CheckedChanged += new System.EventHandler(this.chkDarkMode_CheckedChanged);
            
            // 
            // chkMinimizeToTray
            // 
            this.chkMinimizeToTray.AutoSize = true;
            this.chkMinimizeToTray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkMinimizeToTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMinimizeToTray.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.chkMinimizeToTray.Location = new System.Drawing.Point(20, 50);
            this.chkMinimizeToTray.Name = "chkMinimizeToTray";
            this.chkMinimizeToTray.Size = new System.Drawing.Size(227, 23);
            this.chkMinimizeToTray.TabIndex = 3;
            this.chkMinimizeToTray.Text = "Çarpıya basınca arka plana küçült";
            this.chkMinimizeToTray.UseVisualStyleBackColor = true;
            this.chkMinimizeToTray.CheckedChanged += new System.EventHandler(this.chkMinimizeToTray_CheckedChanged);
            
            // 
            // lblSettingsTitle
            // 
            this.lblSettingsTitle.AutoSize = true;
            this.lblSettingsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblSettingsTitle.Location = new System.Drawing.Point(15, 15);
            this.lblSettingsTitle.Name = "lblSettingsTitle";
            this.lblSettingsTitle.Size = new System.Drawing.Size(109, 21);
            this.lblSettingsTitle.TabIndex = 2;
            this.lblSettingsTitle.Text = "Genel Ayarlar";
            
            // 
            // pnlInfoCard
            // 
            this.pnlInfoCard.Controls.Add(this.lblInfoDesc);
            this.pnlInfoCard.Controls.Add(this.lblInfoTitle);
            this.pnlInfoCard.Location = new System.Drawing.Point(25, 235);
            this.pnlInfoCard.Name = "pnlInfoCard";
            this.pnlInfoCard.Size = new System.Drawing.Size(500, 120);
            this.pnlInfoCard.TabIndex = 4;
            
            // 
            // lblInfoDesc
            // 
            this.lblInfoDesc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.lblInfoDesc.Location = new System.Drawing.Point(16, 46);
            this.lblInfoDesc.Name = "lblInfoDesc";
            this.lblInfoDesc.Size = new System.Drawing.Size(460, 60);
            this.lblInfoDesc.TabIndex = 1;
            this.lblInfoDesc.Text = "Tüm modüller aktif ve çalışıyor. Sol menüyü kullanarak özellikler arasında geçiş yapabilirsiniz.";
            
            // 
            // lblInfoTitle
            // 
            this.lblInfoTitle.AutoSize = true;
            this.lblInfoTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblInfoTitle.Location = new System.Drawing.Point(15, 15);
            this.lblInfoTitle.Name = "lblInfoTitle";
            this.lblInfoTitle.Size = new System.Drawing.Size(123, 21);
            this.lblInfoTitle.TabIndex = 0;
            this.lblInfoTitle.Text = "Sistem Durumu";
            
            // 
            // MainMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlInfoCard);
            this.Controls.Add(this.pnlSettingsCard);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.Name = "MainMenuControl";
            this.Size = new System.Drawing.Size(600, 450);
            this.pnlSettingsCard.ResumeLayout(false);
            this.pnlSettingsCard.PerformLayout();
            this.pnlInfoCard.ResumeLayout(false);
            this.pnlInfoCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlSettingsCard;
        private System.Windows.Forms.CheckBox chkDarkMode; // YENİ EKLENEN
        private System.Windows.Forms.CheckBox chkMinimizeToTray;
        private System.Windows.Forms.Label lblSettingsTitle;
        private System.Windows.Forms.Panel pnlInfoCard;
        private System.Windows.Forms.Label lblInfoDesc;
        private System.Windows.Forms.Label lblInfoTitle;
    }
}