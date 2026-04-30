namespace SmartApp
{
    partial class ucEyeCare
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
            this.pnlTimingCard = new System.Windows.Forms.Panel();
            this.lblTimingTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numWorkMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numRestSec = new System.Windows.Forms.NumericUpDown();
            this.pnlVisualCard = new System.Windows.Forms.Panel();
            this.lblVisualTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trkOpacity = new System.Windows.Forms.TrackBar();
            this.btnToggleEyeCare = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            
            this.pnlTimingCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWorkMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRestSec)).BeginInit();
            this.pnlVisualCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkOpacity)).BeginInit();
            this.SuspendLayout();
            
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblPageTitle.Location = new System.Drawing.Point(20, 20);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(262, 32);
            this.lblPageTitle.TabIndex = 4;
            this.lblPageTitle.Text = "Göz Sağlığı (20-20-20)";
            
            // 
            // pnlTimingCard
            // 
            this.pnlTimingCard.Controls.Add(this.lblTimingTitle);
            this.pnlTimingCard.Controls.Add(this.label1);
            this.pnlTimingCard.Controls.Add(this.numWorkMin);
            this.pnlTimingCard.Controls.Add(this.label2);
            this.pnlTimingCard.Controls.Add(this.numRestSec);
            this.pnlTimingCard.Location = new System.Drawing.Point(25, 80);
            this.pnlTimingCard.Name = "pnlTimingCard";
            this.pnlTimingCard.Size = new System.Drawing.Size(300, 220);
            this.pnlTimingCard.TabIndex = 3;
            
            // 
            // lblTimingTitle
            // 
            this.lblTimingTitle.AutoSize = true;
            this.lblTimingTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblTimingTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTimingTitle.Name = "lblTimingTitle";
            this.lblTimingTitle.Size = new System.Drawing.Size(87, 20);
            this.lblTimingTitle.TabIndex = 0;
            this.lblTimingTitle.Text = "Zamanlama";
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.label1.Location = new System.Drawing.Point(20, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Çalışma Süresi (Dakika)";
            
            // 
            // numWorkMin
            // 
            this.numWorkMin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.numWorkMin.Location = new System.Drawing.Point(20, 80);
            this.numWorkMin.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            this.numWorkMin.Name = "numWorkMin";
            this.numWorkMin.Size = new System.Drawing.Size(260, 27);
            this.numWorkMin.TabIndex = 2;
            this.numWorkMin.Value = new decimal(new int[] { 20, 0, 0, 0 });
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.label2.Location = new System.Drawing.Point(20, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dinlenme Süresi (Saniye)";
            
            // 
            // numRestSec
            // 
            this.numRestSec.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.numRestSec.Location = new System.Drawing.Point(20, 155);
            this.numRestSec.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            this.numRestSec.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            this.numRestSec.Name = "numRestSec";
            this.numRestSec.Size = new System.Drawing.Size(260, 27);
            this.numRestSec.TabIndex = 4;
            this.numRestSec.Value = new decimal(new int[] { 20, 0, 0, 0 });
            
            // 
            // pnlVisualCard
            // 
            this.pnlVisualCard.Controls.Add(this.lblVisualTitle);
            this.pnlVisualCard.Controls.Add(this.label3);
            this.pnlVisualCard.Controls.Add(this.cmbLocation);
            this.pnlVisualCard.Controls.Add(this.label4);
            this.pnlVisualCard.Controls.Add(this.trkOpacity);
            this.pnlVisualCard.Location = new System.Drawing.Point(340, 80);
            this.pnlVisualCard.Name = "pnlVisualCard";
            this.pnlVisualCard.Size = new System.Drawing.Size(300, 220);
            this.pnlVisualCard.TabIndex = 2;
            
            // 
            // lblVisualTitle
            // 
            this.lblVisualTitle.AutoSize = true;
            this.lblVisualTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblVisualTitle.Location = new System.Drawing.Point(20, 15);
            this.lblVisualTitle.Name = "lblVisualTitle";
            this.lblVisualTitle.Size = new System.Drawing.Size(137, 20);
            this.lblVisualTitle.TabIndex = 0;
            this.lblVisualTitle.Text = "Bildirim Görünümü";
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.label3.Location = new System.Drawing.Point(20, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bildirim Konumu";
            
            // 
            // cmbLocation
            // 
            this.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLocation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.cmbLocation.Items.AddRange(new object[] { "Ekranın Ortası", "Sağ Alt Köşe" });
            this.cmbLocation.Location = new System.Drawing.Point(20, 80);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(260, 28);
            this.cmbLocation.TabIndex = 2;
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.label4.Location = new System.Drawing.Point(20, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Arka Plan Matlığı (%)";
            
            // 
            // trkOpacity
            // 
            this.trkOpacity.Location = new System.Drawing.Point(10, 155);
            this.trkOpacity.Maximum = 100;
            this.trkOpacity.Minimum = 10;
            this.trkOpacity.Name = "trkOpacity";
            this.trkOpacity.Size = new System.Drawing.Size(280, 45);
            this.trkOpacity.TabIndex = 4;
            this.trkOpacity.TickStyle = System.Windows.Forms.TickStyle.None; // Tirtıkları gizleyip daha modern bir görünüm verdik
            this.trkOpacity.Value = 85;
            
            // 
            // btnToggleEyeCare
            // 
            this.btnToggleEyeCare.BackColor = System.Drawing.Color.FromArgb(99, 102, 241); // Accent Mavi
            this.btnToggleEyeCare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleEyeCare.FlatAppearance.BorderSize = 0;
            this.btnToggleEyeCare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleEyeCare.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.btnToggleEyeCare.ForeColor = System.Drawing.Color.White;
            this.btnToggleEyeCare.Location = new System.Drawing.Point(25, 320);
            this.btnToggleEyeCare.Name = "btnToggleEyeCare";
            this.btnToggleEyeCare.Size = new System.Drawing.Size(180, 40);
            this.btnToggleEyeCare.TabIndex = 1;
            this.btnToggleEyeCare.Text = "Takibi Başlat";
            this.btnToggleEyeCare.UseVisualStyleBackColor = false;
            
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            this.lblStatus.Location = new System.Drawing.Point(220, 330);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(136, 20);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Durum: Bekleniyor";
            
            // 
            // ucEyeCare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnToggleEyeCare);
            this.Controls.Add(this.pnlVisualCard);
            this.Controls.Add(this.pnlTimingCard);
            this.Controls.Add(this.lblPageTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            this.Name = "ucEyeCare";
            this.Size = new System.Drawing.Size(750, 480);
            
            this.pnlTimingCard.ResumeLayout(false);
            this.pnlTimingCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWorkMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRestSec)).EndInit();
            this.pnlVisualCard.ResumeLayout(false);
            this.pnlVisualCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel pnlTimingCard;
        private System.Windows.Forms.Label lblTimingTitle;
        private System.Windows.Forms.Panel pnlVisualCard;
        private System.Windows.Forms.Label lblVisualTitle;
        private System.Windows.Forms.NumericUpDown numWorkMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numRestSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnToggleEyeCare;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TrackBar trkOpacity;
        private System.Windows.Forms.Label label4;
    }
}