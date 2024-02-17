
namespace Clean.Win.Apps
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
            mainMenu = new System.Windows.Forms.MenuStrip();
            mnuMasterData = new System.Windows.Forms.ToolStripMenuItem();
            mnuArticle = new System.Windows.Forms.ToolStripMenuItem();
            mnuThread = new System.Windows.Forms.ToolStripMenuItem();
            mnuPart = new System.Windows.Forms.ToolStripMenuItem();
            mnuSupplier = new System.Windows.Forms.ToolStripMenuItem();
            mnuGoodsIncomming = new System.Windows.Forms.ToolStripMenuItem();
            mnuStockThreads = new System.Windows.Forms.ToolStripMenuItem();
            mnuStockParts = new System.Windows.Forms.ToolStripMenuItem();
            mnuOthers = new System.Windows.Forms.ToolStripMenuItem();
            mnuUserManagement = new System.Windows.Forms.ToolStripMenuItem();
            mnuUserGroups = new System.Windows.Forms.ToolStripMenuItem();
            mnuMachine = new System.Windows.Forms.ToolStripMenuItem();
            mnuBobbins = new System.Windows.Forms.ToolStripMenuItem();
            mnuComputerConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            mnuProtocols = new System.Windows.Forms.ToolStripMenuItem();
            mnuProductionData = new System.Windows.Forms.ToolStripMenuItem();
            mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            mnuLogInformation = new System.Windows.Forms.ToolStripMenuItem();
            mnuBackupDatabase = new System.Windows.Forms.ToolStripMenuItem();
            releaseNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mnuLicense = new System.Windows.Forms.ToolStripMenuItem();
            mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            mnuAppLanguage = new System.Windows.Forms.ToolStripMenuItem();
            statusTripBottom = new System.Windows.Forms.StatusStrip();
            lblComputer = new System.Windows.Forms.ToolStripStatusLabel();
            lblSeparator1 = new System.Windows.Forms.ToolStripStatusLabel();
            lblUserLogin = new System.Windows.Forms.ToolStripStatusLabel();
            lblSeparator3 = new System.Windows.Forms.ToolStripStatusLabel();
            lblLicense = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            lblSpaceStatus = new System.Windows.Forms.ToolStripStatusLabel();
            lblCurrentTime = new System.Windows.Forms.ToolStripStatusLabel();
            mainSplitContainer = new System.Windows.Forms.SplitContainer();
            pnlLeftMenu = new System.Windows.Forms.Panel();
            treeLeftMenu = new System.Windows.Forms.TreeView();
            imgLeftMenuList = new System.Windows.Forms.ImageList(components);
            pnlLeftMenuTitle = new System.Windows.Forms.Panel();
            lblLeftPanelTitle = new System.Windows.Forms.Label();
            btnBobbin = new System.Windows.Forms.Button();
            btnReport = new System.Windows.Forms.Button();
            btnMenu = new System.Windows.Forms.Button();
            btnLanguage = new System.Windows.Forms.Button();
            btnLogin = new System.Windows.Forms.Button();
            btnOthers = new System.Windows.Forms.Button();
            tblLayoutContent = new System.Windows.Forms.TableLayoutPanel();
            pnlContentTitle = new System.Windows.Forms.Panel();
            lblContentTitle = new System.Windows.Forms.Label();
            pnlContent = new System.Windows.Forms.Panel();
            timerNow = new System.Windows.Forms.Timer(components);
            mainMenu.SuspendLayout();
            statusTripBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).BeginInit();
            mainSplitContainer.Panel1.SuspendLayout();
            mainSplitContainer.Panel2.SuspendLayout();
            mainSplitContainer.SuspendLayout();
            pnlLeftMenu.SuspendLayout();
            pnlLeftMenuTitle.SuspendLayout();
            tblLayoutContent.SuspendLayout();
            pnlContentTitle.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuMasterData, mnuGoodsIncomming, mnuOthers, mnuProtocols, mnuReports, mnuHelp, mnuExit, mnuAppLanguage });
            mainMenu.Location = new System.Drawing.Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            mainMenu.Size = new System.Drawing.Size(1429, 30);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "menuStrip1";
            // 
            // mnuMasterData
            // 
            mnuMasterData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuArticle, mnuThread, mnuPart, mnuSupplier });
            mnuMasterData.Name = "mnuMasterData";
            mnuMasterData.Size = new System.Drawing.Size(104, 24);
            mnuMasterData.Text = "Master Data";
            // 
            // mnuArticle
            // 
            mnuArticle.Name = "mnuArticle";
            mnuArticle.Size = new System.Drawing.Size(224, 26);
            mnuArticle.Text = "Article";
            mnuArticle.Click += mnuArticle_Click;
            // 
            // mnuThread
            // 
            mnuThread.Name = "mnuThread";
            mnuThread.Size = new System.Drawing.Size(224, 26);
            mnuThread.Text = "Threads";
            mnuThread.Click += mnuThread_Click;
            // 
            // mnuPart
            // 
            mnuPart.Name = "mnuPart";
            mnuPart.Size = new System.Drawing.Size(224, 26);
            mnuPart.Text = "Parts";
            mnuPart.Click += mnuPart_Click;
            // 
            // mnuSupplier
            // 
            mnuSupplier.Name = "mnuSupplier";
            mnuSupplier.Size = new System.Drawing.Size(224, 26);
            mnuSupplier.Text = "Suppliers";
            mnuSupplier.Click += mnuSupplier_Click;
            // 
            // mnuGoodsIncomming
            // 
            mnuGoodsIncomming.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuStockThreads, mnuStockParts });
            mnuGoodsIncomming.Name = "mnuGoodsIncomming";
            mnuGoodsIncomming.Size = new System.Drawing.Size(145, 24);
            mnuGoodsIncomming.Text = "Goods Incomming";
            // 
            // mnuStockThreads
            // 
            mnuStockThreads.Name = "mnuStockThreads";
            mnuStockThreads.Size = new System.Drawing.Size(224, 26);
            mnuStockThreads.Text = "Stock Threads";
            // 
            // mnuStockParts
            // 
            mnuStockParts.Name = "mnuStockParts";
            mnuStockParts.Size = new System.Drawing.Size(224, 26);
            mnuStockParts.Text = "Stock Parts";
            // 
            // mnuOthers
            // 
            mnuOthers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuUserManagement, mnuUserGroups, mnuMachine, mnuBobbins, mnuComputerConfiguration });
            mnuOthers.Name = "mnuOthers";
            mnuOthers.Size = new System.Drawing.Size(66, 24);
            mnuOthers.Text = "Others";
            // 
            // mnuUserManagement
            // 
            mnuUserManagement.Name = "mnuUserManagement";
            mnuUserManagement.Size = new System.Drawing.Size(253, 26);
            mnuUserManagement.Text = "User Management";
            // 
            // mnuUserGroups
            // 
            mnuUserGroups.Name = "mnuUserGroups";
            mnuUserGroups.Size = new System.Drawing.Size(253, 26);
            mnuUserGroups.Text = "User Groups";
            // 
            // mnuMachine
            // 
            mnuMachine.Name = "mnuMachine";
            mnuMachine.Size = new System.Drawing.Size(253, 26);
            mnuMachine.Text = "Machine";
            // 
            // mnuBobbins
            // 
            mnuBobbins.Name = "mnuBobbins";
            mnuBobbins.Size = new System.Drawing.Size(253, 26);
            mnuBobbins.Text = "Bobbins";
            // 
            // mnuComputerConfiguration
            // 
            mnuComputerConfiguration.Name = "mnuComputerConfiguration";
            mnuComputerConfiguration.Size = new System.Drawing.Size(253, 26);
            mnuComputerConfiguration.Text = "Computer Configuration";
            // 
            // mnuProtocols
            // 
            mnuProtocols.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuProductionData });
            mnuProtocols.Name = "mnuProtocols";
            mnuProtocols.Size = new System.Drawing.Size(85, 24);
            mnuProtocols.Text = "Protocols";
            // 
            // mnuProductionData
            // 
            mnuProductionData.Name = "mnuProductionData";
            mnuProductionData.Size = new System.Drawing.Size(224, 26);
            mnuProductionData.Text = "Production Data";
            // 
            // mnuReports
            // 
            mnuReports.Name = "mnuReports";
            mnuReports.Size = new System.Drawing.Size(68, 24);
            mnuReports.Text = "Report";
            // 
            // mnuHelp
            // 
            mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuLogInformation, mnuBackupDatabase, releaseNotesToolStripMenuItem, mnuLicense, mnuAbout });
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new System.Drawing.Size(55, 24);
            mnuHelp.Text = "Help";
            // 
            // mnuLogInformation
            // 
            mnuLogInformation.Image = (System.Drawing.Image)resources.GetObject("mnuLogInformation.Image");
            mnuLogInformation.Name = "mnuLogInformation";
            mnuLogInformation.Size = new System.Drawing.Size(222, 26);
            mnuLogInformation.Text = "Log information";
            mnuLogInformation.Click += mnuLogInformation_Click;
            // 
            // mnuBackupDatabase
            // 
            mnuBackupDatabase.Image = (System.Drawing.Image)resources.GetObject("mnuBackupDatabase.Image");
            mnuBackupDatabase.Name = "mnuBackupDatabase";
            mnuBackupDatabase.Size = new System.Drawing.Size(222, 26);
            mnuBackupDatabase.Text = "Backup database";
            mnuBackupDatabase.Click += mnuBackupDatabase_Click;
            // 
            // releaseNotesToolStripMenuItem
            // 
            releaseNotesToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("releaseNotesToolStripMenuItem.Image");
            releaseNotesToolStripMenuItem.Name = "releaseNotesToolStripMenuItem";
            releaseNotesToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            releaseNotesToolStripMenuItem.Text = "Release notes";
            // 
            // mnuLicense
            // 
            mnuLicense.Image = (System.Drawing.Image)resources.GetObject("mnuLicense.Image");
            mnuLicense.Name = "mnuLicense";
            mnuLicense.Size = new System.Drawing.Size(222, 26);
            mnuLicense.Text = "License information";
            mnuLicense.Click += mnuLicense_Click;
            // 
            // mnuAbout
            // 
            mnuAbout.Image = (System.Drawing.Image)resources.GetObject("mnuAbout.Image");
            mnuAbout.Name = "mnuAbout";
            mnuAbout.Size = new System.Drawing.Size(222, 26);
            mnuAbout.Text = "About";
            mnuAbout.Click += mnuAbout_Click;
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new System.Drawing.Size(47, 24);
            mnuExit.Text = "Exit";
            mnuExit.Click += mnuExit_Click;
            // 
            // mnuAppLanguage
            // 
            mnuAppLanguage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            mnuAppLanguage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mnuAppLanguage.Name = "mnuAppLanguage";
            mnuAppLanguage.Size = new System.Drawing.Size(43, 24);
            mnuAppLanguage.Text = "EN";
            mnuAppLanguage.Click += mnuAppLanguage_Click;
            // 
            // statusTripBottom
            // 
            statusTripBottom.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusTripBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblComputer, lblSeparator1, lblUserLogin, lblSeparator3, lblLicense, toolStripStatusLabel1, lblSpaceStatus, lblCurrentTime });
            statusTripBottom.Location = new System.Drawing.Point(0, 766);
            statusTripBottom.Name = "statusTripBottom";
            statusTripBottom.Size = new System.Drawing.Size(1429, 26);
            statusTripBottom.TabIndex = 2;
            statusTripBottom.Text = "statusStrip";
            // 
            // lblComputer
            // 
            lblComputer.Image = (System.Drawing.Image)resources.GetObject("lblComputer.Image");
            lblComputer.Name = "lblComputer";
            lblComputer.Size = new System.Drawing.Size(98, 20);
            lblComputer.Text = "Computer:";
            // 
            // lblSeparator1
            // 
            lblSeparator1.Name = "lblSeparator1";
            lblSeparator1.Size = new System.Drawing.Size(13, 20);
            lblSeparator1.Text = "|";
            // 
            // lblUserLogin
            // 
            lblUserLogin.Image = (System.Drawing.Image)resources.GetObject("lblUserLogin.Image");
            lblUserLogin.Name = "lblUserLogin";
            lblUserLogin.Size = new System.Drawing.Size(78, 20);
            lblUserLogin.Text = "User id:";
            // 
            // lblSeparator3
            // 
            lblSeparator3.Name = "lblSeparator3";
            lblSeparator3.Size = new System.Drawing.Size(13, 20);
            lblSeparator3.Text = "|";
            // 
            // lblLicense
            // 
            lblLicense.Image = (System.Drawing.Image)resources.GetObject("lblLicense.Image");
            lblLicense.Name = "lblLicense";
            lblLicense.Size = new System.Drawing.Size(84, 20);
            lblLicense.Text = "License: ";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(13, 20);
            toolStripStatusLabel1.Text = "|";
            // 
            // lblSpaceStatus
            // 
            lblSpaceStatus.Name = "lblSpaceStatus";
            lblSpaceStatus.Size = new System.Drawing.Size(0, 20);
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.Image = (System.Drawing.Image)resources.GetObject("lblCurrentTime.Image");
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblCurrentTime.Size = new System.Drawing.Size(63, 20);
            lblCurrentTime.Text = "Now:";
            // 
            // mainSplitContainer
            // 
            mainSplitContainer.Cursor = System.Windows.Forms.Cursors.VSplit;
            mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            mainSplitContainer.Location = new System.Drawing.Point(0, 30);
            mainSplitContainer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            mainSplitContainer.Panel1.Controls.Add(pnlLeftMenu);
            mainSplitContainer.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            // 
            // mainSplitContainer.Panel2
            // 
            mainSplitContainer.Panel2.Controls.Add(tblLayoutContent);
            mainSplitContainer.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            mainSplitContainer.Size = new System.Drawing.Size(1429, 736);
            mainSplitContainer.SplitterDistance = 220;
            mainSplitContainer.SplitterWidth = 5;
            mainSplitContainer.TabIndex = 3;
            // 
            // pnlLeftMenu
            // 
            pnlLeftMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlLeftMenu.Controls.Add(treeLeftMenu);
            pnlLeftMenu.Controls.Add(pnlLeftMenuTitle);
            pnlLeftMenu.Controls.Add(btnBobbin);
            pnlLeftMenu.Controls.Add(btnReport);
            pnlLeftMenu.Controls.Add(btnMenu);
            pnlLeftMenu.Controls.Add(btnLanguage);
            pnlLeftMenu.Controls.Add(btnLogin);
            pnlLeftMenu.Controls.Add(btnOthers);
            pnlLeftMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlLeftMenu.Location = new System.Drawing.Point(0, 0);
            pnlLeftMenu.Name = "pnlLeftMenu";
            pnlLeftMenu.Size = new System.Drawing.Size(220, 736);
            pnlLeftMenu.TabIndex = 0;
            // 
            // treeLeftMenu
            // 
            treeLeftMenu.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            treeLeftMenu.ImageIndex = 0;
            treeLeftMenu.ImageList = imgLeftMenuList;
            treeLeftMenu.Location = new System.Drawing.Point(5, 251);
            treeLeftMenu.Name = "treeLeftMenu";
            treeLeftMenu.PathSeparator = "";
            treeLeftMenu.SelectedImageIndex = 0;
            treeLeftMenu.ShowLines = false;
            treeLeftMenu.Size = new System.Drawing.Size(206, 325);
            treeLeftMenu.TabIndex = 0;
            treeLeftMenu.Visible = false;
            // 
            // imgLeftMenuList
            // 
            imgLeftMenuList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imgLeftMenuList.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imgLeftMenuList.ImageStream");
            imgLeftMenuList.TransparentColor = System.Drawing.Color.Transparent;
            imgLeftMenuList.Images.SetKeyName(0, "10.BMP");
            // 
            // pnlLeftMenuTitle
            // 
            pnlLeftMenuTitle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlLeftMenuTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            pnlLeftMenuTitle.Controls.Add(lblLeftPanelTitle);
            pnlLeftMenuTitle.Location = new System.Drawing.Point(0, 0);
            pnlLeftMenuTitle.Name = "pnlLeftMenuTitle";
            pnlLeftMenuTitle.Size = new System.Drawing.Size(218, 35);
            pnlLeftMenuTitle.TabIndex = 8;
            // 
            // lblLeftPanelTitle
            // 
            lblLeftPanelTitle.AutoSize = true;
            lblLeftPanelTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblLeftPanelTitle.Location = new System.Drawing.Point(0, 8);
            lblLeftPanelTitle.Name = "lblLeftPanelTitle";
            lblLeftPanelTitle.Size = new System.Drawing.Size(0, 20);
            lblLeftPanelTitle.TabIndex = 0;
            lblLeftPanelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBobbin
            // 
            btnBobbin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnBobbin.Location = new System.Drawing.Point(5, 213);
            btnBobbin.Name = "btnBobbin";
            btnBobbin.Size = new System.Drawing.Size(208, 29);
            btnBobbin.TabIndex = 5;
            btnBobbin.Tag = "BOBBINS";
            btnBobbin.Text = "Bobbins";
            btnBobbin.UseVisualStyleBackColor = true;
            btnBobbin.Click += btnBobbin_Click;
            // 
            // btnReport
            // 
            btnReport.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnReport.Location = new System.Drawing.Point(5, 179);
            btnReport.Name = "btnReport";
            btnReport.Size = new System.Drawing.Size(208, 29);
            btnReport.TabIndex = 4;
            btnReport.Tag = "REPORT";
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnMenu
            // 
            btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnMenu.Location = new System.Drawing.Point(5, 144);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new System.Drawing.Size(208, 29);
            btnMenu.TabIndex = 3;
            btnMenu.Tag = "MENU";
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnLanguage
            // 
            btnLanguage.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnLanguage.Location = new System.Drawing.Point(5, 109);
            btnLanguage.Name = "btnLanguage";
            btnLanguage.Size = new System.Drawing.Size(208, 29);
            btnLanguage.TabIndex = 2;
            btnLanguage.Tag = "LANGUAGE";
            btnLanguage.Text = "Language";
            btnLanguage.UseVisualStyleBackColor = true;
            btnLanguage.Click += btnLanguage_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnLogin.Location = new System.Drawing.Point(5, 75);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(208, 29);
            btnLogin.TabIndex = 1;
            btnLogin.Tag = "LOGIN";
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnOthers
            // 
            btnOthers.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnOthers.Location = new System.Drawing.Point(5, 43);
            btnOthers.Name = "btnOthers";
            btnOthers.Size = new System.Drawing.Size(208, 29);
            btnOthers.TabIndex = 10;
            btnOthers.Tag = "OTHERS";
            btnOthers.Text = "Others";
            btnOthers.UseVisualStyleBackColor = true;
            btnOthers.Click += btnOthers_Click;
            // 
            // tblLayoutContent
            // 
            tblLayoutContent.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tblLayoutContent.ColumnCount = 1;
            tblLayoutContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tblLayoutContent.Controls.Add(pnlContentTitle, 0, 0);
            tblLayoutContent.Controls.Add(pnlContent, 0, 1);
            tblLayoutContent.Dock = System.Windows.Forms.DockStyle.Fill;
            tblLayoutContent.Location = new System.Drawing.Point(0, 0);
            tblLayoutContent.Name = "tblLayoutContent";
            tblLayoutContent.RowCount = 2;
            tblLayoutContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            tblLayoutContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 99.99999F));
            tblLayoutContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tblLayoutContent.Size = new System.Drawing.Size(1204, 736);
            tblLayoutContent.TabIndex = 8;
            // 
            // pnlContentTitle
            // 
            pnlContentTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            pnlContentTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlContentTitle.Controls.Add(lblContentTitle);
            pnlContentTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContentTitle.Location = new System.Drawing.Point(4, 4);
            pnlContentTitle.Name = "pnlContentTitle";
            pnlContentTitle.Size = new System.Drawing.Size(1196, 30);
            pnlContentTitle.TabIndex = 7;
            // 
            // lblContentTitle
            // 
            lblContentTitle.AutoSize = true;
            lblContentTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblContentTitle.Location = new System.Drawing.Point(0, 4);
            lblContentTitle.Name = "lblContentTitle";
            lblContentTitle.Size = new System.Drawing.Size(0, 20);
            lblContentTitle.TabIndex = 1;
            lblContentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            pnlContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(4, 41);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new System.Drawing.Size(1196, 691);
            pnlContent.TabIndex = 0;
            // 
            // timerNow
            // 
            timerNow.Interval = 1000;
            timerNow.Tick += timerNow_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1429, 792);
            Controls.Add(mainSplitContainer);
            Controls.Add(mainMenu);
            Controls.Add(statusTripBottom);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = mainMenu;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Tag = "en";
            Text = "Main Form";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            MouseMove += MainForm_MouseMove;
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            statusTripBottom.ResumeLayout(false);
            statusTripBottom.PerformLayout();
            mainSplitContainer.Panel1.ResumeLayout(false);
            mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).EndInit();
            mainSplitContainer.ResumeLayout(false);
            pnlLeftMenu.ResumeLayout(false);
            pnlLeftMenuTitle.ResumeLayout(false);
            pnlLeftMenuTitle.PerformLayout();
            tblLayoutContent.ResumeLayout(false);
            pnlContentTitle.ResumeLayout(false);
            pnlContentTitle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem mnuGoodsIncomming;
        private System.Windows.Forms.ToolStripMenuItem mnuOthers;
        private System.Windows.Forms.ToolStripMenuItem mnuReports;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.StatusStrip statusTripBottom;
        private System.Windows.Forms.ToolStripStatusLabel lblComputer;
        private System.Windows.Forms.ToolStripStatusLabel lblUserLogin;
        private System.Windows.Forms.ToolStripStatusLabel lblSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel lblSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentTime;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.Button btnOthers;
        private System.Windows.Forms.Button btnBobbin;
        private System.Windows.Forms.ToolStripMenuItem mnuArticle;
        private System.Windows.Forms.ToolStripMenuItem mnuThread;
        private System.Windows.Forms.ToolStripMenuItem mnuPart;
        private System.Windows.Forms.ToolStripMenuItem mnuSupplier;
        private System.Windows.Forms.Label lblLeftPanelTitle;
        private System.Windows.Forms.TableLayoutPanel tblLayoutContent;
        private System.Windows.Forms.Label lblContentTitle;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        public System.Windows.Forms.TreeView treeLeftMenu;
        private System.Windows.Forms.ImageList imgLeftMenuList;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuLogInformation;
        public System.Windows.Forms.Panel pnlLeftMenuTitle;
        public System.Windows.Forms.Panel pnlContentTitle;
        private System.Windows.Forms.ToolStripMenuItem mnuStockThreads;
        private System.Windows.Forms.ToolStripMenuItem mnuStockParts;
        private System.Windows.Forms.ToolStripMenuItem mnuUserManagement;
        private System.Windows.Forms.ToolStripMenuItem mnuUserGroups;
        private System.Windows.Forms.ToolStripMenuItem mnuMachine;
        private System.Windows.Forms.ToolStripMenuItem mnuBobbins;
        private System.Windows.Forms.ToolStripMenuItem mnuComputerConfiguration;
        private System.Windows.Forms.ToolStripMenuItem mnuProtocols;
        private System.Windows.Forms.ToolStripMenuItem mnuProductionData;
        public System.Windows.Forms.Panel pnlLeftMenu;
        public System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.ToolStripMenuItem mnuBackupDatabase;
        private System.Windows.Forms.ToolStripStatusLabel lblLicense;
        private System.Windows.Forms.ToolStripMenuItem releaseNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLicense;
        public System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.Timer timerNow;
        private System.Windows.Forms.ToolStripStatusLabel lblSpaceStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripMenuItem mnuAppLanguage;
        public System.Windows.Forms.MenuStrip mainMenu;
        public System.Windows.Forms.ToolStripMenuItem mnuMasterData;
    }
}