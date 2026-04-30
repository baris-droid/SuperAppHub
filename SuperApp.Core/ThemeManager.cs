using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SuperApp.Core.UI;

public static class ThemeManager
{
    // Renkleri artık sadece ThemeManager değiştirebilecek (private set)
    public static Color SidebarBackground { get; private set; }
    public static Color ContentBackground { get; private set; }
    public static Color TextPrimary { get; private set; }
    public static Color TextSecondary { get; private set; }
    public static Color AccentColor { get; private set; }
    public static Color ButtonHover { get; private set; }
    public static Color ButtonDown { get; private set; }

    // Tema değiştiğinde diğer formların haberdar olması için küresel bir olay (Event)
    public static event EventHandler? ThemeChanged;

    // Uygulama açıldığında veya tema değiştirildiğinde çağrılır
    public static void SetTheme(bool isDark)
    {
        if (isDark)
        {
            // Karanlık Tema Renkleri (Modern Tailwind Dark Paleti)
            SidebarBackground = Color.FromArgb(31, 41, 55);       // Gray-800
            ContentBackground = Color.FromArgb(17, 24, 39);       // Gray-900
            TextPrimary = Color.FromArgb(243, 244, 246);          // Gray-100
            TextSecondary = Color.FromArgb(156, 163, 175);        // Gray-400
            AccentColor = Color.FromArgb(99, 102, 241);           // Indigo-500 (Vurgu rengi aynı kalır)
            ButtonHover = Color.FromArgb(55, 65, 81);             // Gray-700
            ButtonDown = Color.FromArgb(75, 85, 99);              // Gray-600
        }
        else
        {
            // Açık Tema Renkleri (Orijinal)
            SidebarBackground = Color.FromArgb(255, 255, 255);
            ContentBackground = Color.FromArgb(249, 250, 251);
            TextPrimary = Color.FromArgb(31, 41, 55);
            TextSecondary = Color.FromArgb(107, 114, 128);
            AccentColor = Color.FromArgb(99, 102, 241);
            ButtonHover = Color.FromArgb(243, 244, 246);
            ButtonDown = Color.FromArgb(229, 231, 235);
        }

        // Renkler değiştikten sonra, dinleyen tüm ekranlara "kendinizi güncelleyin" mesajı yolla
        ThemeChanged?.Invoke(null, EventArgs.Empty);
    }
    
    // --- YENİ: MODERN CHECKBOX ÇİZİM MOTORU ---
    
    // Bir form veya UserControl içindeki tüm CheckBox'ları bulur ve 
    // onlara modern, bembeyaz tikli özel (custom) bir tasarım uygular.
    public static void FormatControls(Control.ControlCollection controls)
    {
        foreach (Control ctrl in controls)
        {
            if (ctrl is CheckBox chk)
            {
                // Standart çizimi ezmek için kendi fırçamızı bağlıyoruz
                chk.Paint -= ModernCheckBox_Paint;
                chk.Paint += ModernCheckBox_Paint;
            }

            // İç içe paneller (Kart tasarımları) varsa onların içine de gir (Recursive)
            if (ctrl.HasChildren)
            {
                FormatControls(ctrl.Controls);
            }
        }
    }
    private static void ModernCheckBox_Paint(object? sender, PaintEventArgs e)
    {
        if (sender is not CheckBox chk) return;

        // 1. WinForms'un varsayılan siyah tikli çirkin çizimini arka plan rengiyle temizle
        e.Graphics.Clear(chk.Parent?.BackColor ?? chk.BackColor);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // 2. Kutucuk Boyutu ve Konumu
        int boxSize = 14;
        int yPos = (chk.Height - boxSize) / 2;
        Rectangle boxRect = new Rectangle(0, yPos, boxSize, boxSize);

        // 3. Kutuyu Boyama (İşaretliyse Vurgu Rengi, değilse Arka Plan Rengi)
        using (SolidBrush bgBrush = new SolidBrush(chk.Checked ? AccentColor : ContentBackground))
        using (Pen borderPen = new Pen(chk.Checked ? AccentColor : ButtonDown, 1.5f))
        {
            e.Graphics.FillRectangle(bgBrush, boxRect);
            e.Graphics.DrawRectangle(borderPen, boxRect);
        }

        // 4. Bembeyaz Modern Tik İşareti Çizimi
        if (chk.Checked)
        {
            using (Pen tickPen = new Pen(Color.White, 2f)) // Beyaz renk, 2 piksel kalınlık
            {
                // V şeklini koordinatlarla çiziyoruz
                e.Graphics.DrawLine(tickPen, boxRect.X + 3, boxRect.Y + 7, boxRect.X + 6, boxRect.Y + 10);
                e.Graphics.DrawLine(tickPen, boxRect.X + 6, boxRect.Y + 10, boxRect.X + 11, boxRect.Y + 4);
            }
        }

        // 5. Metni (Yazıyı) Çizme
        Rectangle textRect = new Rectangle(18, 0, chk.Width - 18, chk.Height);
        TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;
        TextRenderer.DrawText(e.Graphics, chk.Text, chk.Font, textRect, chk.ForeColor, flags);
    }
}