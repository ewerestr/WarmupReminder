using System;
using System.IO;
using System.Windows.Forms;
using WarmupReminder.Properties;

namespace WarmupReminder
{
    public partial class WarmupForm : Form
    {
        private bool _theme = true; // 1 - l, 0 - d
        private bool _sourceTheme = true;
        private bool _themeChanged = false;

        public WarmupForm(bool theme)
        {
            InitializeComponent();
            this.Icon = Resources.favicon;
            if (!theme)
            {
                _theme = theme;
                _sourceTheme = theme;
                UpdateTheme();
            }
            Opacity = 100;
        }

        private void UpdateTheme(bool byUser = false)
        {
            if (!_theme)
            {
                //if (byUser) _theme = !_theme;
                BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
                theme_picture.Image = Resources.icon_tow;
                header_label.ForeColor = System.Drawing.Color.White;
                submit_button.BackColor = System.Drawing.Color.FromArgb(43, 37, 40);
                submit_button.ForeColor = System.Drawing.Color.White;
                later_button.BackColor = System.Drawing.Color.FromArgb(43, 37, 40);
                later_button.ForeColor = System.Drawing.Color.White;
                return;
            }
            //if (byUser) _theme = !_theme;
            BackColor = System.Drawing.Color.FromArgb(254, 254, 254);
            theme_picture.Image = Resources.icon_tob;
            header_label.ForeColor = System.Drawing.Color.Black;
            submit_button.BackColor = System.Drawing.Color.White;
            submit_button.ForeColor = System.Drawing.Color.Black;
            later_button.BackColor = System.Drawing.Color.White;
            later_button.ForeColor = System.Drawing.Color.Black;
        }

        private void CloseApp()
        {
            if (_themeChanged && (_sourceTheme != _theme)) WarmupCore.SaveConf(_theme);
            this.Dispose();
        }

        private void sumbit_button_Click(object sender, EventArgs e)
        {
            string videopath;
            if (WarmupCore.GetVideo() == 0)
            {
                MessageBox.Show("К сожалению, зарядка отменяется\n"
                    + "При запуске напоминания не были\n"
                    + "указаны аргументы\n"
                    + "Сообщите системному администратору");
                CloseApp();
                return; // I think this is unnecessary but i'll leave it here for now 
            }
            if (WarmupCore.GetVideo() == 1) videopath = "U:\\usr\\video1.mp4";
            else videopath = "U:\\usr\\video2.mp4";
            if (!File.Exists(videopath))
            {
                MessageBox.Show("Похоже, у вас сегодня освобождение\n"
                    + "По какой-то причине видео с упражнениями\n"
                    + "не скопировалось к вам на компьютер\n"
                    + "Сообщите системному администратору");
                CloseApp();
                return;
            }
            FormBorderStyle = FormBorderStyle.None;
            theme_picture.Visible = false;
            Bounds = Screen.PrimaryScreen.Bounds;
            wmp.URL = videopath;
            wmp.enableContextMenu = false;
            wmp.uiMode = "None";
            wmp.Bounds = Bounds;
            wmp.stretchToFit = true;
            wmp.Visible = true;           
            wmp.Ctlcontrols.play();
        }

        private void wmp_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                wmp.close();
                Controls.Remove(wmp);
                CloseApp();
            }
        }

        private void theme_picture_Click(object sender, EventArgs e)
        {
            _themeChanged = true;
            _theme = !_theme;
            UpdateTheme(true);
        }

        private void Component_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void theme_picture_Click(object sender, MouseEventArgs e)
        {
            _themeChanged = true;
            _theme = !_theme;
            UpdateTheme(true);
        }

        private void later_button_Click(object sender, EventArgs e)
        {
            WarmupCore.StartTimer();
            WarmupCore.HideForm(); ;
        }

        public bool GetTheme()
        {
            return _theme;
        }
    }
}
