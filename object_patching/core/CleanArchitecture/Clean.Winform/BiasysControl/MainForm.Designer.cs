
namespace BiasysControl
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            statusTripBottom = new StatusStrip();
            lblComputer = new ToolStripStatusLabel();
            lblSeparator1 = new ToolStripStatusLabel();
            lblUserLogin = new ToolStripStatusLabel();
            lblSeparator3 = new ToolStripStatusLabel();
            lblLicense = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblSpaceStatus = new ToolStripStatusLabel();
            lblCurrentTime = new ToolStripStatusLabel();
            imgLeftMenuList = new ImageList(components);
            timerNow = new System.Windows.Forms.Timer(components);
            pnlTopControl = new Panel();
            pnlTitle = new Panel();
            lblTitle2 = new Label();
            lblTitle = new Label();
            pnlContent = new Panel();
            pnlRightContent = new Panel();
            pnlLeftMenu = new Panel();
            picAccount = new PictureBox();
            btnQuitApp = new Button();
            btnRestartApp = new Button();
            btnStandardSewing = new Button();
            btn02 = new Button();
            btn01 = new Button();
            btnNewArticleAndOrder = new Button();
            btnNewSeam = new Button();
            btnReprint = new Button();
            btnNewNeedle = new Button();
            btnChangeStitchLength = new Button();
            btnWindingBobbin = new Button();
            btnChangeBobbin = new Button();
            btnChangeNeedleThread = new Button();
            statusTripBottom.SuspendLayout();
            pnlTopControl.SuspendLayout();
            pnlTitle.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlLeftMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAccount).BeginInit();
            SuspendLayout();
            // 
            // statusTripBottom
            // 
            statusTripBottom.ImageScalingSize = new Size(20, 20);
            statusTripBottom.Items.AddRange(new ToolStripItem[] { lblComputer, lblSeparator1, lblUserLogin, lblSeparator3, lblLicense, toolStripStatusLabel1, lblSpaceStatus, lblCurrentTime });
            statusTripBottom.Location = new Point(0, 766);
            statusTripBottom.Name = "statusTripBottom";
            statusTripBottom.Size = new Size(1429, 26);
            statusTripBottom.TabIndex = 2;
            statusTripBottom.Text = "statusStrip";
            // 
            // lblComputer
            // 
            lblComputer.Image = (Image)resources.GetObject("lblComputer.Image");
            lblComputer.Name = "lblComputer";
            lblComputer.Size = new Size(98, 20);
            lblComputer.Text = "Computer:";
            // 
            // lblSeparator1
            // 
            lblSeparator1.Name = "lblSeparator1";
            lblSeparator1.Size = new Size(13, 20);
            lblSeparator1.Text = "|";
            // 
            // lblUserLogin
            // 
            lblUserLogin.Image = (Image)resources.GetObject("lblUserLogin.Image");
            lblUserLogin.Name = "lblUserLogin";
            lblUserLogin.Size = new Size(78, 20);
            lblUserLogin.Text = "User id:";
            // 
            // lblSeparator3
            // 
            lblSeparator3.Name = "lblSeparator3";
            lblSeparator3.Size = new Size(13, 20);
            lblSeparator3.Text = "|";
            // 
            // lblLicense
            // 
            lblLicense.Image = (Image)resources.GetObject("lblLicense.Image");
            lblLicense.Name = "lblLicense";
            lblLicense.Size = new Size(84, 20);
            lblLicense.Text = "License: ";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(13, 20);
            toolStripStatusLabel1.Text = "|";
            // 
            // lblSpaceStatus
            // 
            lblSpaceStatus.Name = "lblSpaceStatus";
            lblSpaceStatus.Size = new Size(0, 20);
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.Image = (Image)resources.GetObject("lblCurrentTime.Image");
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.RightToLeft = RightToLeft.No;
            lblCurrentTime.Size = new Size(63, 20);
            lblCurrentTime.Text = "Now:";
            // 
            // imgLeftMenuList
            // 
            imgLeftMenuList.ColorDepth = ColorDepth.Depth8Bit;
            imgLeftMenuList.ImageStream = (ImageListStreamer)resources.GetObject("imgLeftMenuList.ImageStream");
            imgLeftMenuList.TransparentColor = Color.Transparent;
            imgLeftMenuList.Images.SetKeyName(0, "10.BMP");
            // 
            // timerNow
            // 
            timerNow.Interval = 1000;
            timerNow.Tick += timerNow_Tick;
            // 
            // pnlTopControl
            // 
            pnlTopControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTopControl.BorderStyle = BorderStyle.FixedSingle;
            pnlTopControl.Controls.Add(pnlTitle);
            pnlTopControl.Location = new Point(12, 12);
            pnlTopControl.Name = "pnlTopControl";
            pnlTopControl.Size = new Size(1405, 101);
            pnlTopControl.TabIndex = 3;
            // 
            // pnlTitle
            // 
            pnlTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTitle.BackColor = Color.LemonChiffon;
            pnlTitle.BorderStyle = BorderStyle.FixedSingle;
            pnlTitle.Controls.Add(lblTitle2);
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Location = new Point(10, 9);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1383, 80);
            pnlTitle.TabIndex = 0;
            // 
            // lblTitle2
            // 
            lblTitle2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle2.AutoSize = true;
            lblTitle2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle2.Location = new Point(3, 1);
            lblTitle2.Name = "lblTitle2";
            lblTitle2.Size = new Size(267, 38);
            lblTitle2.TabIndex = 1;
            lblTitle2.Text = "Login/Initialization";
            lblTitle2.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle2.Visible = false;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(3, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(267, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Login/Initialization";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            pnlContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContent.BorderStyle = BorderStyle.FixedSingle;
            pnlContent.Controls.Add(pnlRightContent);
            pnlContent.Controls.Add(pnlLeftMenu);
            pnlContent.Location = new Point(12, 120);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1405, 648);
            pnlContent.TabIndex = 4;
            // 
            // pnlRightContent
            // 
            pnlRightContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlRightContent.BorderStyle = BorderStyle.FixedSingle;
            pnlRightContent.Location = new Point(247, 12);
            pnlRightContent.Name = "pnlRightContent";
            pnlRightContent.Size = new Size(1145, 622);
            pnlRightContent.TabIndex = 1;
            // 
            // pnlLeftMenu
            // 
            pnlLeftMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlLeftMenu.BorderStyle = BorderStyle.FixedSingle;
            pnlLeftMenu.Controls.Add(picAccount);
            pnlLeftMenu.Controls.Add(btnQuitApp);
            pnlLeftMenu.Controls.Add(btnRestartApp);
            pnlLeftMenu.Controls.Add(btnStandardSewing);
            pnlLeftMenu.Controls.Add(btn02);
            pnlLeftMenu.Controls.Add(btn01);
            pnlLeftMenu.Controls.Add(btnNewArticleAndOrder);
            pnlLeftMenu.Controls.Add(btnNewSeam);
            pnlLeftMenu.Controls.Add(btnReprint);
            pnlLeftMenu.Controls.Add(btnNewNeedle);
            pnlLeftMenu.Controls.Add(btnChangeStitchLength);
            pnlLeftMenu.Controls.Add(btnWindingBobbin);
            pnlLeftMenu.Controls.Add(btnChangeBobbin);
            pnlLeftMenu.Controls.Add(btnChangeNeedleThread);
            pnlLeftMenu.Location = new Point(11, 12);
            pnlLeftMenu.Name = "pnlLeftMenu";
            pnlLeftMenu.Size = new Size(225, 621);
            pnlLeftMenu.TabIndex = 0;
            // 
            // picAccount
            // 
            picAccount.Image = (Image)resources.GetObject("picAccount.Image");
            picAccount.Location = new Point(8, 8);
            picAccount.Name = "picAccount";
            picAccount.Size = new Size(207, 223);
            picAccount.TabIndex = 12;
            picAccount.TabStop = false;
            picAccount.Visible = false;
            // 
            // btnQuitApp
            // 
            btnQuitApp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnQuitApp.Location = new Point(15, 559);
            btnQuitApp.Name = "btnQuitApp";
            btnQuitApp.Size = new Size(192, 50);
            btnQuitApp.TabIndex = 11;
            btnQuitApp.UseVisualStyleBackColor = true;
            btnQuitApp.Click += btnQuitApp_Click;
            // 
            // btnRestartApp
            // 
            btnRestartApp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRestartApp.Location = new Point(15, 506);
            btnRestartApp.Name = "btnRestartApp";
            btnRestartApp.Size = new Size(192, 50);
            btnRestartApp.TabIndex = 10;
            btnRestartApp.UseVisualStyleBackColor = true;
            btnRestartApp.Click += btnRestartApp_Click;
            // 
            // btnStandardSewing
            // 
            btnStandardSewing.Location = new Point(15, 454);
            btnStandardSewing.Name = "btnStandardSewing";
            btnStandardSewing.Size = new Size(192, 50);
            btnStandardSewing.TabIndex = 9;
            btnStandardSewing.UseVisualStyleBackColor = true;
            // 
            // btn02
            // 
            btn02.Location = new Point(113, 453);
            btn02.Name = "btn02";
            btn02.Size = new Size(94, 29);
            btn02.TabIndex = 8;
            btn02.UseVisualStyleBackColor = true;
            btn02.Visible = false;
            // 
            // btn01
            // 
            btn01.Location = new Point(15, 438);
            btn01.Name = "btn01";
            btn01.Size = new Size(94, 29);
            btn01.TabIndex = 8;
            btn01.UseVisualStyleBackColor = true;
            btn01.Visible = false;
            // 
            // btnNewArticleAndOrder
            // 
            btnNewArticleAndOrder.Location = new Point(15, 400);
            btnNewArticleAndOrder.Name = "btnNewArticleAndOrder";
            btnNewArticleAndOrder.Size = new Size(192, 50);
            btnNewArticleAndOrder.TabIndex = 7;
            btnNewArticleAndOrder.UseVisualStyleBackColor = true;
            btnNewArticleAndOrder.Click += btnNewArticleAndOrder_Click;
            // 
            // btnNewSeam
            // 
            btnNewSeam.Location = new Point(15, 347);
            btnNewSeam.Name = "btnNewSeam";
            btnNewSeam.Size = new Size(192, 50);
            btnNewSeam.TabIndex = 6;
            btnNewSeam.UseVisualStyleBackColor = true;
            btnNewSeam.Visible = false;
            // 
            // btnReprint
            // 
            btnReprint.Location = new Point(15, 346);
            btnReprint.Name = "btnReprint";
            btnReprint.Size = new Size(192, 50);
            btnReprint.TabIndex = 5;
            btnReprint.UseVisualStyleBackColor = true;
            // 
            // btnNewNeedle
            // 
            btnNewNeedle.Location = new Point(15, 293);
            btnNewNeedle.Name = "btnNewNeedle";
            btnNewNeedle.Size = new Size(192, 50);
            btnNewNeedle.TabIndex = 4;
            btnNewNeedle.UseVisualStyleBackColor = true;
            // 
            // btnChangeStitchLength
            // 
            btnChangeStitchLength.Location = new Point(15, 292);
            btnChangeStitchLength.Name = "btnChangeStitchLength";
            btnChangeStitchLength.Size = new Size(192, 50);
            btnChangeStitchLength.TabIndex = 3;
            btnChangeStitchLength.UseVisualStyleBackColor = true;
            btnChangeStitchLength.Visible = false;
            // 
            // btnWindingBobbin
            // 
            btnWindingBobbin.Location = new Point(15, 238);
            btnWindingBobbin.Name = "btnWindingBobbin";
            btnWindingBobbin.Size = new Size(192, 50);
            btnWindingBobbin.TabIndex = 2;
            btnWindingBobbin.UseVisualStyleBackColor = true;
            // 
            // btnChangeBobbin
            // 
            btnChangeBobbin.Location = new Point(15, 65);
            btnChangeBobbin.Name = "btnChangeBobbin";
            btnChangeBobbin.Size = new Size(192, 50);
            btnChangeBobbin.TabIndex = 1;
            btnChangeBobbin.UseVisualStyleBackColor = true;
            btnChangeBobbin.Visible = false;
            // 
            // btnChangeNeedleThread
            // 
            btnChangeNeedleThread.Location = new Point(15, 11);
            btnChangeNeedleThread.Name = "btnChangeNeedleThread";
            btnChangeNeedleThread.Size = new Size(192, 50);
            btnChangeNeedleThread.TabIndex = 0;
            btnChangeNeedleThread.UseVisualStyleBackColor = true;
            btnChangeNeedleThread.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1429, 792);
            Controls.Add(pnlContent);
            Controls.Add(pnlTopControl);
            Controls.Add(statusTripBottom);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "en";
            Text = "BiasysControl";
            WindowState = FormWindowState.Maximized;
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ResizeEnd += MainForm_ResizeEnd;
            SizeChanged += MainForm_SizeChanged;
            KeyDown += MainForm_KeyDown;
            MouseMove += MainForm_MouseMove;
            statusTripBottom.ResumeLayout(false);
            statusTripBottom.PerformLayout();
            pnlTopControl.ResumeLayout(false);
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlLeftMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusTripBottom;
        private ToolStripStatusLabel lblComputer;
        private ToolStripStatusLabel lblUserLogin;
        private ToolStripStatusLabel lblSeparator1;
        private ToolStripStatusLabel lblSeparator3;
        private ToolStripStatusLabel lblCurrentTime;
        private ImageList imgLeftMenuList;
        private ToolStripStatusLabel lblLicense;
        public System.Windows.Forms.Timer timerNow;
        private ToolStripStatusLabel lblSpaceStatus;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Panel pnlTopControl;
        private Panel pnlContent;
        private Panel pnlLeftMenu;
        private Panel pnlTitle;
        private Button btnChangeStitchLength;
        private Button btnWindingBobbin;
        private Button btnChangeBobbin;
        private Button btnChangeNeedleThread;
        private Button btnNewArticleAndOrder;
        private Button btnNewSeam;
        private Button btnReprint;
        private Button btnNewNeedle;
        private Button btn01;
        private Button btn02;
        private Button btnStandardSewing;
        public Label lblTitle;
        public Button btnQuitApp;
        public Button btnRestartApp;
        public Panel pnlRightContent;
        public Label lblTitle2;
        public PictureBox picAccount;
    }
}