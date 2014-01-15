using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minerGUI
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.label1.Text = ProductName;
            this.label2.Text = "Clayton Johnson";
            this.label3.Text = "Build: " + ProductVersion;
        }

        public void btnClose_Click(object sender, EventArgs e)
        {
            About.ActiveForm.Close();
        }
    }
}
