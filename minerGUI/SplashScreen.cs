using System.Windows.Forms;
using System.Linq;

namespace minerGUI
{
    public partial class SplashScreen : Form
    {
        private delegate void ProgressDelegate(int progress);

        private ProgressDelegate del;
        public SplashScreen()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.progressBar1.Maximum = 100;
            del = this.UpdateProgressInternal;
            this.label4.Text = ProductVersion;
        }

        private void UpdateProgressInternal(int progress)
        {
            if (this.Handle == null)
            {
                return;
            }

            this.progressBar1.Value = progress;
            this.label2.Text = "(" + progress + "%)";
        }

        public void UpdateProgress(int progress)
        {
            this.Invoke(del, progress);
        }

        private void lblHttpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.minergui.org");
        }
    }
}
