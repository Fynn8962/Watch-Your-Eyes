using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Eye_Care_App
{
    public partial class NotificationWindow : Window
    {
        private DispatcherTimer timer;

        public NotificationWindow(string message, int durationSeconds = 3)
        {
            InitializeComponent();

            NotificationText.Text = message;


            var workingArea = SystemParameters.WorkArea;
            Left = workingArea.Right - Width - 20;
            Top = workingArea.Bottom - Height - 50;

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(durationSeconds);
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                Close();
            };
            timer.Start();
        }
    }
}
