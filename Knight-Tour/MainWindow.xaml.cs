using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Knight_Tour
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Display display;
        private DispatcherTimer timer;
        private int step_count;
        
        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += OnStepEvent;

            display = new Display(GameArea);

            dgSteps.ItemsSource = display.Steps.DefaultView;

            slSpeed.Minimum = 5;
            slSpeed.Maximum = 500;
        }

        int[] test = new int[64];
        private void Test_TimerEvent()
        {
            Random random = new Random();
            int j;
            int pos;

            if (step_count == 1)
            {
                for (int i = 0; i < test.Length; i++)
                    test[i] = 0;

                test[display.startPos] = 1;
                lMessage.Content = "Progressing...";
            }
            else if (step_count == 63) lMessage.Content = "Success!";

            j = 0;
            while (j == 0)
            {
                pos = random.Next() % 64;
                if (test[pos] == 1) continue;

                test[pos] = 1;
                display.Step(pos);
                j = 1;
            }
        }


        private void OnStepEvent(object sender, EventArgs e)
        {
            Test_TimerEvent();

            if (++step_count >= 64) timer.Stop();
        }

        private void BtnGo_Click(object sender, RoutedEventArgs e)
        {
            display.Reset(display.startPos);
            step_count = 1;
            timer.Interval = TimeSpan.FromMilliseconds(slSpeed.Value);
            timer.Start();
        }
    }
}
