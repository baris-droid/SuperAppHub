using System.Drawing;
using System.Windows.Forms;

namespace SmartApp;

partial class Form1
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Panel pnlSidebar;
    private System.Windows.Forms.Label lblVersion;
    private Panel pnlNavIndicator;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnOpenMainMenu;
    private System.Windows.Forms.Panel pnlContent;

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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        pnlSidebar = new System.Windows.Forms.Panel();
        lblVersion = new System.Windows.Forms.Label();
        pnlNavIndicator = new System.Windows.Forms.Panel();
        lblTitle = new System.Windows.Forms.Label();
        btnOpenMainMenu = new System.Windows.Forms.Button();
        pnlContent = new System.Windows.Forms.Panel();
        pnlSidebar.SuspendLayout();
        SuspendLayout();
        // 
        // pnlSidebar
        // 
        pnlSidebar.Controls.Add(lblVersion);
        pnlSidebar.Controls.Add(pnlNavIndicator);
        pnlSidebar.Controls.Add(lblTitle);
        pnlSidebar.Controls.Add(btnOpenMainMenu);
        pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
        pnlSidebar.Location = new System.Drawing.Point(0, 0);
        pnlSidebar.Name = "pnlSidebar";
        pnlSidebar.Size = new System.Drawing.Size(254, 791);
        pnlSidebar.TabIndex = 0;
        // 
        // lblVersion
        // 
        lblVersion.AccessibleDescription = "";
        lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        lblVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
        lblVersion.Location = new System.Drawing.Point(12, 759);
        lblVersion.Name = "lblVersion";
        lblVersion.Size = new System.Drawing.Size(115, 23);
        lblVersion.TabIndex = 7;
        lblVersion.Text = " v1.7.0 Beta.1";
        lblVersion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // pnlNavIndicator
        // 
        pnlNavIndicator.Location = new System.Drawing.Point(0, 70);
        pnlNavIndicator.Name = "pnlNavIndicator";
        pnlNavIndicator.Size = new System.Drawing.Size(4, 40);
        pnlNavIndicator.TabIndex = 6;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
        lblTitle.Location = new System.Drawing.Point(15, 15);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(170, 45);
        lblTitle.TabIndex = 5;
        lblTitle.Text = "SuperApp";
        // 
        // btnOpenMainMenu
        // 
        btnOpenMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
        btnOpenMainMenu.FlatAppearance.BorderSize = 0;
        btnOpenMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnOpenMainMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
        btnOpenMainMenu.Location = new System.Drawing.Point(10, 70);
        btnOpenMainMenu.Name = "btnOpenMainMenu";
        btnOpenMainMenu.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
        btnOpenMainMenu.Size = new System.Drawing.Size(238, 40);
        btnOpenMainMenu.TabIndex = 2;
        btnOpenMainMenu.Text = "Kontrol Paneli";
        btnOpenMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        btnOpenMainMenu.UseVisualStyleBackColor = true;
        btnOpenMainMenu.Click += btnOpenMainMenu_Click;
        // 
        // pnlContent
        // 
        pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlContent.Location = new System.Drawing.Point(254, 0);
        pnlContent.Name = "pnlContent";
        pnlContent.Padding = new System.Windows.Forms.Padding(20);
        pnlContent.Size = new System.Drawing.Size(1135, 791);
        pnlContent.TabIndex = 1;
        // 
        // Form1
        // 
        ClientSize = new System.Drawing.Size(1389, 791);
        Controls.Add(pnlContent);
        Controls.Add(pnlSidebar);
        Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
        MinimumSize = new System.Drawing.Size(800, 450);
        ShowIcon = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "SuperApp Hub";
        pnlSidebar.ResumeLayout(false);
        pnlSidebar.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
}