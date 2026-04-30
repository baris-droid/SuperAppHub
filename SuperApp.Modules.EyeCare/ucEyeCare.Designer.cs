namespace SmartApp
{
    partial class ucEyeCare
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
            lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)31)), ((int)((byte)41)), ((int)((byte)55)));
            lblPageTitle.Location = new System.Drawing.Point(20, 20);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new System.Drawing.Size(400, 48);
            lblPageTitle.TabIndex = 4;
            lblPageTitle.Text = "Göz Sağlığı (20-20-20)";
            // 
            // pnlTimingCard
            // 
            pnlTimingCard.BackColor = System.Drawing.Color.White;
            pnlTimingCard.Controls.Add(lblTimingTitle);
            pnlTimingCard.Controls.Add(label1);
            pnlTimingCard.Controls.Add(numWorkMin);
            pnlTimingCard.Controls.Add(label2);
            pnlTimingCard.Controls.Add(numRestSec);
            pnlTimingCard.Location = new System.Drawing.Point(26, 76);
            pnlTimingCard.Name = "pnlTimingCard";
            pnlTimingCard.Size = new System.Drawing.Size(229, 197);
            pnlTimingCard.TabIndex = 3;
            // 
            // lblTimingTitle
            // 
            lblTimingTitle.AutoSize = true;
            lblTimingTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            lblTimingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)55)), ((int)((byte)65)), ((int)((byte)81)));
            lblTimingTitle.Location = new System.Drawing.Point(15, 15);
            lblTimingTitle.Name = "lblTimingTitle";
            lblTimingTitle.Size = new System.Drawing.Size(127, 30);
            lblTimingTitle.TabIndex = 0;
            lblTimingTitle.Text = "Zamanlama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)114)), ((int)((byte)128)));
            label1.Location = new System.Drawing.Point(15, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(193, 25);
            label1.TabIndex = 1;
            label1.Text = "Çalışma Süresi (Dakika)";
            // 
            // numWorkMin
            // 
            numWorkMin.Font = new System.Drawing.Font("Segoe UI", 10F);
            numWorkMin.Location = new System.Drawing.Point(15, 75);
            numWorkMin.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numWorkMin.Name = "numWorkMin";
            numWorkMin.Size = new System.Drawing.Size(185, 34);
            numWorkMin.TabIndex = 2;
            numWorkMin.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)114)), ((int)((byte)128)));
            label2.Location = new System.Drawing.Point(15, 105);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(205, 25);
            label2.TabIndex = 3;
            label2.Text = "Dinlenme Süresi (Saniye)";
            // 
            // numRestSec
            // 
            numRestSec.Font = new System.Drawing.Font("Segoe UI", 10F);
            numRestSec.Location = new System.Drawing.Point(15, 130);
            numRestSec.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numRestSec.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numRestSec.Name = "numRestSec";
            numRestSec.Size = new System.Drawing.Size(185, 34);
            numRestSec.TabIndex = 4;
            numRestSec.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // pnlVisualCard
            // 
            pnlVisualCard.BackColor = System.Drawing.Color.White;
            pnlVisualCard.Controls.Add(lblVisualTitle);
            pnlVisualCard.Controls.Add(label3);
            pnlVisualCard.Controls.Add(cmbLocation);
            pnlVisualCard.Controls.Add(label4);
            pnlVisualCard.Controls.Add(trkOpacity);
            pnlVisualCard.Location = new System.Drawing.Point(288, 76);
            pnlVisualCard.Name = "pnlVisualCard";
            pnlVisualCard.Size = new System.Drawing.Size(251, 197);
            pnlVisualCard.TabIndex = 2;
            // 
            // lblVisualTitle
            // 
            lblVisualTitle.AutoSize = true;
            lblVisualTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            lblVisualTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)55)), ((int)((byte)65)), ((int)((byte)81)));
            lblVisualTitle.Location = new System.Drawing.Point(15, 15);
            lblVisualTitle.Name = "lblVisualTitle";
            lblVisualTitle.Size = new System.Drawing.Size(203, 30);
            lblVisualTitle.TabIndex = 0;
            lblVisualTitle.Text = "Bildirim Görünümü";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            label3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)114)), ((int)((byte)128)));
            label3.Location = new System.Drawing.Point(15, 50);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(143, 25);
            label3.TabIndex = 1;
            label3.Text = "Bildirim Konumu";
            // 
            // cmbLocation
            // 
            cmbLocation.BackColor = System.Drawing.Color.FromArgb(((int)((byte)249)), ((int)((byte)250)), ((int)((byte)251)));
            cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbLocation.Items.AddRange(new object[] { "Ekranın Ortası", "Sağ Alt Köşe" });
            cmbLocation.Location = new System.Drawing.Point(15, 74);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new System.Drawing.Size(185, 36);
            cmbLocation.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)114)), ((int)((byte)128)));
            label4.Location = new System.Drawing.Point(15, 105);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(175, 25);
            label4.TabIndex = 3;
            label4.Text = "Arka Plan Matlığı (%)";
            // 
            // trkOpacity
            // 
            trkOpacity.Location = new System.Drawing.Point(10, 124);
            trkOpacity.Maximum = 100;
            trkOpacity.Minimum = 10;
            trkOpacity.Name = "trkOpacity";
            trkOpacity.Size = new System.Drawing.Size(190, 69);
            trkOpacity.TabIndex = 4;
            trkOpacity.TickFrequency = 10;
            trkOpacity.Value = 85;
            // 
            // btnToggleEyeCare
            // 
            btnToggleEyeCare.BackColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
            btnToggleEyeCare.Cursor = System.Windows.Forms.Cursors.Hand;
            btnToggleEyeCare.FlatAppearance.BorderSize = 0;
            btnToggleEyeCare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnToggleEyeCare.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            btnToggleEyeCare.ForeColor = System.Drawing.Color.White;
            btnToggleEyeCare.Location = new System.Drawing.Point(25, 316);
            btnToggleEyeCare.Name = "btnToggleEyeCare";
            btnToggleEyeCare.Size = new System.Drawing.Size(180, 40);
            btnToggleEyeCare.TabIndex = 1;
            btnToggleEyeCare.Text = "Takibi Başlat";
            btnToggleEyeCare.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)114)), ((int)((byte)128)));
            lblStatus.Location = new System.Drawing.Point(215, 321);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(205, 30);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Durum: Bekleniyor";
            // 
            // ucEyeCare
            // 
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)243)), ((int)((byte)244)), ((int)((byte)246)));
            Controls.Add(lblStatus);
            Controls.Add(btnToggleEyeCare);
            Controls.Add(pnlVisualCard);
            Controls.Add(pnlTimingCard);
            Controls.Add(lblPageTitle);
            Size = new System.Drawing.Size(904, 407);
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

        private Label lblPageTitle;
        private System.Windows.Forms.Panel pnlTimingCard;
        private Label lblTimingTitle;
        private System.Windows.Forms.Panel pnlVisualCard;
        private Label lblVisualTitle;
        private System.Windows.Forms.NumericUpDown numWorkMin;
        private Label label1;
        private System.Windows.Forms.NumericUpDown numRestSec;
        private Label label2;
        private System.Windows.Forms.ComboBox cmbLocation;
        private Label label3;
        private System.Windows.Forms.Button btnToggleEyeCare;
        private System.Windows.Forms.Label lblStatus;
        private TrackBar trkOpacity;
        private Label label4;
    }
}
