using System;
using System.Net;
using System.Web;
using System.Data;
using System.Linq;
using System.Text;
using System.Timers;
using System.Drawing;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using Newtonsoft.Json;

namespace minerGUI
{
    public partial class Statistics : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hwnd, WindowShowStyle nCmdShow);

        [DllImport("user32.dll")]
        private static extern bool EnableWindow(IntPtr hwnd, bool enabled);

        internal enum WindowShowStyle : uint
        {
            Hide = 0,
            ShowNormal = 1,
            ShowMinimized = 2,
            ShowMaximized = 3,
            Maximize = 3,
            ShowNormalNoActivate = 4,
            Show = 5,
            Minimize = 6,
            ShowMinNoActivate = 7,
            ShowNoActivate = 8,
            Restore = 9,
            ShowDefault = 10,
            ForceMinimized = 11
        }

        public static System.Timers.Timer updateTimer, autoUpdateTimer;
        public static bool updateEnabled;
        public static decimal c;
        string url = "https://mining.bitcoin.cz/accounts/profile/json/" + Main.myToken;
        string url2 = "https://mining.bitcoin.cz/stats/json/" + Main.myToken;
        myStats personalStats = new myStats();
        poolStats groupStats = new poolStats();

        public Statistics()
        {
            InitializeComponent();
        }

        public void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            updateEnabled = true;
        }

        public void OnTimedEventAuto(object source, ElapsedEventArgs e)
        {
            updateWindow();
            updateEnabled = false;
            updateTimer.Interval = 60000;
            updateTimer.Enabled = true;
        }

        public T _download_serialized_json_data<T>(string url) where T : new()
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString(url);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }

        public void updateWindow()
        {
            try
            {
                deserUrl1();
                deserUrl2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                Statistics.areWeRunning();
            }
        }
        public void deserUrl1()
        {
            try
            {
                personalStats = _download_serialized_json_data<myStats>(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                setColOne();
            }
        }
        public void deserUrl2()
        {
            try
            {
                groupStats = _download_serialized_json_data<poolStats>(url2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                setColTwo();
            }
        }
        public void setColOne()
        {

            decimal a = Convert.ToDecimal(personalStats.unconfirmed_reward);
            decimal b = Convert.ToDecimal(personalStats.confirmed_reward);
            decimal c = a + b;

            txtWorker.Text = personalStats.username;
            txtUnconfirmed.Text = personalStats.unconfirmed_reward + " BTC";
            txtConfirmed.Text = personalStats.confirmed_reward + " BTC";
            txtTotal.Text = c.ToString() + " BTC";
        }
        public void setColTwo()
        {
            txtRoundDuration.Text = groupStats.round_duration;
            txtPercentComplete.Text = groupStats.shares_cdf + "%";
            txtEstimatedReward.Text = personalStats.estimated_reward + " BTC";
            txtMyHashrate.Text = personalStats.hashrate;
            txtLuck_1.Text = groupStats.luck_1;
            txtLuck_7.Text = groupStats.luck_7;
            txtLuck_30.Text = groupStats.luck_30;
        }

        public class myStats
        {
            public string username { get; set; }
            public string rating { get; set; }
            public string confirmed_nmc_reward { get; set; }
            public string send_threshold { get; set; }
            public string nmc_send_threshold { get; set; }
            public string confirmed_reward { get; set; }
            public Dictionary<string, WorkerList> workers { get; set; }
            public string wallet { get; set; }
            public string unconfirmed_nmc_reward { get; set; }
            public string unconfirmed_reward { get; set; }
            public string estimated_reward { get; set; }
            public string hashrate { get; set; }
        }

        public class WorkerList 
        {
            public List<_worker> myWorkers { get; set; }
        }

        public class _worker
        {
            public int last_share { get; set; }
            public string score { get; set; }
            public int hashrate { get; set; }
            public int shares { get; set; }
            public bool alive { get; set; }
        }

        public class poolStats
        {
            public Dictionary<string, Blocks> blocks { get; set; }
            public string round_duration { get; set; }
            public string ghashes_ps { get; set; }
            public long shares { get; set; }
            public int active_workers { get; set; }
            public int active_stratum { get; set; }
            public float score { get; set; }
            public string round_started { get; set; }
            public string luck_7 { get; set; }
            public string luck_30 { get; set; }
            public string luck_1 { get; set; }
            public float shares_cdf { get; set; }
        }

        public class Blocks
        {
            public List<_block> myBlocks { get; set; }
        }

        public class _block
        {
            public int is_mature { get; set; }
            public float total_score { get; set; }
            public string mining_duration { get; set; }
            public string date_found { get; set; }
            public int confirmations { get; set; }
            public long total_shares { get; set; }
            public string date_started { get; set; }
            public decimal reward { get; set; }
            public string nmc_reward { get; set; }
        }
        //public void RequestStop()
        //{
        //    _shouldStop = true;
        //}
        //public volatile bool _shouldStop;

        public void btnClose_Click(object sender, EventArgs e)
        {
            updateTimer.Stop();
            autoUpdateTimer.Stop();
            Statistics.ActiveForm.Close();
        }

        public void btnUpdate_Click(object sender, EventArgs e)
        {
            if (updateEnabled)
            {
                updateWindow();
                updateEnabled = false;
                updateTimer.Interval = 60000;
                updateTimer.Enabled = true;
            }
            else
            {
                MessageBox.Show("JSon data is cached for 60 seconds." + "\n" + "\n" + "» Please do not throttle the servers.",
                "Cache Alert",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
                return;
            }
        }

        public static void areWeRunning()
        {
            try
            {
                Process[] proc = Process.GetProcessesByName("bfgminer");

                if (proc.Length != 0)
                {
                    lblStatus.Text = "Status: BFGMiner is running...";
                }
                else
                {
                    lblStatus.Text = "Status: BFGMiner is NOT running!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void Statistics_Load(object sender, EventArgs e)
        {
            updateTimer = new System.Timers.Timer(60000);
            updateTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            updateTimer.AutoReset = true;
            updateTimer.Enabled = true;
            updateEnabled = false;

            autoUpdateTimer = new System.Timers.Timer(300000);
            autoUpdateTimer.Elapsed += new ElapsedEventHandler(OnTimedEventAuto);
            autoUpdateTimer.AutoReset = true;
            autoUpdateTimer.Enabled = true;

            GC.KeepAlive(updateTimer);
            GC.KeepAlive(autoUpdateTimer);

            updateWindow();
            updateEnabled = false;
            updateTimer.Interval = 60000;
            updateTimer.Enabled = true;
        }

        public void btnHide_Click(object sender, EventArgs e)
        {
            IntPtr HWND = FindWindow(null, Main.strMinExe);
            System.Threading.Thread.Sleep(1000);
            EnableWindow(HWND, false);
            ShowWindow(HWND, WindowShowStyle.Hide);
        }

        public void btnShow_Click(object sender, EventArgs e)
        {
            IntPtr HWND = FindWindow(null, Main.strMinExe);
            System.Threading.Thread.Sleep(1000);
            ShowWindow(HWND, WindowShowStyle.Show);
            EnableWindow(HWND, true);
        }
    }
}
