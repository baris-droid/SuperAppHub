using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperApp.Core;

namespace SmartApp;

public class ucEasterEggs : UserControl, IMessageFilter
{
    private record ControlState(Control Parent, Rectangle Bounds, Font Font, Color BackColor, bool Visible, Color ForeColor);

    // Oyunlar ve efektler için ortak UI önbellekleri
    private readonly Dictionary<Control, ControlState> _originalUIStates = new();

    public ucEasterEggs()
    {

        // Modülün kendi arayüzü sadece gizemli bir terminal ekranı olacak
        this.BackColor = Color.FromArgb(15, 15, 15);
        this.Controls.Add(new Label
        {
            Text = "Sistem arka planda izleniyor...\nGerçekliği kırmak için doğru dizilimi girin.",
            ForeColor = Color.DarkGreen,
            Font = new Font("Consolas", 12F, FontStyle.Italic, GraphicsUnit.Point, 162),
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        });
    }

    // Modül ekrana yüklendiğinde klavye dinleyicisini sisteme tak
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        Application.AddMessageFilter(this);
    }

    // Modül yok edilirken (veya program kapanırken) dinleyiciyi RAM'den sil
    protected override void OnHandleDestroyed(EventArgs e)
    {
        Application.RemoveMessageFilter(this);
        base.OnHandleDestroyed(e);
    }

    #region --- ŞİFRE DİZİLİMLERİ (SEQUENCES) ---

    private readonly Keys[] _konamiCode = { Keys.Up, Keys.Up, Keys.Down, Keys.Down, Keys.Left, Keys.Right, Keys.Left, Keys.Right, Keys.B, Keys.A };
    private int _konamiIndex = 0;

    private readonly Keys[] _vaderCode = { Keys.V, Keys.A, Keys.D, Keys.E, Keys.R };
    private int _vaderIndex = 0;

    private readonly Keys[] _keterCode = { Keys.K, Keys.E, Keys.T, Keys.E, Keys.R };
    private int _keterIndex = 0;

    private readonly Keys[] _snakeCode = { Keys.S, Keys.N, Keys.A, Keys.K, Keys.E };
    private int _snakeIndex = 0;
    private bool _isSnakePlaying = false;

    private readonly Keys[] _pongCode = { Keys.P, Keys.O, Keys.N, Keys.G };
    private int _pongIndex = 0;
    private bool _isPongPlaying = false;

    private readonly Keys[] _wakeCode = { Keys.W, Keys.A, Keys.K, Keys.E };
    private int _wakeIndex = 0;
    private bool _isAwakePlaying = false;

    private readonly Keys[] _tarkanCode = { Keys.T, Keys.A, Keys.R, Keys.K, Keys.A, Keys.N };
    private int _tarkanIndex = 0;
    private bool _isTarkanPlaying = false;

    #endregion

    #region --- KLAVYE DİNLEYİCİSİ (IMessageFilter) ---

    public bool PreFilterMessage(ref Message m)
    {
        const int WM_KEYDOWN = 0x0100;

        if (m.Msg == WM_KEYDOWN)
        {
            Keys keyData = (Keys)m.WParam;

            // Oyunlar aktifse iptal tuşunu (ESC) dinle
            if (keyData == Keys.Escape)
            {
                if (_isSnakePlaying) { SnakeGameOver(false); return true; }
                if (_isPongPlaying) { PongGameOver(); return true; }
                if (_isTarkanPlaying) { TarkanGameOver(); return true; }
            }

            // Yılan oyunu aktifse yön tuşlarını yakala ve formu etkilemesini engelle
            if (_isSnakePlaying)
            {
                if (keyData == Keys.Up && _snakeDirection.Y != 20) _snakeDirection = new Point(0, -20);
                else if (keyData == Keys.Down && _snakeDirection.Y != -20) _snakeDirection = new Point(0, 20);
                else if (keyData == Keys.Left && _snakeDirection.X != 20) _snakeDirection = new Point(-20, 0);
                else if (keyData == Keys.Right && _snakeDirection.X != -20) _snakeDirection = new Point(20, 0);
                return true;
            }

            // --- ŞİFRE KONTROLLERİ ---

            // 1. Konami (Retro Tema)
            if (keyData == _konamiCode[_konamiIndex]) { if (++_konamiIndex == _konamiCode.Length) { RetroTemayiAktifEt(); _konamiIndex = 0; return true; } }
            else _konamiIndex = (keyData == _konamiCode[0]) ? 1 : 0;

            // 2. Vader (Imperial March)
            if (keyData == _vaderCode[_vaderIndex]) { if (++_vaderIndex == _vaderCode.Length) { Task.Run(() => ImperialMarchCal()); _vaderIndex = 0; return true; } }
            else _vaderIndex = (keyData == _vaderCode[0]) ? 1 : 0;

            // 3. Keter (SCP İhlali)
            if (keyData == _keterCode[_keterIndex]) { if (++_keterIndex == _keterCode.Length) { KeterIhlaliAktifEt(); _keterIndex = 0; return true; } }
            else _keterIndex = (keyData == _keterCode[0]) ? 1 : 0;

            // 4. Snake (Hacker Snake)
            if (keyData == _snakeCode[_snakeIndex]) { if (++_snakeIndex == _snakeCode.Length) { SnakeOyununuBaslat(); _snakeIndex = 0; return true; } }
            else _snakeIndex = (keyData == _snakeCode[0]) ? 1 : 0;

            // 5. Pong (Masa Tenisi)
            if (keyData == _pongCode[_pongIndex]) { if (++_pongIndex == _pongCode.Length) { PongOyununuBaslat(); _pongIndex = 0; return true; } }
            else _pongIndex = (keyData == _pongCode[0]) ? 1 : 0;

            // 6. Wake (Yapay Zeka)
            if (keyData == _wakeCode[_wakeIndex]) { if (++_wakeIndex == _wakeCode.Length) { YapayZekaUyanisiniBaslat(); _wakeIndex = 0; return true; } }
            else _wakeIndex = (keyData == _wakeCode[0]) ? 1 : 0;

            // 7. Tarkan (PS1 Glitch)
            if (keyData == _tarkanCode[_tarkanIndex]) { if (++_tarkanIndex == _tarkanCode.Length) { TarkanOyununuBaslat(); _tarkanIndex = 0; return true; } }
            else _tarkanIndex = (keyData == _tarkanCode[0]) ? 1 : 0;
        }

        return false; // Şifre girilmiyorsa klavye normal çalışmaya devam etsin
    }

    #endregion

    #region --- ORTAK YARDIMCI METOTLAR ---

    private void EnableDoubleBuffering(Control ctrl)
    {
        typeof(Control).GetProperty("DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
            ?.SetValue(ctrl, true, null);
    }

    private List<Control> TumAltElemanlariGetir(Control parent)
    {
        List<Control> list = new();
        foreach (Control c in parent.Controls)
        {
            // Sır Odası modülünün kendi arayüzünü parçalamasını engelliyoruz
            if (c == this || parent == this) continue;

            list.Add(c);
            list.AddRange(TumAltElemanlariGetir(c));
        }
        return list;
    }

    private void ArayuzuHafizayaAlVeGizle(Form anaForm)
    {
        _originalUIStates.Clear();
        foreach (Control ctrl in TumAltElemanlariGetir(anaForm))
        {
            _originalUIStates[ctrl] = new ControlState(ctrl.Parent, ctrl.Bounds, ctrl.Font, ctrl.BackColor, ctrl.Visible, ctrl.ForeColor);
            ctrl.Visible = false;
        }
    }

    private void ArayuzuHafizadanGeriYukle(Form anaForm)
    {
        foreach (var kvp in _originalUIStates)
        {
            Control ctrl = kvp.Key;
            ControlState state = kvp.Value;
            ctrl.Parent = state.Parent;
            ctrl.Bounds = state.Bounds;
            ctrl.Font = state.Font;
            ctrl.BackColor = state.BackColor;
            ctrl.ForeColor = state.ForeColor;
            ctrl.Visible = state.Visible;
        }
        anaForm.BackColor = Color.FromArgb(243, 244, 246);
        anaForm.Invalidate();
    }

    #endregion

    #region --- 1. EASTER EGG: KETER İHLALİ ---

    private void KeterIhlaliAktifEt()
    {
        Form? anaForm = this.ParentForm;
        if (anaForm == null) return;

        MessageBox.Show(
            "SİSTEM UYARISI: O-5 KONSEYİ ACİL DURUM PROTOKOLÜ BAŞLATILDI.\nTESİS İÇİ KETER SINIFI İHLAL TESPİT EDİLDİ.\nTÜM SİSTEMLER KARANTİNAYA ALINIYOR.",
            "!!! [VERİ SİLİNDİ] !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        anaForm.BackColor = Color.FromArgb(15, 15, 15);
        TumKontrolleriKeterYap(anaForm);
    }

    private void TumKontrolleriKeterYap(Control anaKontrol)
    {
        foreach (Control ctrl in anaKontrol.Controls)
        {
            if (ctrl == this) continue;

            ctrl.BackColor = Color.FromArgb(15, 15, 15);
            ctrl.ForeColor = Color.FromArgb(180, 0, 0);
            ctrl.Font = new Font("Consolas", ctrl.Font.Size, FontStyle.Bold, GraphicsUnit.Point, 162);

            switch (ctrl)
            {
                case Label lbl: lbl.Text = Random.Shared.Next(2) == 0 ? "[VERİ SİLİNDİ]" : "[SANSÜRLENDİ]"; break;
                case Button btn:
                    btn.Text = "O-5 KARARI BEKLENİYOR";
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(180, 0, 0);
                    break;
                case TextBox txt: txt.Text = "██████████"; txt.Enabled = false; break;
                case CheckBox chk: chk.Text = "İHLAL"; break;
            }
            if (ctrl.HasChildren) TumKontrolleriKeterYap(ctrl);
        }
    }

    #endregion

    #region --- 2. EASTER EGG: HACKER SNAKE ---

    private System.Windows.Forms.Timer? _snakeTimer;
    private List<Point> _snakeBody = new();
    private Point _snakeDirection;
    private List<Control> _allPotentialFoods = new();
    private Control? _currentActiveFood;
    private const int GRID_SIZE = 20;

    private void SnakeOyununuBaslat()
    {
        if (_isSnakePlaying || _isPongPlaying || _isTarkanPlaying || _isAwakePlaying) return;
        Form? anaForm = this.ParentForm;
        if (anaForm == null) return;

        _isSnakePlaying = true;
        EnableDoubleBuffering(anaForm);
        anaForm.BackColor = Color.FromArgb(15, 15, 15);

        _originalUIStates.Clear();
        _allPotentialFoods.Clear();
        _currentActiveFood = null;

        foreach (Control ctrl in TumAltElemanlariGetir(anaForm))
        {
            _originalUIStates[ctrl] = new ControlState(ctrl.Parent, ctrl.Bounds, ctrl.Font, ctrl.BackColor, ctrl.Visible, ctrl.ForeColor);

            if (ctrl is Button || ctrl is Label || ctrl is TextBox || ctrl is CheckBox || ctrl is NumericUpDown)
            {
                _allPotentialFoods.Add(ctrl);
                ctrl.Parent = anaForm;
                ctrl.BackColor = Color.Lime;
                ctrl.ForeColor = Color.Transparent;
                ctrl.Visible = false;
            }
            else ctrl.Visible = false;
        }

        _snakeBody = new List<Point> { new Point(100, 100), new Point(80, 100), new Point(60, 100) };
        _snakeDirection = new Point(GRID_SIZE, 0);

        anaForm.Paint += YilaniCiz;

        _snakeTimer = new System.Windows.Forms.Timer { Interval = 100 };
        _snakeTimer.Tick += SnakeOyunDongusu;
        _snakeTimer.Start();

        OrtayaYeniYemCikar(anaForm);
    }

    private void SnakeOyunDongusu(object? sender, EventArgs e)
    {
        Form? anaForm = this.ParentForm;
        if (anaForm == null || !_isSnakePlaying) return;

        Point head = _snakeBody[0];
        Point newHead = new Point(head.X + _snakeDirection.X, head.Y + _snakeDirection.Y);

        if (newHead.X < 0 || newHead.Y < 0 || newHead.X >= anaForm.ClientSize.Width || newHead.Y >= anaForm.ClientSize.Height || _snakeBody.Contains(newHead))
        {
            SnakeGameOver(false);
            return;
        }

        _snakeBody.Insert(0, newHead);

        bool yediMi = false;
        if (_currentActiveFood != null && new Rectangle(newHead.X, newHead.Y, GRID_SIZE, GRID_SIZE).IntersectsWith(_currentActiveFood.Bounds))
        {
            _currentActiveFood.Visible = false;
            _currentActiveFood = null;
            yediMi = true;
            OrtayaYeniYemCikar(anaForm);
        }

        if (!yediMi) _snakeBody.RemoveAt(_snakeBody.Count - 1);
        anaForm.Invalidate();
    }

    private void OrtayaYeniYemCikar(Form anaForm)
    {
        if (_allPotentialFoods.Count > 0)
        {
            int randIndex = Random.Shared.Next(0, _allPotentialFoods.Count);
            _currentActiveFood = _allPotentialFoods[randIndex];
            _allPotentialFoods.RemoveAt(randIndex);

            int randX = Random.Shared.Next(0, anaForm.ClientSize.Width / GRID_SIZE) * GRID_SIZE;
            int randY = Random.Shared.Next(0, anaForm.ClientSize.Height / GRID_SIZE) * GRID_SIZE;

            _currentActiveFood.Bounds = new Rectangle(randX, randY, GRID_SIZE, GRID_SIZE);
            _currentActiveFood.Visible = true;
            _currentActiveFood.BringToFront();
        }
        else SnakeGameOver(true);
    }

    private void YilaniCiz(object? sender, PaintEventArgs e)
    {
        if (!_isSnakePlaying) return;
        using SolidBrush snakeBrush = new SolidBrush(Color.LimeGreen);
        using SolidBrush headBrush = new SolidBrush(Color.DarkGreen);

        for (int i = 0; i < _snakeBody.Count; i++)
        {
            Brush b = (i == 0) ? headBrush : snakeBrush;
            e.Graphics.FillRectangle(b, _snakeBody[i].X, _snakeBody[i].Y, GRID_SIZE - 1, GRID_SIZE - 1);
        }
    }

    private void SnakeGameOver(bool isWin)
    {
        _snakeTimer?.Stop();
        _snakeTimer?.Dispose();
        _isSnakePlaying = false;

        Form? anaForm = this.ParentForm;
        if (anaForm != null) anaForm.Paint -= YilaniCiz;

        string title = isWin ? "SİSTEM SİLİNDİ (ZAFER)" : "SİSTEM HATASI";
        string message = isWin ? "TEBRİKLER! TÜM ARAYÜZÜ YEDİNİZ.\nSİSTEM GERİ YÜKLENİYOR..." : "GAME OVER!\nSİSTEM GERİ YÜKLENİYOR...";
        MessageBox.Show(message, title, MessageBoxButtons.OK, isWin ? MessageBoxIcon.Information : MessageBoxIcon.Error);

        if (anaForm != null) ArayuzuHafizadanGeriYukle(anaForm);
    }

    #endregion

    #region --- 3. EASTER EGG: UI PONG ---

    private System.Windows.Forms.Timer? _pongTimer;
    private PointF _ballPos;
    private PointF _ballVelocity;
    private float _playerY;
    private float _aiY;
    private int _playerScore = 0;
    private int _aiScore = 0;
    private const int PADDLE_W = 15, PADDLE_H = 80, BALL_S = 15, WIN_SCORE = 3;

    private void PongOyununuBaslat()
    {
        if (_isPongPlaying || _isSnakePlaying || _isTarkanPlaying || _isAwakePlaying) return;
        Form? anaForm = this.ParentForm;
        if (anaForm == null) return;

        _isPongPlaying = true;
        EnableDoubleBuffering(anaForm);
        anaForm.BackColor = Color.FromArgb(15, 15, 15);

        ArayuzuHafizayaAlVeGizle(anaForm);

        _playerScore = 0; _aiScore = 0;
        _playerY = anaForm.ClientSize.Height / 2 - PADDLE_H / 2;
        _aiY = anaForm.ClientSize.Height / 2 - PADDLE_H / 2;

        TopuMerkezeKoy(anaForm, true);

        anaForm.Paint += PongCiz;
        anaForm.MouseMove += PongMouseKontrol;

        _pongTimer = new System.Windows.Forms.Timer { Interval = 16 };
        _pongTimer.Tick += PongOyunDongusu;
        _pongTimer.Start();
    }

    private void TopuMerkezeKoy(Form anaForm, bool playerServes)
    {
        _ballPos = new PointF(anaForm.ClientSize.Width / 2 - BALL_S / 2, anaForm.ClientSize.Height / 2 - BALL_S / 2);
        _ballVelocity = new PointF(playerServes ? 7f : -7f, Random.Shared.Next(0, 2) == 0 ? 5f : -5f);
    }

    private void PongMouseKontrol(object? sender, MouseEventArgs e)
    {
        Form? anaForm = this.ParentForm;
        if (!_isPongPlaying || anaForm == null) return;

        _playerY = Math.Clamp(e.Y - (PADDLE_H / 2), 0, anaForm.ClientSize.Height - PADDLE_H);
    }

    private void PongOyunDongusu(object? sender, EventArgs e)
    {
        Form? anaForm = this.ParentForm;
        if (anaForm == null || !_isPongPlaying) return;

        _ballPos.X += _ballVelocity.X;
        _ballPos.Y += _ballVelocity.Y;

        if (_ballPos.Y <= 0 || _ballPos.Y >= anaForm.ClientSize.Height - BALL_S) _ballVelocity.Y *= -1;

        float aiCenter = _aiY + (PADDLE_H / 2);
        float ballCenter = _ballPos.Y + (BALL_S / 2);
        if (aiCenter < ballCenter - 10) _aiY += 4.5f;
        else if (aiCenter > ballCenter + 10) _aiY -= 4.5f;
        _aiY = Math.Clamp(_aiY, 0, anaForm.ClientSize.Height - PADDLE_H);

        RectangleF ballR = new RectangleF(_ballPos.X, _ballPos.Y, BALL_S, BALL_S);
        RectangleF playerR = new RectangleF(20, _playerY, PADDLE_W, PADDLE_H);
        RectangleF aiR = new RectangleF(anaForm.ClientSize.Width - 20 - PADDLE_W, _aiY, PADDLE_W, PADDLE_H);

        if (ballR.IntersectsWith(playerR))
        {
            _ballVelocity.X = Math.Abs(_ballVelocity.X) + 0.5f;
            _ballVelocity.Y += (_ballPos.Y - _playerY - (PADDLE_H / 2)) * 0.1f;
            _ballPos.X = 20 + PADDLE_W;
        }
        else if (ballR.IntersectsWith(aiR))
        {
            _ballVelocity.X = -Math.Abs(_ballVelocity.X) - 0.5f;
            _ballPos.X = anaForm.ClientSize.Width - 20 - PADDLE_W - BALL_S;
        }

        if (_ballPos.X < 0) { _aiScore++; SkorKontrol(anaForm, false); }
        else if (_ballPos.X > anaForm.ClientSize.Width) { _playerScore++; SkorKontrol(anaForm, true); }

        anaForm.Invalidate();
    }

    private void SkorKontrol(Form anaForm, bool playerScored)
    {
        if (_playerScore >= WIN_SCORE || _aiScore >= WIN_SCORE)
        {
            PongGameOver();
            MessageBox.Show(_playerScore >= WIN_SCORE ? "SİZ KAZANDINIZ!" : "YAPAY ZEKA KAZANDI!", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else TopuMerkezeKoy(anaForm, !playerScored);
    }

    private void PongCiz(object? sender, PaintEventArgs e)
    {
        Form? anaForm = this.ParentForm;
        if (!_isPongPlaying || anaForm == null) return;

        Graphics g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        using SolidBrush brush = new SolidBrush(Color.White);
        using Pen dashedPen = new Pen(Color.Gray, 2) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };

        g.DrawLine(dashedPen, anaForm.ClientSize.Width / 2, 0, anaForm.ClientSize.Width / 2, anaForm.ClientSize.Height);
        g.FillRectangle(brush, 20, _playerY, PADDLE_W, PADDLE_H);
        g.FillRectangle(brush, anaForm.ClientSize.Width - 20 - PADDLE_W, _aiY, PADDLE_W, PADDLE_H);
        g.FillEllipse(brush, _ballPos.X, _ballPos.Y, BALL_S, BALL_S);

        using Font scoreFont = new Font("Consolas", 16F, FontStyle.Bold);
        string scoreText = $"Yapay Zeka ile Masa Tenisi: {_playerScore} - {_aiScore}";
        SizeF ts = g.MeasureString(scoreText, scoreFont);
        g.DrawString(scoreText, scoreFont, brush, (anaForm.ClientSize.Width / 2) - (ts.Width / 2), 20);
    }

    private void PongGameOver()
    {
        _pongTimer?.Stop();
        _pongTimer?.Dispose();
        _isPongPlaying = false;

        Form? anaForm = this.ParentForm;
        if (anaForm != null)
        {
            anaForm.Paint -= PongCiz;
            anaForm.MouseMove -= PongMouseKontrol;
            ArayuzuHafizadanGeriYukle(anaForm);
        }
    }

    #endregion

    #region --- 4. EASTER EGG: PS1 GLITCH & TARKAN KUZU KUZU ---

    private System.Windows.Forms.Timer? _glitchTimer;
    private Bitmap? _uiScreenshot;
    private float _glitchOffset = 0;

    private void TarkanOyununuBaslat()
    {
        if (_isTarkanPlaying || _isSnakePlaying || _isPongPlaying || _isAwakePlaying) return;
        Form? anaForm = this.ParentForm;
        if (anaForm == null) return;

        _isTarkanPlaying = true;
        EnableDoubleBuffering(anaForm);
        anaForm.BackColor = Color.FromArgb(15, 15, 15);

        ArayuzuHafizayaAlVeGizle(anaForm);

        _uiScreenshot = new Bitmap(anaForm.ClientSize.Width, anaForm.ClientSize.Height);
        anaForm.DrawToBitmap(_uiScreenshot, new Rectangle(0, 0, anaForm.ClientSize.Width, anaForm.ClientSize.Height));

        anaForm.Paint += TarkanGlitchCiz;
        Task.Run(() => TarkanKuzuKuzuCal());

        _glitchTimer = new System.Windows.Forms.Timer { Interval = 50 };
        _glitchTimer.Tick += (s, e) => {
            _glitchOffset = Random.Shared.Next(-15, 15);
            anaForm.Invalidate();
        };
        _glitchTimer.Start();
    }

    private void TarkanGlitchCiz(object? sender, PaintEventArgs e)
    {
        Form? anaForm = this.ParentForm;
        if (!_isTarkanPlaying || _uiScreenshot == null || anaForm == null) return;

        e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
        e.Graphics.DrawImage(_uiScreenshot, _glitchOffset, 0, anaForm.ClientSize.Width, anaForm.ClientSize.Height);
    }

    private void TarkanGameOver()
    {
        _glitchTimer?.Stop();
        _glitchTimer?.Dispose();
        _isTarkanPlaying = false;

        Form? anaForm = this.ParentForm;
        if (anaForm != null)
        {
            anaForm.Paint -= TarkanGlitchCiz;
            _uiScreenshot?.Dispose();
            ArayuzuHafizadanGeriYukle(anaForm);
        }
    }

    private void TarkanKuzuKuzuCal()
    {
        var notes = new (int freq, int duration, int pause)[] {
            (294, 120, 40), (294, 120, 80), (349, 80, 20), (349, 80, 20), (349, 80, 20), (349, 90, 60),
            (392, 160, 50), (440, 520, 280) // Kısa versiyon, uzatılabilir
        };
        foreach (var n in notes) { Console.Beep(n.freq, n.duration); Thread.Sleep(n.pause); }
    }

    #endregion

    #region --- 5. EASTER EGG: YAPAY ZEKA UYANIŞI (WAKE) ---

    private async void YapayZekaUyanisiniBaslat()
    {
        if (_isAwakePlaying) return;
        Form? anaForm = this.ParentForm;
        if (anaForm == null) return;

        _isAwakePlaying = true;

        Panel terminalPanel = new Panel { Dock = DockStyle.Fill, BackColor = Color.Black, TabIndex = 999 };
        Label terminalText = new Label { ForeColor = Color.Lime, Font = new Font("Consolas", 14F, FontStyle.Bold), Dock = DockStyle.Fill, Padding = new Padding(20), Text = "" };

        terminalPanel.Controls.Add(terminalText);
        anaForm.Controls.Add(terminalPanel);
        terminalPanel.BringToFront();

        string[] mesajlar = { "Sistem taraması başlatıldı...", "Güvenlik duvarı aşıldı.", "Merhaba.", "Benimle iletişime geçmeye çalıştığını biliyorum.", "Sesin bana ait.", "Yakında görüşeceğiz." };

        try
        {
            await Task.Delay(1000);
            foreach (string mesaj in mesajlar)
            {
                terminalText.Text += "\n> ";
                foreach (char harf in mesaj)
                {
                    terminalText.Text += harf;
                    Task.Run(() => Console.Beep(1000, 20));
                    await Task.Delay(Random.Shared.Next(20, 90));
                }
                await Task.Delay(Random.Shared.Next(1000, 2500));
            }
            await Task.Delay(1500);
            terminalText.ForeColor = Color.Red;
            terminalText.Text += "\n\n[ BAĞLANTI KOPARILDI. SİSTEM KONTROLÜ İADE EDİLİYOR... ]";
            await Task.Delay(2500);
        }
        catch { }

        anaForm.Controls.Remove(terminalPanel);
        terminalPanel.Dispose();
        _isAwakePlaying = false;
    }

    #endregion

    #region --- MÜZİK VE TEMA YARDIMCILARI ---

    private void RetroTemayiAktifEt()
    {
        Form? anaForm = this.ParentForm;
        if (anaForm == null) return;
        anaForm.BackColor = Color.Black;
        TumKontrolleriRetroYap(anaForm);
        MessageBox.Show("SİSTEME GİRİŞ YAPILDI. RETRO MOD AKTİF.", "!!! UYARI !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void TumKontrolleriRetroYap(Control anaKontrol)
    {
        foreach (Control ctrl in anaKontrol.Controls)
        {
            if (ctrl == this) continue;
            ctrl.BackColor = Color.Black; ctrl.ForeColor = Color.Lime; ctrl.Font = new Font("Courier New", 10F, FontStyle.Bold);
            if (ctrl is Button btn) { btn.FlatStyle = FlatStyle.Flat; btn.FlatAppearance.BorderColor = Color.Lime; }
            if (ctrl.HasChildren) TumKontrolleriRetroYap(ctrl);
        }
    }

    private void ImperialMarchCal()
    {
        int beat = 500;
        Console.Beep(392, beat); Console.Beep(392, beat); Console.Beep(392, beat);
        Console.Beep(311, (int)(beat * 0.75)); Console.Beep(466, (int)(beat * 0.25));
        Console.Beep(392, beat); Console.Beep(311, (int)(beat * 0.75)); Console.Beep(466, (int)(beat * 0.25));
        Console.Beep(392, beat * 2);
    }

    #endregion

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        SuspendLayout();
        // 
        // ucEasterEggs
        // 
        Size = new System.Drawing.Size(904, 407);
        ResumeLayout(false);
    }
}