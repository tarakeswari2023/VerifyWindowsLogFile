using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WatchFileForm : Form
    {
        private string SeletedFilePath = string.Empty;
        private DateTime lastReadTime = DateTime.MinValue;
        private Timer WatchTimer;
        private Timer countdownTimer;
        private int intervalInSeconds;
        public WatchFileForm()
        {
            InitializeComponent();

            /// Initializing Timer
            WatchTimer = new Timer();
            WatchTimer.Interval = 15000; //default timer interval for 15 seconds
            WatchTimer.Tick += WatchTimer_Tick;

            // Initialize Countdown Timer
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // 1 second
            countdownTimer.Tick += CountdownTimer_Tick;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt";
                openFileDialog.Title = "Select a text file Only";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SeletedFilePath = openFileDialog.FileName;
                    lblSelectedFilePath.Text = SeletedFilePath;
                    lastReadTime = DateTime.MinValue;
                    richtxtFileUpdates.Clear();
                    WatchTimer.Start();
                    intervalInSeconds = WatchTimer.Interval / 1000;
                    countdownTimer.Start();
                }
            }
        }
        private void WatchTimer_Tick(object sender, EventArgs e)
        {
            //Timer t = (Timer)sender;
            
            if (File.Exists(SeletedFilePath))
            {
                string[] lines = File.ReadAllLines(SeletedFilePath);
                DateTime lastWriteTime = File.GetLastWriteTime(SeletedFilePath);

                if (lastWriteTime > lastReadTime)
                {
                    string formattedTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    richtxtFileUpdates.AppendText($"______Changes detected at {formattedTime}:________\n");

                    foreach (string line in lines)
                    {
                        richtxtFileUpdates.AppendText(line + "\n");
                    }

                    lastReadTime = lastWriteTime;
                }
            }
            intervalInSeconds = WatchTimer.Interval / 1000;           
        }
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            intervalInSeconds--;
            lblTimerDisplay.Text = $"Next File check in : {intervalInSeconds} seconds";

            if (intervalInSeconds <= 0)
            {
                intervalInSeconds = WatchTimer.Interval / 1000;
            }
        }
        private void txtSetTimerInterval_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtSetTimerInterval.Text, out int interval))
            { 
                /// Converting seconds to milliseconds and updating the Timer Interval
                WatchTimer.Interval = interval * 1000;
            }
            else
            {
                MessageBox.Show("Please enter a valid number for the interval.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
