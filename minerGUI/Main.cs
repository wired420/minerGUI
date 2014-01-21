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
        static byte[] entropy = System.Text.Encoding.Unicode.GetBytes("Encryption Key: Enter Non-Default Salt Value Here.");

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
        
        // Stuff for building command line start command
        public int useScrypt = 0;
        public int useIntense = 0;
        public int useGPUThread = 0;
        public int useWorkSize = 0;
        public int useThreadConn = 0;

        public string poolAddr = "";
        public static string workLogin = "";
        public string workPasswd = "";
        public static string workDir = "";
        public string minerType = "";
        public string minerMethod = "";
        public string diffLevel = "";
        public static string myToken = "";
        public static string scrypt = "--scrypt";
        public string intensityLevel = "";
        public string gpuThread = "";
        public string workSize = "";
        public string threadConn = "";
        public string cmdToRun;

        private SplashScreen splashScreen;
        private bool done = false;
        
        Statistics statForm = new Statistics();
        StringBuilder cmdString = new StringBuilder();

        public static string minerExe = "";

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

        public void setFile()
        {
            string fileOne = "bfgminer.exe";
            string fileTwo = "cgminer.exe";

            if (File.Exists(workDir + "\\" + fileOne))
            {
                minerExe = "bfgminer.exe";
            }
            if (File.Exists(workDir + "\\" + fileTwo))
            {
                minerExe = "cgminer.exe";
            }
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
            mainSettings.mpPoolAddress = poolAddr;
            mainSettings.Save();
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
            setFile();
            mainSettings.minerDirectory = workDir;
            mainSettings.Save();
        }

        public void radMinerEB_CheckedChanged(object sender, EventArgs e)
        {
            minerType = "-S erupter:all";
            mainSettings.minerSwitch = 2;
            mainSettings.Save();
        }

        public void radMinerGPU_CheckedChanged(object sender, EventArgs e)
        {
            minerType = "-S auto";
            mainSettings.minerSwitch = 1;
            mainSettings.Save();
        }

        public void radPoolStratum_CheckedChanged(object sender, EventArgs e)
        {
            minerMethod = "stratum+tcp://";
            mainSettings.poolSwitch = 2;
            mainSettings.Save();
        }

        public void radPoolTCP_CheckedChanged(object sender, EventArgs e)
        {
            minerMethod = "http://";
            mainSettings.poolSwitch = 1;
            mainSettings.Save();
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
                buildString();
                setFile();
                ProcessStartInfo minerProcess = new ProcessStartInfo();
                minerProcess.FileName = strMinExe;
                minerProcess.Arguments = cmdToRun;
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
            mainSettings.diffSetting = diffLevel;
            mainSettings.Save();
        }

        public void btnSetDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            workDir = fbd.SelectedPath;
            setFile();
            mainSettings.minerDirectory = workDir;
            mainSettings.Save();
        }

        public static string strMinExe
        {
            get { return workDir + "\\" + minerExe; }
        }

        public void buildString()
        {
            cmdString.Clear();

            // scrypt
            if (useScrypt == 1)
            {
                cmdString.Append("-o " + poolAddr + " ");
                cmdString.Append("-u " + workLogin + " ");
                cmdString.Append("-p " + workPasswd + " ");
                if (mainSettings.useIntense == 1 && mainSettings.intensityLevel != "")
                {
                    cmdString.Append("-I ");
                    cmdString.Append(mainSettings.intensityLevel + " ");
                }
                if (mainSettings.useGPUThread == 1 && mainSettings.gpuThread != "")
                {
                    cmdString.Append("-g ");
                    cmdString.Append(mainSettings.gpuThread + " ");
                }
                if (mainSettings.useWorkSize == 1 && mainSettings.workSize != "")
                {
                    cmdString.Append("-w ");
                    cmdString.Append(mainSettings.workSize + " ");
                }
                if (mainSettings.useThreadConn == 1 && mainSettings.threadConn != "")
                {
                    cmdString.Append("--thread-concurrency ");
                    cmdString.Append(mainSettings.threadConn + " ");
                }
                if (minerExe == "cgminer.exe")
                {
                    cmdString.Append("-d all ");
                }
                if (minerExe == "bfgminer.exe")
                {
                    cmdString.Append("-S auto ");
                }
                cmdToRun = cmdString.ToString();
            }
            else
            {
                //SHA256
                cmdString.Append("-o " + poolAddr + " ");
                cmdString.Append("-u " + workLogin + " ");
                cmdString.Append("-p " + workPasswd + " ");
                if (minerExe == "cgminer.exe")
                {
                    if (radMinerGPU.Checked)
                    {
                        cmdString.Append("-d all ");
                    }
                    else
                    {
                        cmdString.Append("-G ");
                    }
                }
                if (minerExe == "bfgminer.exe")
                {
                    if (radMinerGPU.Checked)
                    {
                        cmdString.Append("-S auto ");
                    }
                    else
                    {
                        cmdString.Append("-S erupter:all");
                    }
                }
                cmdToRun = cmdString.ToString();
            }
            cmdString.Clear();
        }

        public void btnStop_Click(object sender, EventArgs e)
        {
            killMyself();
        }

        public void killMyself()
        {
            try
            {
                string line = Main.minerExe;
                string fileWOexe = Path.GetFileNameWithoutExtension(line);

                Process[] proc = Process.GetProcessesByName(fileWOexe);
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
                txtToken.ReadOnly = false;
                mainSettings.tokenChecked = 1;
                mainSettings.Save();
            }
            else
            {
                butStats.Visible = false;
                txtToken.ReadOnly = true;
                mainSettings.tokenChecked = 0;
                mainSettings.Save();
            }
        }

        public void Main_Load(object sender, EventArgs e)
        {
            this.txtPoolAddr.Text = poolAddr;
            this.txtDiff.Text = "1.0";
            this.Text = ProductName;
            if (mainSettings.workerLogin != "")
            {
                txtLogin.Text = mainSettings.workerLogin;
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
            if (mainSettings.minerDirectory != "")
            {
                workDir = mainSettings.minerDirectory;
            }
            if (mainSettings.mpPoolAddress != "")
            {
                poolAddr = mainSettings.mpPoolAddress;
                txtPoolAddr.Text = poolAddr;
            }
            if (mainSettings.diffSetting != "")
            {
                diffLevel = mainSettings.diffSetting;
                txtDiff.Text = diffLevel;
            }
            if (mainSettings.tokenChecked == 1)
            {
                chkToken.Checked = true;
                txtToken.ReadOnly = false;
            }
            if (mainSettings.minerSwitch == 1)
            {
                radMinerGPU.Checked = true;
                minerType = "-S auto";
            }
            if (mainSettings.minerSwitch == 2)
            {
                radMinerEB.Checked = true;
                minerType = "-S erupter:all";
            }
            if (mainSettings.poolSwitch == 1)
            {
                radPoolTCP.Checked = true;
                minerMethod = "http://";
            }
            if (mainSettings.poolSwitch == 2)
            {
                radPoolStratum.Checked = true;
                minerMethod = "stratum+tcp://";
            }
            if (mainSettings.useScrypt == 1)
            {
                useScrypt = 1;
                chkScrypt.Checked = true;
                chkIntense.Enabled = true;
                chkGPUThread.Enabled = true;
                chkWorkSize.Enabled = true;
                chkThreadConn.Enabled = true;
                radMinerEB.Enabled = false;
                radMinerGPU.Checked = true;
                minerType = "-S auto";
            }
            if (mainSettings.useScrypt == 0)
            {
                useScrypt = 0;
                chkScrypt.Checked = false;
                chkIntense.Enabled = false;
                chkGPUThread.Enabled = false;
                chkWorkSize.Enabled = false;
                chkThreadConn.Enabled = false;
                radMinerEB.Enabled = true;
                minerType = "-S auto";
            }
            if (mainSettings.useIntense == 1)
            {
                useIntense = 1;
                txtIntense.ReadOnly = false;
                chkIntense.Checked = true;

                if (mainSettings.intensityLevel != "")
                {
                    txtIntense.Text = mainSettings.intensityLevel;
                }
            }
            if (mainSettings.useGPUThread == 1)
            {
                useGPUThread = 1;
                txtGPUThread.ReadOnly = false;
                chkGPUThread.Checked = true;

                if (mainSettings.gpuThread != "")
                {
                    txtGPUThread.Text = mainSettings.gpuThread;
                }
            }
            if (mainSettings.useWorkSize == 1)
            {
                useWorkSize = 1;
                txtWorkSize.ReadOnly = false;
                chkWorkSize.Checked = true;

                if (mainSettings.workSize != "")
                {
                    txtWorkSize.Text = mainSettings.workSize;
                }
            }
            if (mainSettings.useThreadConn == 1)
            {
                useThreadConn = 1;
                txtThreadConn.ReadOnly = false;
                chkThreadConn.Checked = true;

                if (mainSettings.threadConn != "")
                {
                    txtThreadConn.Text = mainSettings.threadConn;
                }
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

        private void chkScrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (chkScrypt.Checked)
            {
                useScrypt = 1;
                chkIntense.Enabled = true;
                chkGPUThread.Enabled = true;
                chkWorkSize.Enabled = true;
                chkThreadConn.Enabled = true;
                radMinerEB.Enabled = false;
                radMinerGPU.Checked = true;
                minerType = "-S auto";
                mainSettings.useScrypt = useScrypt;
                mainSettings.Save();
            }
            else
            {
                useScrypt = 0;
                chkIntense.Enabled = false;
                chkGPUThread.Enabled = false;
                chkWorkSize.Enabled = false;
                chkThreadConn.Enabled = false;
                radMinerEB.Enabled = true;
                mainSettings.useScrypt = useScrypt;
                mainSettings.Save();
            }
        }

        private void chkIntense_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIntense.Checked)
            {
                useIntense = 1;
                txtIntense.ReadOnly = false;
                mainSettings.useIntense = useIntense;
                mainSettings.Save();
            }
            else
            {
                useIntense = 0;
                txtIntense.ReadOnly = true;
                mainSettings.useIntense = useIntense;
                mainSettings.Save();
            }
        }

        private void chkGPUThread_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGPUThread.Checked)
            {
                useGPUThread = 1;
                txtGPUThread.ReadOnly = false;
                mainSettings.useGPUThread = useGPUThread;
                mainSettings.Save();
            }
            else
            {
                useGPUThread = 0;
                txtGPUThread.ReadOnly = true;
                mainSettings.useGPUThread = useGPUThread;
                mainSettings.Save();
            }
        }

        private void chkWorkSize_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWorkSize.Checked)
            {
                useWorkSize = 1;
                txtWorkSize.ReadOnly = false;
                mainSettings.useWorkSize = useWorkSize;
                mainSettings.Save();
            }
            else
            {
                useWorkSize = 0;
                txtWorkSize.ReadOnly = true;
                mainSettings.useWorkSize = useWorkSize;
                mainSettings.Save();
            }
        }

        private void chkThreadConn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkThreadConn.Checked)
            {
                useThreadConn = 1;
                txtThreadConn.ReadOnly = false;
                mainSettings.useThreadConn = useThreadConn;
                mainSettings.Save();
            }
            else
            {
                useThreadConn = 0;
                txtThreadConn.ReadOnly = true;
                mainSettings.useThreadConn = useThreadConn;
                mainSettings.Save();
            }
        }

        private void txtIntense_TextChanged(object sender, EventArgs e)
        {
            intensityLevel = txtIntense.Text;
            mainSettings.intensityLevel = intensityLevel;
            mainSettings.Save();
        }

        private void txtGPUThread_TextChanged(object sender, EventArgs e)
        {
            gpuThread = txtGPUThread.Text;
            mainSettings.gpuThread = gpuThread;
            mainSettings.Save();
        }

        private void txtWorkSize_TextChanged(object sender, EventArgs e)
        {
            workSize = txtWorkSize.Text;
            mainSettings.workSize = workSize;
            mainSettings.Save();
        }

        private void txtThreadConn_TextChanged(object sender, EventArgs e)
        {
            threadConn = txtThreadConn.Text;
            mainSettings.threadConn = threadConn;
            mainSettings.Save();
        }
    }
}
