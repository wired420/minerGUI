using System;
using System.IO;
using System.Web;
using System.Text;
using System.Drawing;
using System.Security;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace minerGUI
{
    public partial class Main : Form
    {
        static byte[] entropy = System.Text.Encoding.Unicode.GetBytes("%Cow!Boy1Butts*Drive%Me#Nutsz");

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

        Properties.Settings mainSettings = new Properties.Settings();

        public string poolAddr = "";
        public static string workLogin = "";
        public string workPasswd = "";
        public static string workDir = "";
        public string minerType = "";
        public string minerMethod = "";
        public string diffLevel = "";
        public static string myToken = "";

        private SplashScreen splashScreen;
        private bool done = false;
        Statistics statForm = new Statistics();
        public const string minerExe = "bfgminer.exe";

        public Main()
        {
            InitializeComponent();
            this.Load += new EventHandler(HandleFormLoad);
            this.splashScreen = new SplashScreen();
        }

        private void HandleFormLoad(object sender, EventArgs e)
        {
            this.Hide();

            Thread thread = new Thread(new ThreadStart(this.ShowSplashScreen));
            thread.Start();

            Hardworker worker = new Hardworker();
            worker.ProgressChanged += (o, ex) =>
            {
                this.splashScreen.UpdateProgress(ex.Progress);
            };

            worker.HardWorkDone += (o, ex) =>
            {
                done = true;
                this.Show();
            };

            worker.DoHardWork();
        }



        private void ShowSplashScreen()
        {
            splashScreen.Show();
            while (!done)
            {
                Application.DoEvents();
            }
            splashScreen.Close();
            this.splashScreen.Dispose();
        }

        public void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.Show();
        }

        public void txtPoolAddr_TextChanged(object sender, EventArgs e)
        {
            poolAddr = txtPoolAddr.Text;
        }

        public void txtLogin_TextChanged(object sender, EventArgs e)
        {
            workLogin = txtLogin.Text;
            mainSettings.workerLogin = workLogin;
            mainSettings.Save();
        }

        public void txtPasswd_TextChanged(object sender, EventArgs e)
        {
            workPasswd = txtPasswd.Text;
            mainSettings.workerPassword = EncryptString(ToSecureString(workPasswd));
            mainSettings.Save();
        }

        public void txtToken_TextChanged(object sender, EventArgs e)
        {
            myToken = txtToken.Text;
            mainSettings.accountToken = EncryptString(ToSecureString(myToken));
            mainSettings.Save();
        }

        public void setDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            workDir = fbd.SelectedPath;
        }

        public void radMinerEB_CheckedChanged(object sender, EventArgs e)
        {
            minerType = "-S erupter:all";
        }

        public void radMinerGPU_CheckedChanged(object sender, EventArgs e)
        {
            minerType = "";
        }

        public void radPoolStratum_CheckedChanged(object sender, EventArgs e)
        {
            minerMethod = "stratum+tcp://";
        }

        public void radPoolTCP_CheckedChanged(object sender, EventArgs e)
        {
            minerMethod = "http://";
        }

        public void btnStart_Click(object sender, EventArgs e)
        {
            if (workDir == "")
            {
                MessageBox.Show("You MUST set your miners directory." + "\n" + "\n" + "» File » Set Miner",
                "Startup Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                ProcessStartInfo minerProcess = new ProcessStartInfo();
                minerProcess.FileName = strMinExe;
                minerProcess.Arguments = strCmdText;
                minerProcess.UseShellExecute = true;

                if (chkToken.Checked)
                {
                    minerProcess.WindowStyle = ProcessWindowStyle.Hidden;
                }

                Process p = Process.Start(minerProcess);
                IntPtr HWND = FindWindow(null, strMinExe);

                if (chkToken.Checked)
                {
                    System.Threading.Thread.Sleep(1000);
                    ShowWindow(HWND, WindowShowStyle.Show);
                    EnableWindow(HWND, true);
                    Statistics frm = new Statistics();
                    frm.Show();
                }
            }
        }

        public void txtDiff_TextChanged(object sender, EventArgs e)
        {
            diffLevel = txtDiff.Text;
        }

        public void btnSetDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            workDir = fbd.SelectedPath;
        }

        public static string strMinExe
        {
            get { return workDir + "\\" + minerExe; }
        }

        public string strCmdText
        {
            get { return "-o" + " " + minerMethod + poolAddr + " " + "-u" + " " + workLogin + " " + "-p" + " " + workPasswd + " " + minerType + " " + "--request-diff" + " " + diffLevel; }
        }

        public void btnStop_Click(object sender, EventArgs e)
        {
            killMyself();
        }

        public void killMyself()
        {
            try
            {

                Process [] proc = Process.GetProcessesByName("bfgminer");
                if (proc.Length != 0)
                {
                    proc[0].Kill();
                    statForm.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void slushsPoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            poolAddr = "stratum.bitcoin.cz:3333";
            minerMethod = "stratum+tcp://";
            minerType = "-S erupter:all";
            diffLevel = "3.0";
            txtPoolAddr.Text = poolAddr;
            txtDiff.Text = diffLevel;
            radPoolStratum.Checked = true;
            radMinerEB.Checked = true;
            chkToken.Checked = true;
        }

        public void butStats_Click(object sender, EventArgs e)
        {
            statForm.Show();
        }

        public void chkToken_CheckedChanged(object sender, EventArgs e)
        {
            if (chkToken.Checked)
            {
                butStats.Visible = true;
            }
            else
            {
                butStats.Visible = false;
            }
        }

        public void Main_Load(object sender, EventArgs e)
        {
            this.txtPoolAddr.Text = poolAddr;
            this.txtDiff.Text = "1.0";
            this.radPoolTCP.Checked = true;
            this.radMinerEB.Checked = true;
            this.Text = ProductName;
            if (mainSettings.workerLogin != "")
            {
                txtLogin.Text= mainSettings.workerLogin;
            }
            if (mainSettings.workerPassword != "")
            {
                SecureString password = DecryptString(mainSettings.workerPassword);
                txtPasswd.Text = ToInsecureString(password);
                password = ToSecureString("");
            }
            if (mainSettings.accountToken != "")
            {
                SecureString token = DecryptString(mainSettings.accountToken);
                txtToken.Text = ToInsecureString(token);
                token = ToSecureString("");
            }
            tipChkToken.SetToolTip(this.chkToken, "See https://mining.bitcoin.cz/accounts/token-manage/");
        }

        public static string EncryptString(System.Security.SecureString input)
        {
            byte[] encryptedData = System.Security.Cryptography.ProtectedData.Protect(
                System.Text.Encoding.Unicode.GetBytes(ToInsecureString(input)),
                entropy,
                System.Security.Cryptography.DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encryptedData);
        }

        public static SecureString DecryptString(string encryptedData)
        {
            try
            {
                byte[] decryptedData = System.Security.Cryptography.ProtectedData.Unprotect(
                    Convert.FromBase64String(encryptedData),
                    entropy,
                    System.Security.Cryptography.DataProtectionScope.CurrentUser);
                return ToSecureString(System.Text.Encoding.Unicode.GetString(decryptedData));
            }
            catch
            {
                return new SecureString();
            }
        }

        public static SecureString ToSecureString(string input)
        {
            SecureString secure = new SecureString();
            foreach (char c in input)
            {
                secure.AppendChar(c);
            }
            secure.MakeReadOnly();
            return secure;
        }

        public static string ToInsecureString(SecureString input)
        {
            string returnValue = string.Empty;
            IntPtr ptr = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(input);
            try
            {
                returnValue = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(ptr);
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(ptr);
            }
            return returnValue;
        }
    }
}
