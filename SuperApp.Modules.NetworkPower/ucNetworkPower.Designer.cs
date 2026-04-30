namespace SmartApp
{
    partial class ucNetworkPower
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
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numThreshold = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numWaitTime = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbActionType = new System.Windows.Forms.ComboBox();
            this.btnToggleMonitor = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlAlert = new System.Windows.Forms.Panel();
            this.lblAlertIcon = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            
            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaitTime)).BeginInit();
            this.pnlAlert.SuspendLayout();
            this.SuspendLayout();
            
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblPageTitle.Location = new System.Drawing.Point(20, 20);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(239, 32);
            this.lblPageTitle.TabIndex = 2;
            this.lblPageTitle.Text = "Ağ ve Güç Yönetimi";
            
            // 
            // pnlCard
            // 
            this.pnlCard.Controls.Add(this.lblCardTitle);
            this.pnlCard.Controls.Add(this.label1);
            this.pnlCard.Controls.Add(this.numThreshold);
            this.pnlCard.Controls.Add(this.label2);
            this.pnlCard.Controls.Add(this.numWaitTime);
            this.pnlCard.Controls.Add(this.label3);
            this.pnlCard.Controls.Add(this.cmbActionType);
            this.pnlCard.Controls.Add(this.btnToggleMonitor);
            this.pnlCard.Controls.Add(this.lblStatus);
            this.pnlCard.Location = new System.Drawing.Point(25, 80);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(600, 240);
            this.pnlCard.TabIndex = 1;
            
            // 
            // lblCardTitle
            // 
            this.lblCardTitle.AutoSize = true;
            this.lblCardTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblCardTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.Size = new System.Drawing.Size(155, 21);
            this.lblCardTitle.TabIndex = 0;
            this.lblCardTitle.Text = "Otomasyon Kuralları";
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minimum Hız Sınırı (KB/s)";
            
            // 
            // numThreshold
            // 
            this.numThreshold.DecimalPlaces = 2;
            this.numThreshold.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.numThreshold.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            this.numThreshold.Location = new System.Drawing.Point(15, 80);
            this.numThreshold.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numThreshold.Name = "numThreshold";
            this.numThreshold.Size = new System.Drawing.Size(260, 27);
            this.numThreshold.TabIndex = 2;
            this.numThreshold.Value = new decimal(new int[] { 100, 0, 0, 0 });
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.label2.Location = new System.Drawing.Point(320, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bekleme Süresi (Saniye)";
            
            // 
            // numWaitTime
            // 
            this.numWaitTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.numWaitTime.Location = new System.Drawing.Point(320, 80);
            this.numWaitTime.Maximum = new decimal(new int[] { 86400, 0, 0, 0 });
            this.numWaitTime.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            this.numWaitTime.Name = "numWaitTime";
            this.numWaitTime.Size = new System.Drawing.Size(260, 27);
            this.numWaitTime.TabIndex = 4;
            this.numWaitTime.Value = new decimal(new int[] { 180, 0, 0, 0 });
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gerçekleşecek İşlem";
            
            // 
            // cmbActionType
            // 
            this.cmbActionType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbActionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActionType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbActionType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.cmbActionType.Items.AddRange(new object[] { "Uyku Modu (Sleep)", "Bilgisayarı Kapat (Shutdown)" });
            this.cmbActionType.Location = new System.Drawing.Point(15, 145);
            this.cmbActionType.Name = "cmbActionType";
            this.cmbActionType.Size = new System.Drawing.Size(565, 28);
            this.cmbActionType.TabIndex = 6;
            
            // 
            // btnToggleMonitor
            // 
            this.btnToggleMonitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleMonitor.FlatAppearance.BorderSize = 0;
            this.btnToggleMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleMonitor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.btnToggleMonitor.ForeColor = System.Drawing.Color.White;
            this.btnToggleMonitor.Location = new System.Drawing.Point(15, 185);
            this.btnToggleMonitor.Name = "btnToggleMonitor";
            this.btnToggleMonitor.Size = new System.Drawing.Size(150, 38);
            this.btnToggleMonitor.TabIndex = 7;
            this.btnToggleMonitor.Text = "İzlemeyi Başlat";
            this.btnToggleMonitor.UseVisualStyleBackColor = false;
            
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblStatus.Location = new System.Drawing.Point(175, 195);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(136, 20);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Durum: Bekleniyor";
            
            // 
            // pnlAlert
            // 
            this.pnlAlert.Controls.Add(this.lblAlertIcon);
            this.pnlAlert.Controls.Add(this.label4);
            this.pnlAlert.Location = new System.Drawing.Point(25, 335);
            this.pnlAlert.Name = "pnlAlert";
            this.pnlAlert.Size = new System.Drawing.Size(600, 70);
            this.pnlAlert.TabIndex = 0;
            
            // 
            // lblAlertIcon
            // 
            this.lblAlertIcon.AutoSize = true;
            this.lblAlertIcon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblAlertIcon.Location = new System.Drawing.Point(15, 20);
            this.lblAlertIcon.Name = "lblAlertIcon";
            this.lblAlertIcon.Size = new System.Drawing.Size(32, 25);
            this.lblAlertIcon.TabIndex = 0;
            this.lblAlertIcon.Text = "⚠";
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.label4.Location = new System.Drawing.Point(55, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(515, 34);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gerçekleşecek işlem olarak \"Bilgisayarı Kapat\" seçeneğinin çalışması için \r\nuygulamayı Yönetici Olarak çalıştırmanız gerekir.";
            
            // 
            // ucNetworkPower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAlert);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.lblPageTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.Name = "ucNetworkPower";
            this.Size = new System.Drawing.Size(750, 480);
            
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaitTime)).EndInit();
            this.pnlAlert.ResumeLayout(false);
            this.pnlAlert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblCardTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numThreshold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numWaitTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbActionType;
        private System.Windows.Forms.Button btnToggleMonitor;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlAlert;
        private System.Windows.Forms.Label lblAlertIcon;
        private System.Windows.Forms.Label label4;
    }
}