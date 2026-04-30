namespace SmartApp
{
    partial class ucInputMaster
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
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnToggleInput = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlScrollCard = new System.Windows.Forms.Panel();
            this.lblScrollIcon = new System.Windows.Forms.Label();
            this.lblScrollTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numScrollMult = new System.Windows.Forms.NumericUpDown();
            this.btnSetScrollKey = new System.Windows.Forms.Button();
            this.pnlVolumeCard = new System.Windows.Forms.Panel();
            this.lblVolumeIcon = new System.Windows.Forms.Label();
            this.lblVolumeTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numVolSens = new System.Windows.Forms.NumericUpDown();
            this.btnSetVolumeKey = new System.Windows.Forms.Button();
            
            this.pnlControl.SuspendLayout();
            this.pnlScrollCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScrollMult)).BeginInit();
            this.pnlVolumeCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVolSens)).BeginInit();
            this.SuspendLayout();
            
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblPageTitle.Location = new System.Drawing.Point(20, 20);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(294, 32);
            this.lblPageTitle.TabIndex = 3;
            this.lblPageTitle.Text = "Giriş ve Kısayol Yönetimi";
            
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.btnToggleInput);
            this.pnlControl.Controls.Add(this.lblStatus);
            this.pnlControl.Location = new System.Drawing.Point(25, 80);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(615, 75);
            this.pnlControl.TabIndex = 2;
            
            // 
            // btnToggleInput
            // 
            this.btnToggleInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleInput.FlatAppearance.BorderSize = 0;
            this.btnToggleInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleInput.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.btnToggleInput.ForeColor = System.Drawing.Color.White;
            this.btnToggleInput.Location = new System.Drawing.Point(15, 17);
            this.btnToggleInput.Name = "btnToggleInput";
            this.btnToggleInput.Size = new System.Drawing.Size(200, 40);
            this.btnToggleInput.TabIndex = 0;
            this.btnToggleInput.Text = "Kısayolları Başlat";
            this.btnToggleInput.UseVisualStyleBackColor = false;
            
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblStatus.Location = new System.Drawing.Point(235, 27);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(146, 20);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Durum: Durduruldu";
            
            // 
            // pnlScrollCard
            // 
            this.pnlScrollCard.Controls.Add(this.lblScrollIcon);
            this.pnlScrollCard.Controls.Add(this.lblScrollTitle);
            this.pnlScrollCard.Controls.Add(this.label1);
            this.pnlScrollCard.Controls.Add(this.numScrollMult);
            this.pnlScrollCard.Controls.Add(this.btnSetScrollKey);
            this.pnlScrollCard.Location = new System.Drawing.Point(25, 175);
            this.pnlScrollCard.Name = "pnlScrollCard";
            this.pnlScrollCard.Size = new System.Drawing.Size(300, 200);
            this.pnlScrollCard.TabIndex = 1;
            
            // 
            // lblScrollIcon
            // 
            this.lblScrollIcon.AutoSize = true;
            this.lblScrollIcon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.lblScrollIcon.Location = new System.Drawing.Point(15, 15);
            this.lblScrollIcon.Name = "lblScrollIcon";
            this.lblScrollIcon.Size = new System.Drawing.Size(33, 25);
            this.lblScrollIcon.TabIndex = 0;
            this.lblScrollIcon.Text = "🖱️";
            
            // 
            // lblScrollTitle
            // 
            this.lblScrollTitle.AutoSize = true;
            this.lblScrollTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblScrollTitle.Location = new System.Drawing.Point(55, 18);
            this.lblScrollTitle.Name = "lblScrollTitle";
            this.lblScrollTitle.Size = new System.Drawing.Size(110, 20);
            this.lblScrollTitle.TabIndex = 1;
            this.lblScrollTitle.Text = "Fare Kaydırma";
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.label1.Location = new System.Drawing.Point(15, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hız Çarpanı";
            
            // 
            // numScrollMult
            // 
            this.numScrollMult.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.numScrollMult.Location = new System.Drawing.Point(15, 85);
            this.numScrollMult.Name = "numScrollMult";
            this.numScrollMult.Size = new System.Drawing.Size(265, 27);
            this.numScrollMult.TabIndex = 3;
            this.numScrollMult.Value = new decimal(new int[] { 15, 0, 0, 0 });
            
            // 
            // btnSetScrollKey
            // 
            this.btnSetScrollKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetScrollKey.FlatAppearance.BorderSize = 1;
            this.btnSetScrollKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetScrollKey.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.btnSetScrollKey.Location = new System.Drawing.Point(15, 135);
            this.btnSetScrollKey.Name = "btnSetScrollKey";
            this.btnSetScrollKey.Size = new System.Drawing.Size(265, 45);
            this.btnSetScrollKey.TabIndex = 4;
            this.btnSetScrollKey.Text = "Scroll Kısayolu Ata";
            this.btnSetScrollKey.UseVisualStyleBackColor = false;
            
            // 
            // pnlVolumeCard
            // 
            this.pnlVolumeCard.Controls.Add(this.lblVolumeIcon);
            this.pnlVolumeCard.Controls.Add(this.lblVolumeTitle);
            this.pnlVolumeCard.Controls.Add(this.label2);
            this.pnlVolumeCard.Controls.Add(this.numVolSens);
            this.pnlVolumeCard.Controls.Add(this.btnSetVolumeKey);
            this.pnlVolumeCard.Location = new System.Drawing.Point(340, 175);
            this.pnlVolumeCard.Name = "pnlVolumeCard";
            this.pnlVolumeCard.Size = new System.Drawing.Size(300, 200);
            this.pnlVolumeCard.TabIndex = 0;
            
            // 
            // lblVolumeIcon
            // 
            this.lblVolumeIcon.AutoSize = true;
            this.lblVolumeIcon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.lblVolumeIcon.Location = new System.Drawing.Point(15, 15);
            this.lblVolumeIcon.Name = "lblVolumeIcon";
            this.lblVolumeIcon.Size = new System.Drawing.Size(33, 25);
            this.lblVolumeIcon.TabIndex = 0;
            this.lblVolumeIcon.Text = "🔊";
            
            // 
            // lblVolumeTitle
            // 
            this.lblVolumeTitle.AutoSize = true;
            this.lblVolumeTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblVolumeTitle.Location = new System.Drawing.Point(55, 18);
            this.lblVolumeTitle.Name = "lblVolumeTitle";
            this.lblVolumeTitle.Size = new System.Drawing.Size(71, 20);
            this.lblVolumeTitle.TabIndex = 1;
            this.lblVolumeTitle.Text = "Ses Ayarı";
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Direnç / Hassasiyet";
            
            // 
            // numVolSens
            // 
            this.numVolSens.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.numVolSens.Location = new System.Drawing.Point(15, 85);
            this.numVolSens.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            this.numVolSens.Name = "numVolSens";
            this.numVolSens.Size = new System.Drawing.Size(265, 27);
            this.numVolSens.TabIndex = 3;
            this.numVolSens.Value = new decimal(new int[] { 20, 0, 0, 0 });
            
            // 
            // btnSetVolumeKey
            // 
            this.btnSetVolumeKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetVolumeKey.FlatAppearance.BorderSize = 1;
            this.btnSetVolumeKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetVolumeKey.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.btnSetVolumeKey.Location = new System.Drawing.Point(15, 135);
            this.btnSetVolumeKey.Name = "btnSetVolumeKey";
            this.btnSetVolumeKey.Size = new System.Drawing.Size(265, 45);
            this.btnSetVolumeKey.TabIndex = 4;
            this.btnSetVolumeKey.Text = "Ses Kısayolu Ata";
            this.btnSetVolumeKey.UseVisualStyleBackColor = false;
            
            // 
            // ucInputMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlVolumeCard);
            this.Controls.Add(this.pnlScrollCard);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.lblPageTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.Name = "ucInputMaster";
            this.Size = new System.Drawing.Size(750, 480);
            
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.pnlScrollCard.ResumeLayout(false);
            this.pnlScrollCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScrollMult)).EndInit();
            this.pnlVolumeCard.ResumeLayout(false);
            this.pnlVolumeCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVolSens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnToggleInput;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlScrollCard;
        private System.Windows.Forms.Label lblScrollIcon;
        private System.Windows.Forms.Label lblScrollTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numScrollMult;
        private System.Windows.Forms.Button btnSetScrollKey;
        private System.Windows.Forms.Panel pnlVolumeCard;
        private System.Windows.Forms.Label lblVolumeIcon;
        private System.Windows.Forms.Label lblVolumeTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numVolSens;
        private System.Windows.Forms.Button btnSetVolumeKey;
    }
}