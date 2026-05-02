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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPageTitle = new System.Windows.Forms.Label();
            pnlTimingCard = new System.Windows.Forms.Panel();
            lblTimingTitle = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            numWorkMin = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            numRestSec = new System.Windows.Forms.NumericUpDown();
            pnlVisualCard = new System.Windows.Forms.Panel();
            lblVisualTitle = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            cmbLocation = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            trkOpacity = new System.Windows.Forms.TrackBar();
            btnToggleEyeCare = new System.Windows.Forms.Button();
            lblStatus = new System.Windows.Forms.Label();
            pnlTimingCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numWorkMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRestSec).BeginInit();
            pnlVisualCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trkOpacity).BeginInit();
            SuspendLayout();
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblPageTitle.Location = new System.Drawing.Point(31, 33);
            lblPageTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new System.Drawing.Size(400, 48);
            lblPageTitle.TabIndex = 4;
            lblPageTitle.Text = "Göz Sağlığı (20-20-20)";
            // 
            // pnlTimingCard
            // 
            pnlTimingCard.Controls.Add(lblTimingTitle);
            pnlTimingCard.Controls.Add(label1);
            pnlTimingCard.Controls.Add(numWorkMin);
            pnlTimingCard.Controls.Add(label2);
            pnlTimingCard.Controls.Add(numRestSec);
            pnlTimingCard.Location = new System.Drawing.Point(39, 132);
            pnlTimingCard.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            pnlTimingCard.Name = "pnlTimingCard";
            pnlTimingCard.Size = new System.Drawing.Size(471, 362);
            pnlTimingCard.TabIndex = 3;
            // 
            // lblTimingTitle
            // 
            lblTimingTitle.AutoSize = true;
            lblTimingTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblTimingTitle.Location = new System.Drawing.Point(31, 25);
            lblTimingTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTimingTitle.Name = "lblTimingTitle";
            lblTimingTitle.Size = new System.Drawing.Size(135, 31);
            lblTimingTitle.TabIndex = 0;
            lblTimingTitle.Text = "Zamanlama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            label1.Location = new System.Drawing.Point(31, 91);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(212, 28);
            label1.TabIndex = 1;
            label1.Text = "Çalışma Süresi (Dakika)";
            // 
            // numWorkMin
            // 
            numWorkMin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            numWorkMin.Location = new System.Drawing.Point(31, 132);
            numWorkMin.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            numWorkMin.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numWorkMin.Name = "numWorkMin";
            numWorkMin.Size = new System.Drawing.Size(409, 37);
            numWorkMin.TabIndex = 2;
            numWorkMin.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            label2.Location = new System.Drawing.Point(31, 214);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(226, 28);
            label2.TabIndex = 3;
            label2.Text = "Dinlenme Süresi (Saniye)";
            // 
            // numRestSec
            // 
            numRestSec.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            numRestSec.Location = new System.Drawing.Point(31, 255);
            numRestSec.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            numRestSec.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numRestSec.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numRestSec.Name = "numRestSec";
            numRestSec.Size = new System.Drawing.Size(409, 37);
            numRestSec.TabIndex = 4;
            numRestSec.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // pnlVisualCard
            // 
            pnlVisualCard.Controls.Add(lblVisualTitle);
            pnlVisualCard.Controls.Add(label3);
            pnlVisualCard.Controls.Add(cmbLocation);
            pnlVisualCard.Controls.Add(label4);
            pnlVisualCard.Controls.Add(trkOpacity);
            pnlVisualCard.Location = new System.Drawing.Point(534, 132);
            pnlVisualCard.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            pnlVisualCard.Name = "pnlVisualCard";
            pnlVisualCard.Size = new System.Drawing.Size(471, 362);
            pnlVisualCard.TabIndex = 2;
            // 
            // lblVisualTitle
            // 
            lblVisualTitle.AutoSize = true;
            lblVisualTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblVisualTitle.Location = new System.Drawing.Point(31, 25);
            lblVisualTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblVisualTitle.Name = "lblVisualTitle";
            lblVisualTitle.Size = new System.Drawing.Size(212, 31);
            lblVisualTitle.TabIndex = 0;
            lblVisualTitle.Text = "Bildirim Görünümü";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            label3.Location = new System.Drawing.Point(31, 91);
            label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(158, 28);
            label3.TabIndex = 1;
            label3.Text = "Bildirim Konumu";
            // 
            // cmbLocation
            // 
            cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbLocation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            cmbLocation.Items.AddRange(new object[] { "Ekranın Ortası", "Sağ Alt Köşe" });
            cmbLocation.Location = new System.Drawing.Point(31, 132);
            cmbLocation.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new System.Drawing.Size(406, 39);
            cmbLocation.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            label4.Location = new System.Drawing.Point(31, 214);
            label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(194, 28);
            label4.TabIndex = 3;
            label4.Text = "Arka Plan Matlığı (%)";
            // 
            // trkOpacity
            // 
            trkOpacity.Location = new System.Drawing.Point(16, 255);
            trkOpacity.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            trkOpacity.Maximum = 100;
            trkOpacity.Minimum = 10;
            trkOpacity.Name = "trkOpacity";
            trkOpacity.Size = new System.Drawing.Size(440, 69);
            trkOpacity.TabIndex = 4;
            trkOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            trkOpacity.Value = 85;
            // 
            // btnToggleEyeCare
            // 
            btnToggleEyeCare.BackColor = System.Drawing.Color.FromArgb(((int)((byte)99)), ((int)((byte)102)), ((int)((byte)241)));
            btnToggleEyeCare.Cursor = System.Windows.Forms.Cursors.Hand;
            btnToggleEyeCare.FlatAppearance.BorderSize = 0;
            btnToggleEyeCare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnToggleEyeCare.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            btnToggleEyeCare.ForeColor = System.Drawing.Color.White;
            btnToggleEyeCare.Location = new System.Drawing.Point(39, 527);
            btnToggleEyeCare.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            btnToggleEyeCare.Name = "btnToggleEyeCare";
            btnToggleEyeCare.Size = new System.Drawing.Size(283, 66);
            btnToggleEyeCare.TabIndex = 1;
            btnToggleEyeCare.Text = "Takibi Başlat";
            btnToggleEyeCare.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblStatus.Location = new System.Drawing.Point(346, 544);
            lblStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(208, 31);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Durum: Bekleniyor";
            // 
            // ucEyeCare
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(lblStatus);
            Controls.Add(btnToggleEyeCare);
            Controls.Add(pnlVisualCard);
            Controls.Add(pnlTimingCard);
            Controls.Add(lblPageTitle);
            Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            Size = new System.Drawing.Size(1179, 791);
            pnlTimingCard.ResumeLayout(false);
            pnlTimingCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numWorkMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRestSec).EndInit();
            pnlVisualCard.ResumeLayout(false);
            pnlVisualCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trkOpacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
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