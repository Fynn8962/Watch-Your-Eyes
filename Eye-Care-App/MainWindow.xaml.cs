using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Eye_Care_App
{
    public partial class MainWindow : Window
    {
        private TimeSpan remainingTime;
        private DispatcherTimer countdownTimer;
        private bool isStarted;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if (isStarted == true)
            {
                StopCountdown(CountdownText);
            }
            else
            {
                StartCountdown(CountdownText);

            }


        }

        private void StartCountdown(TextBlock target)
        {

            if (SetCountdown.SelectedItem == null)
            {
                return;
            }
            StartButton.Content = "Stop";
            isStarted = true;



            int minutes = int.Parse(((ComboBoxItem)SetCountdown.SelectedItem).Tag.ToString());


            remainingTime = TimeSpan.FromMinutes(minutes);

            target.Text = remainingTime.ToString(@"mm\:ss");

            countdownTimer = new DispatcherTimer();
            countdownTimer.Interval = TimeSpan.FromSeconds(1);
            countdownTimer.Tick += (s, e) =>
            {
                if (remainingTime.TotalSeconds > 0)
                {
                    remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1));
                    target.Text = remainingTime.ToString(@"mm\:ss");
                }
                else
                {
                    countdownTimer.Stop();
                    target.Text = "00:00";
                    var notification = new NotificationWindow("Time for an eye break! \r\nLook far away for at least 20 sec\r\nThe timer will restart", 20);
                    notification.Show();
                    StartButton.Content = "Start";
                    StartCountdown(CountdownText);
                }
            };

            countdownTimer.Start();
        }

        private void StopCountdown(TextBlock target)
        {
            isStarted = false;
            countdownTimer.Stop();
            target.Text = "00:00";
            StartButton.Content = "Start";
        }

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            InfoWindow infoWindow = new InfoWindow();
            infoWindow.Show();
        }

    }

}
