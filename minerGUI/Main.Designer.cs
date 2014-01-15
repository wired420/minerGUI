using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace minerGUI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeBatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slushsPoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtPoolAddr = new System.Windows.Forms.TextBox();
            this.grpPoolType = new System.Windows.Forms.GroupBox();
            this.radPoolStratum = new System.Windows.Forms.RadioButton();
            this.radPoolTCP = new System.Windows.Forms.RadioButton();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.grpWorkerInfo = new System.Windows.Forms.GroupBox();
            this.chkToken = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.labToken = new System.Windows.Forms.Label();
            this.grpMinerType = new System.Windows.Forms.GroupBox();
            this.radMinerEB = new System.Windows.Forms.RadioButton();
            this.radMinerGPU = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiff = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSetDir = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.butStats = new System.Windows.Forms.Button();
            this.tipChkToken = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.grpPoolType.SuspendLayout();
            this.grpWorkerInfo.SuspendLayout();
            this.grpMinerType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.ForeColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setDirectoryToolStripMenuItem,
            this.writeBatchToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // setDirectoryToolStripMenuItem
            // 
            this.setDirectoryToolStripMenuItem.Name = "setDirectoryToolStripMenuItem";
            this.setDirectoryToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.setDirectoryToolStripMenuItem.Text = "Set &Miner";
            this.setDirectoryToolStripMenuItem.Click += new System.EventHandler(this.setDirectoryToolStripMenuItem_Click);
            // 
            // writeBatchToolStripMenuItem
            // 
            this.writeBatchToolStripMenuItem.Name = "writeBatchToolStripMenuItem";
            this.writeBatchToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.writeBatchToolStripMenuItem.Text = "&Write Batch";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(132, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poolToolStripMenuItem,
            this.toolStripMenuItem2,
            this.preferencesToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // poolToolStripMenuItem
            // 
            this.poolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slushsPoolToolStripMenuItem});
            this.poolToolStripMenuItem.Name = "poolToolStripMenuItem";
            this.poolToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.poolToolStripMenuItem.Text = "Pool";
            // 
            // slushsPoolToolStripMenuItem
            // 
            this.slushsPoolToolStripMenuItem.Name = "slushsPoolToolStripMenuItem";
            this.slushsPoolToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.slushsPoolToolStripMenuItem.Text = "Slush\'s Pool";
            this.slushsPoolToolStripMenuItem.Click += new System.EventHandler(this.slushsPoolToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(132, 6);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "&Preferences";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkGray;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnStart.Location = new System.Drawing.Point(558, 187);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(61, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.DarkGray;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(485, 187);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(61, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Sto&p";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtPoolAddr
            // 
            this.txtPoolAddr.Location = new System.Drawing.Point(6, 13);
            this.txtPoolAddr.Name = "txtPoolAddr";
            this.txtPoolAddr.Size = new System.Drawing.Size(420, 20);
            this.txtPoolAddr.TabIndex = 4;
            this.txtPoolAddr.TextChanged += new System.EventHandler(this.txtPoolAddr_TextChanged);
            // 
            // grpPoolType
            // 
            this.grpPoolType.Controls.Add(this.radPoolStratum);
            this.grpPoolType.Controls.Add(this.radPoolTCP);
            this.grpPoolType.Location = new System.Drawing.Point(485, 36);
            this.grpPoolType.Name = "grpPoolType";
            this.grpPoolType.Size = new System.Drawing.Size(134, 37);
            this.grpPoolType.TabIndex = 5;
            this.grpPoolType.TabStop = false;
            this.grpPoolType.Text = "Pool Type";
            // 
            // radPoolStratum
            // 
            this.radPoolStratum.AutoSize = true;
            this.radPoolStratum.Checked = true;
            this.radPoolStratum.Location = new System.Drawing.Point(60, 14);
            this.radPoolStratum.Name = "radPoolStratum";
            this.radPoolStratum.Size = new System.Drawing.Size(61, 17);
            this.radPoolStratum.TabIndex = 1;
            this.radPoolStratum.TabStop = true;
            this.radPoolStratum.Text = "St&ratum";
            this.radPoolStratum.UseVisualStyleBackColor = true;
            this.radPoolStratum.CheckedChanged += new System.EventHandler(this.radPoolStratum_CheckedChanged);
            // 
            // radPoolTCP
            // 
            this.radPoolTCP.AutoSize = true;
            this.radPoolTCP.Location = new System.Drawing.Point(7, 14);
            this.radPoolTCP.Name = "radPoolTCP";
            this.radPoolTCP.Size = new System.Drawing.Size(46, 17);
            this.radPoolTCP.TabIndex = 0;
            this.radPoolTCP.Text = "&TCP";
            this.radPoolTCP.UseVisualStyleBackColor = true;
            this.radPoolTCP.CheckedChanged += new System.EventHandler(this.radPoolTCP_CheckedChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(31, 18);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(70, 14);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(145, 20);
            this.txtLogin.TabIndex = 8;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(221, 18);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password";
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(280, 15);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(145, 20);
            this.txtPasswd.TabIndex = 10;
            this.txtPasswd.UseSystemPasswordChar = true;
            this.txtPasswd.TextChanged += new System.EventHandler(this.txtPasswd_TextChanged);
            // 
            // grpWorkerInfo
            // 
            this.grpWorkerInfo.Controls.Add(this.chkToken);
            this.grpWorkerInfo.Controls.Add(this.label1);
            this.grpWorkerInfo.Controls.Add(this.txtToken);
            this.grpWorkerInfo.Controls.Add(this.labToken);
            this.grpWorkerInfo.Controls.Add(this.lblLogin);
            this.grpWorkerInfo.Controls.Add(this.txtPasswd);
            this.grpWorkerInfo.Controls.Add(this.txtLogin);
            this.grpWorkerInfo.Controls.Add(this.lblPassword);
            this.grpWorkerInfo.Location = new System.Drawing.Point(24, 79);
            this.grpWorkerInfo.Name = "grpWorkerInfo";
            this.grpWorkerInfo.Size = new System.Drawing.Size(432, 94);
            this.grpWorkerInfo.TabIndex = 11;
            this.grpWorkerInfo.TabStop = false;
            this.grpWorkerInfo.Text = "Worker Information";
            // 
            // chkToken
            // 
            this.chkToken.AutoSize = true;
            this.chkToken.Location = new System.Drawing.Point(10, 71);
            this.chkToken.Name = "chkToken";
            this.chkToken.Size = new System.Drawing.Size(15, 14);
            this.chkToken.TabIndex = 16;
            this.chkToken.UseVisualStyleBackColor = true;
            this.chkToken.CheckedChanged += new System.EventHandler(this.chkToken_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(181, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "-- OPTIONAL --";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(71, 68);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(355, 20);
            this.txtToken.TabIndex = 14;
            this.txtToken.UseSystemPasswordChar = true;
            this.txtToken.TextChanged += new System.EventHandler(this.txtToken_TextChanged);
            // 
            // labToken
            // 
            this.labToken.AutoSize = true;
            this.labToken.Location = new System.Drawing.Point(31, 71);
            this.labToken.Name = "labToken";
            this.labToken.Size = new System.Drawing.Size(38, 13);
            this.labToken.TabIndex = 13;
            this.labToken.Text = "Token";
            // 
            // grpMinerType
            // 
            this.grpMinerType.Controls.Add(this.radMinerEB);
            this.grpMinerType.Controls.Add(this.radMinerGPU);
            this.grpMinerType.Location = new System.Drawing.Point(485, 79);
            this.grpMinerType.Name = "grpMinerType";
            this.grpMinerType.Size = new System.Drawing.Size(134, 37);
            this.grpMinerType.TabIndex = 12;
            this.grpMinerType.TabStop = false;
            this.grpMinerType.Text = "Miner Type";
            // 
            // radMinerEB
            // 
            this.radMinerEB.AutoSize = true;
            this.radMinerEB.Checked = true;
            this.radMinerEB.Location = new System.Drawing.Point(60, 14);
            this.radMinerEB.Name = "radMinerEB";
            this.radMinerEB.Size = new System.Drawing.Size(64, 17);
            this.radMinerEB.TabIndex = 1;
            this.radMinerEB.TabStop = true;
            this.radMinerEB.Text = "Erpt/&Bld";
            this.radMinerEB.UseVisualStyleBackColor = true;
            this.radMinerEB.CheckedChanged += new System.EventHandler(this.radMinerEB_CheckedChanged);
            // 
            // radMinerGPU
            // 
            this.radMinerGPU.AutoSize = true;
            this.radMinerGPU.Location = new System.Drawing.Point(7, 14);
            this.radMinerGPU.Name = "radMinerGPU";
            this.radMinerGPU.Size = new System.Drawing.Size(48, 17);
            this.radMinerGPU.TabIndex = 0;
            this.radMinerGPU.Text = "&GPU";
            this.radMinerGPU.UseVisualStyleBackColor = true;
            this.radMinerGPU.CheckedChanged += new System.EventHandler(this.radMinerGPU_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiff);
            this.groupBox1.Location = new System.Drawing.Point(485, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 41);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficulty";
            // 
            // txtDiff
            // 
            this.txtDiff.Location = new System.Drawing.Point(7, 15);
            this.txtDiff.Name = "txtDiff";
            this.txtDiff.Size = new System.Drawing.Size(121, 20);
            this.txtDiff.TabIndex = 0;
            this.txtDiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiff.TextChanged += new System.EventHandler(this.txtDiff_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPoolAddr);
            this.groupBox2.Location = new System.Drawing.Point(24, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 37);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pool Address";
            // 
            // btnSetDir
            // 
            this.btnSetDir.BackColor = System.Drawing.Color.DarkGray;
            this.btnSetDir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetDir.ForeColor = System.Drawing.Color.Black;
            this.btnSetDir.Location = new System.Drawing.Point(24, 188);
            this.btnSetDir.Name = "btnSetDir";
            this.btnSetDir.Size = new System.Drawing.Size(69, 23);
            this.btnSetDir.TabIndex = 15;
            this.btnSetDir.Text = "Set &Miner";
            this.btnSetDir.UseVisualStyleBackColor = false;
            this.btnSetDir.Click += new System.EventHandler(this.btnSetDir_Click);
            // 
            // butStats
            // 
            this.butStats.BackColor = System.Drawing.Color.DarkGray;
            this.butStats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butStats.ForeColor = System.Drawing.Color.Black;
            this.butStats.Location = new System.Drawing.Point(387, 187);
            this.butStats.Name = "butStats";
            this.butStats.Size = new System.Drawing.Size(69, 23);
            this.butStats.TabIndex = 16;
            this.butStats.Text = "Statistics";
            this.butStats.UseVisualStyleBackColor = false;
            this.butStats.Visible = false;
            this.butStats.Click += new System.EventHandler(this.butStats_Click);
            // 
            // tipChkToken
            // 
            this.tipChkToken.IsBalloon = true;
            this.tipChkToken.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tipChkToken.ToolTipTitle = "API Tokens";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(644, 223);
            this.Controls.Add(this.butStats);
            this.Controls.Add(this.btnSetDir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpMinerType);
            this.Controls.Add(this.grpWorkerInfo);
            this.Controls.Add(this.grpPoolType);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = this.ProductName;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpPoolType.ResumeLayout(false);
            this.grpPoolType.PerformLayout();
            this.grpWorkerInfo.ResumeLayout(false);
            this.grpWorkerInfo.PerformLayout();
            this.grpMinerType.ResumeLayout(false);
            this.grpMinerType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem setDirectoryToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.Button btnStop;
        public System.Windows.Forms.TextBox txtPoolAddr;
        public System.Windows.Forms.GroupBox grpPoolType;
        public System.Windows.Forms.RadioButton radPoolStratum;
        public System.Windows.Forms.RadioButton radPoolTCP;
        public System.Windows.Forms.Label lblLogin;
        public System.Windows.Forms.TextBox txtLogin;
        public System.Windows.Forms.Label lblPassword;
        public System.Windows.Forms.TextBox txtPasswd;
        public System.Windows.Forms.GroupBox grpWorkerInfo;
        public System.Windows.Forms.GroupBox grpMinerType;
        public System.Windows.Forms.RadioButton radMinerEB;
        public System.Windows.Forms.RadioButton radMinerGPU;
        public System.Windows.Forms.ToolStripMenuItem writeBatchToolStripMenuItem;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtDiff;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btnSetDir;
        public System.Windows.Forms.ColorDialog colorDialog1;
        public Label label1;
        public TextBox txtToken;
        public Label labToken;
        public ToolStripMenuItem poolToolStripMenuItem;
        public ToolStripMenuItem slushsPoolToolStripMenuItem;
        public ToolStripSeparator toolStripMenuItem2;
        public Button butStats;
        public CheckBox chkToken;
        public ToolTip tipChkToken;

    }
}

