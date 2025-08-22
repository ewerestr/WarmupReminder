using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace WarmupReminder
{
    static class WarmupCore
    {
        private static int _video;
        private static bool _theme;
        private static string _dpath;
        private static string _fpath;

        private static WarmupForm _warmupForm;

        private static TimerCallback _timerCallback;
        private static System.Threading.Timer _timer;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            InitVars();
            ParseArgs(args);
            CheckConf();
            RunForm();
        }

        private static void ParseArgs(string[] args)
        {
            if (args.Length <= 0) return;
            if (!IsInt(args[0])) return;
            _video = int.Parse(args[0]);
        }

        private static void InitVars()
        {
            _video = 0;
            _theme = true;
            _dpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Path.DirectorySeparatorChar + "WarmupReminder";
            _fpath = _dpath + Path.DirectorySeparatorChar + "config.cfg";
        }

        private static void CheckConf()
        {
            if (!Directory.Exists(_dpath)) 
            {
                Directory.CreateDirectory(_dpath);
                return;
            }
            if (File.Exists(_fpath)) _theme = false;
        }

        public static void SaveConf(bool theme)
        {
            if (File.Exists(_fpath))
            {
                if (theme) File.Delete(_fpath);
                return;
            }
            if (!theme) File.Create(_fpath);
        }

        private static void RunForm()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _warmupForm = new WarmupForm(_theme);
            Application.Run(_warmupForm);
        }

        private static bool IsInt(string s)
        {
            try
            {
                int.Parse(s);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static void StartTimer()
        {
            _timerCallback = new TimerCallback(TimerOver);
            TimeSpan ts = CalculateTimeDifference();
            _timer = new System.Threading.Timer(_timerCallback, 0, (long)ts.TotalMilliseconds, 1000);
        }

        public static void TimerOver(Object obj)
        {
            StopTimer();
            _warmupForm.Invoke(new Action(() => _warmupForm.Show()));
        }

        public static void StopTimer()
        {
            if (_timer != null) _timer.Dispose();
            if (_timerCallback != null) _timerCallback = null;
        }

        private static TimeSpan CalculateTimeDifference()
        {
            DateTime bc = DateTime.Now.AddMinutes(10);
            TimeSpan diff = bc.Subtract(DateTime.Now);
            return diff;
        }

        public static void HideForm()
        {
            _warmupForm.Hide();
        }

        public static int GetVideo()
        {
            return _video;
        }
    }
}
