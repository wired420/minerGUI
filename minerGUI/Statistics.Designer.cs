namespace minerGUI
{
    partial class Statistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            this.lblWorker = new System.Windows.Forms.Label();
            txtWorker = new System.Windows.Forms.TextBox();
            this.lblUnconfirmed = new System.Windows.Forms.Label();
            txtUnconfirmed = new System.Windows.Forms.TextBox();
            this.lblConfirmed = new System.Windows.Forms.Label();
            txtConfirmed = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            txtTotal = new System.Windows.Forms.TextBox();
            this.lblRoundDuration = new System.Windows.Forms.Label();
            txtRoundDuration = new System.Windows.Forms.TextBox();
            this.lblPercentComplete = new System.Windows.Forms.Label();
            txtPercentComplete = new System.Windows.Forms.TextBox();
            this.lblEstimatedReward = new System.Windows.Forms.Label();
            txtEstimatedReward = new System.Windows.Forms.TextBox();
            this.lblMyHashrate = new System.Windows.Forms.Label();
            txtMyHashrate = new System.Windows.Forms.TextBox();
            this.lblLuckMain = new System.Windows.Forms.Label();
            txtLuck_1 = new System.Windows.Forms.TextBox();
            txtLuck_7 = new System.Windows.Forms.TextBox();
            txtLuck_30 = new System.Windows.Forms.TextBox();
            this.lblLuck_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLuck_30 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            lblStatus = new System.Windows.Forms.Label();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Location = new System.Drawing.Point(71, 15);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(47, 13);
            this.lblWorker.TabIndex = 0;
            this.lblWorker.Text = "Account";
            // 
            // txtWorker
            // 
            txtWorker.Location = new System.Drawing.Point(126, 12);
            txtWorker.Name = "txtWorker";
            txtWorker.ReadOnly = true;
            txtWorker.Size = new System.Drawing.Size(134, 20);
            txtWorker.TabIndex = 1;
            // 
            // lblUnconfirmed
            // 
            this.lblUnconfirmed.AutoSize = true;
            this.lblUnconfirmed.Location = new System.Drawing.Point(11, 44);
            this.lblUnconfirmed.Name = "lblUnconfirmed";
            this.lblUnconfirmed.Size = new System.Drawing.Size(107, 13);
            this.lblUnconfirmed.TabIndex = 2;
            this.lblUnconfirmed.Text = "Unconfirmed Reward";
            // 
            // txtUnconfirmed
            // 
            txtUnconfirmed.Location = new System.Drawing.Point(126, 41);
            txtUnconfirmed.Name = "txtUnconfirmed";
            txtUnconfirmed.ReadOnly = true;
            txtUnconfirmed.Size = new System.Drawing.Size(134, 20);
            txtUnconfirmed.TabIndex = 3;
            // 
            // lblConfirmed
            // 
            this.lblConfirmed.AutoSize = true;
            this.lblConfirmed.Location = new System.Drawing.Point(24, 74);
            this.lblConfirmed.Name = "lblConfirmed";
            this.lblConfirmed.Size = new System.Drawing.Size(94, 13);
            this.lblConfirmed.TabIndex = 4;
            this.lblConfirmed.Text = "Confirmed Reward";
            // 
            // txtConfirmed
            // 
            txtConfirmed.Location = new System.Drawing.Point(126, 70);
            txtConfirmed.Name = "txtConfirmed";
            txtConfirmed.ReadOnly = true;
            txtConfirmed.Size = new System.Drawing.Size(134, 20);
            txtConfirmed.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(47, 103);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(71, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total Reward";
            // 
            // txtTotal
            // 
            txtTotal.Location = new System.Drawing.Point(126, 99);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new System.Drawing.Size(134, 20);
            txtTotal.TabIndex = 7;
            // 
            // lblRoundDuration
            // 
            this.lblRoundDuration.AutoSize = true;
            this.lblRoundDuration.Location = new System.Drawing.Point(324, 15);
            this.lblRoundDuration.Name = "lblRoundDuration";
            this.lblRoundDuration.Size = new System.Drawing.Size(82, 13);
            this.lblRoundDuration.TabIndex = 8;
            this.lblRoundDuration.Text = "Round Duration";
            // 
            // txtRoundDuration
            // 
            txtRoundDuration.Location = new System.Drawing.Point(411, 12);
            txtRoundDuration.Name = "txtRoundDuration";
            txtRoundDuration.ReadOnly = true;
            txtRoundDuration.Size = new System.Drawing.Size(134, 20);
            txtRoundDuration.TabIndex = 9;
            // 
            // lblPercentComplete
            // 
            this.lblPercentComplete.AutoSize = true;
            this.lblPercentComplete.Location = new System.Drawing.Point(312, 44);
            this.lblPercentComplete.Name = "lblPercentComplete";
            this.lblPercentComplete.Size = new System.Drawing.Size(94, 13);
            this.lblPercentComplete.TabIndex = 10;
            this.lblPercentComplete.Text = "Round Completion";
            // 
            // txtPercentComplete
            // 
            txtPercentComplete.Location = new System.Drawing.Point(411, 41);
            txtPercentComplete.Name = "txtPercentComplete";
            txtPercentComplete.ReadOnly = true;
            txtPercentComplete.Size = new System.Drawing.Size(134, 20);
            txtPercentComplete.TabIndex = 11;
            // 
            // lblEstimatedReward
            // 
            this.lblEstimatedReward.AutoSize = true;
            this.lblEstimatedReward.Location = new System.Drawing.Point(313, 74);
            this.lblEstimatedReward.Name = "lblEstimatedReward";
            this.lblEstimatedReward.Size = new System.Drawing.Size(93, 13);
            this.lblEstimatedReward.TabIndex = 12;
            this.lblEstimatedReward.Text = "Estimated Reward";
            // 
            // txtEstimatedReward
            // 
            txtEstimatedReward.Location = new System.Drawing.Point(411, 70);
            txtEstimatedReward.Name = "txtEstimatedReward";
            txtEstimatedReward.ReadOnly = true;
            txtEstimatedReward.Size = new System.Drawing.Size(134, 20);
            txtEstimatedReward.TabIndex = 13;
            // 
            // lblMyHashrate
            // 
            this.lblMyHashrate.AutoSize = true;
            this.lblMyHashrate.Location = new System.Drawing.Point(331, 103);
            this.lblMyHashrate.Name = "lblMyHashrate";
            this.lblMyHashrate.Size = new System.Drawing.Size(75, 13);
            this.lblMyHashrate.TabIndex = 14;
            this.lblMyHashrate.Text = "My Hash Rate";
            // 
            // txtMyHashrate
            // 
            txtMyHashrate.Location = new System.Drawing.Point(411, 99);
            txtMyHashrate.Name = "txtMyHashrate";
            txtMyHashrate.ReadOnly = true;
            txtMyHashrate.Size = new System.Drawing.Size(134, 20);
            txtMyHashrate.TabIndex = 15;
            // 
            // lblLuckMain
            // 
            this.lblLuckMain.AutoSize = true;
            this.lblLuckMain.Location = new System.Drawing.Point(143, 155);
            this.lblLuckMain.Name = "lblLuckMain";
            this.lblLuckMain.Size = new System.Drawing.Size(55, 13);
            this.lblLuckMain.TabIndex = 16;
            this.lblLuckMain.Text = "Pool Luck";
            // 
            // txtLuck_1
            // 
            txtLuck_1.Location = new System.Drawing.Point(204, 152);
            txtLuck_1.Name = "txtLuck_1";
            txtLuck_1.ReadOnly = true;
            txtLuck_1.Size = new System.Drawing.Size(50, 20);
            txtLuck_1.TabIndex = 17;
            // 
            // txtLuck_7
            // 
            txtLuck_7.Location = new System.Drawing.Point(260, 152);
            txtLuck_7.Name = "txtLuck_7";
            txtLuck_7.ReadOnly = true;
            txtLuck_7.Size = new System.Drawing.Size(50, 20);
            txtLuck_7.TabIndex = 18;
            // 
            // txtLuck_30
            // 
            txtLuck_30.Location = new System.Drawing.Point(316, 152);
            txtLuck_30.Name = "txtLuck_30";
            txtLuck_30.ReadOnly = true;
            txtLuck_30.Size = new System.Drawing.Size(50, 20);
            txtLuck_30.TabIndex = 19;
            // 
            // lblLuck_1
            // 
            this.lblLuck_1.AutoSize = true;
            this.lblLuck_1.Location = new System.Drawing.Point(211, 136);
            this.lblLuck_1.Name = "lblLuck_1";
            this.lblLuck_1.Size = new System.Drawing.Size(35, 13);
            this.lblLuck_1.TabIndex = 20;
            this.lblLuck_1.Text = "1 Day";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "7 Days";
            // 
            // lblLuck_30
            // 
            this.lblLuck_30.AutoSize = true;
            this.lblLuck_30.Location = new System.Drawing.Point(318, 136);
            this.lblLuck_30.Name = "lblLuck_30";
            this.lblLuck_30.Size = new System.Drawing.Size(46, 13);
            this.lblLuck_30.TabIndex = 22;
            this.lblLuck_30.Text = "30 Days";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(204, 192);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(291, 192);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(561, 245);
            this.shapeContainer1.TabIndex = 25;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -1;
            this.lineShape1.X2 = 562;
            this.lineShape1.Y1 = 223;
            this.lineShape1.Y2 = 223;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblStatus.Location = new System.Drawing.Point(4, 229);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(160, 13);
            lblStatus.TabIndex = 26;
            lblStatus.Text = "Status: Not Checked Yet...";
            // 
            // btnHide
            // 
            this.btnHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.Location = new System.Drawing.Point(6, 19);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(60, 23);
            this.btnHide.TabIndex = 27;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(72, 19);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(60, 23);
            this.btnShow.TabIndex = 28;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHide);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Location = new System.Drawing.Point(411, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 45);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Miner Window";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(561, 245);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(lblStatus);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblLuck_30);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLuck_1);
            this.Controls.Add(txtLuck_30);
            this.Controls.Add(txtLuck_7);
            this.Controls.Add(txtLuck_1);
            this.Controls.Add(this.lblLuckMain);
            this.Controls.Add(txtMyHashrate);
            this.Controls.Add(this.lblMyHashrate);
            this.Controls.Add(txtEstimatedReward);
            this.Controls.Add(this.lblEstimatedReward);
            this.Controls.Add(txtPercentComplete);
            this.Controls.Add(this.lblPercentComplete);
            this.Controls.Add(txtRoundDuration);
            this.Controls.Add(this.lblRoundDuration);
            this.Controls.Add(txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(txtConfirmed);
            this.Controls.Add(this.lblConfirmed);
            this.Controls.Add(txtUnconfirmed);
            this.Controls.Add(this.lblUnconfirmed);
            this.Controls.Add(txtWorker);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblWorker;
        public System.Windows.Forms.Label lblUnconfirmed;
        public System.Windows.Forms.Label lblConfirmed;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label lblRoundDuration;
        public System.Windows.Forms.Label lblPercentComplete;
        public System.Windows.Forms.Label lblEstimatedReward;
        public System.Windows.Forms.Label lblMyHashrate;
        public System.Windows.Forms.Label lblLuckMain;
        public System.Windows.Forms.Label lblLuck_1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblLuck_30;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnClose;
        public Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        public Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        public static System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Button btnHide;
        public System.Windows.Forms.Button btnShow;
        public System.Windows.Forms.GroupBox groupBox1;
        public static System.Windows.Forms.TextBox txtWorker;
        public static System.Windows.Forms.TextBox txtUnconfirmed;
        public static System.Windows.Forms.TextBox txtConfirmed;
        public static System.Windows.Forms.TextBox txtTotal;
        public static System.Windows.Forms.TextBox txtRoundDuration;
        public static System.Windows.Forms.TextBox txtPercentComplete;
        public static System.Windows.Forms.TextBox txtEstimatedReward;
        public static System.Windows.Forms.TextBox txtMyHashrate;
        public static System.Windows.Forms.TextBox txtLuck_1;
        public static System.Windows.Forms.TextBox txtLuck_7;
        public static System.Windows.Forms.TextBox txtLuck_30;
    }
}