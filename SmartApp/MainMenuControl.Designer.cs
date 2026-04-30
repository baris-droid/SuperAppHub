// ucMainMenu.Designer.cs
namespace SmartApp
{
    partial class MainMenuControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new System.Windows.Forms.Label();
            pnlSettingsCard = new System.Windows.Forms.Panel();
            chkMinimizeToTray = new System.Windows.Forms.CheckBox();
            lblSettingsTitle = new System.Windows.Forms.Label();
            pnlInfoCard = new System.Windows.Forms.Panel();
            lblInfoDesc = new System.Windows.Forms.Label();
            lblInfoTitle = new System.Windows.Forms.Label();
            pnlSettingsCard.SuspendLayout();
            pnlInfoCard.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)31)), ((int)((byte)41)), ((int)((byte)55)));
            lblWelcome.Location = new System.Drawing.Point(20, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(521, 48);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Kontrol Paneline Hoş Geldiniz";
            // 
            // pnlSettingsCard
            // 
            pnlSettingsCard.BackColor = System.Drawing.Color.White;
            pnlSettingsCard.Controls.Add(chkMinimizeToTray);
            pnlSettingsCard.Controls.Add(lblSettingsTitle);
            pnlSettingsCard.Location = new System.Drawing.Point(25, 80);
            pnlSettingsCard.Name = "pnlSettingsCard";
            pnlSettingsCard.Size = new System.Drawing.Size(459, 100);
            pnlSettingsCard.TabIndex = 1;
            // 
            // chkMinimizeToTray
            // 
            chkMinimizeToTray.AutoSize = true;
            chkMinimizeToTray.Cursor = System.Windows.Forms.Cursors.Hand;
            chkMinimizeToTray.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
            chkMinimizeToTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkMinimizeToTray.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            chkMinimizeToTray.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)75)), ((int)((byte)85)), ((int)((byte)99)));
            chkMinimizeToTray.Location = new System.Drawing.Point(20, 50);
            chkMinimizeToTray.Name = "chkMinimizeToTray";
            chkMinimizeToTray.Size = new System.Drawing.Size(322, 32);
            chkMinimizeToTray.TabIndex = 3;
            chkMinimizeToTray.Text = "Çarpıya basınca arka plana küçült";
            chkMinimizeToTray.UseVisualStyleBackColor = true;
            chkMinimizeToTray.CheckedChanged += chkMinimizeToTray_CheckedChanged;
            // 
            // lblSettingsTitle
            // 
            lblSettingsTitle.AutoSize = true;
            lblSettingsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblSettingsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)55)), ((int)((byte)65)), ((int)((byte)81)));
            lblSettingsTitle.Location = new System.Drawing.Point(15, 15);
            lblSettingsTitle.Name = "lblSettingsTitle";
            lblSettingsTitle.Size = new System.Drawing.Size(162, 32);
            lblSettingsTitle.TabIndex = 2;
            lblSettingsTitle.Text = "Genel Ayarlar";
            // 
            // pnlInfoCard
            // 
            pnlInfoCard.BackColor = System.Drawing.Color.White;
            pnlInfoCard.Controls.Add(lblInfoDesc);
            pnlInfoCard.Controls.Add(lblInfoTitle);
            pnlInfoCard.Location = new System.Drawing.Point(25, 200);
            pnlInfoCard.Name = "pnlInfoCard";
            pnlInfoCard.Size = new System.Drawing.Size(459, 120);
            pnlInfoCard.TabIndex = 4;
            // 
            // lblInfoDesc
            // 
            lblInfoDesc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblInfoDesc.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)114)), ((int)((byte)128)));
            lblInfoDesc.Location = new System.Drawing.Point(16, 46);
            lblInfoDesc.Name = "lblInfoDesc";
            lblInfoDesc.Size = new System.Drawing.Size(440, 60);
            lblInfoDesc.TabIndex = 1;
            lblInfoDesc.Text = ("Tüm modüller aktif ve çalışıyor. Sol menüyü kullanarak özellikler arasında geçiş " + "yapabilirsiniz.");
            // 
            // lblInfoTitle
            // 
            lblInfoTitle.AutoSize = true;
            lblInfoTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblInfoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)55)), ((int)((byte)65)), ((int)((byte)81)));
            lblInfoTitle.Location = new System.Drawing.Point(15, 15);
            lblInfoTitle.Name = "lblInfoTitle";
            lblInfoTitle.Size = new System.Drawing.Size(182, 32);
            lblInfoTitle.TabIndex = 0;
            lblInfoTitle.Text = "Sistem Durumu";
            // 
            // ucMainMenu
            // 
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)243)), ((int)((byte)244)), ((int)((byte)246)));
            Controls.Add(pnlInfoCard);
            Controls.Add(pnlSettingsCard);
            Controls.Add(lblWelcome);
            Size = new System.Drawing.Size(567, 400);
            pnlSettingsCard.ResumeLayout(false);
            pnlSettingsCard.PerformLayout();
            pnlInfoCard.ResumeLayout(false);
            pnlInfoCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Arayüz elemanlarının tanımlamaları
        private Label lblWelcome;
        private System.Windows.Forms.Panel pnlSettingsCard;
        private Label lblSettingsTitle;
        private CheckBox chkMinimizeToTray;

        private System.Windows.Forms.Panel pnlInfoCard;
        private Label lblInfoTitle;
        private System.Windows.Forms.Label lblInfoDesc;
    }
}