using Clean.Win.AppConfigUI.UserControls;
using Clean.Win.AppConfigUI.UserControls.Automat;
using Clean.Win.AppConfigUI.UserControls.Computers;
using Clean.Win.Apps;
using Clean.Win.AppUI.UserControls;
using Clean.WinF.Applications.Features.Article.DTOs;
using Clean.WinF.Applications.Features.Automat.Interfaces;
using Clean.WinF.Applications.Features.Computer.DTOs;
//using Clean.Win.AppUI.UserControls.Users;
using Clean.WinF.Applications.Features.Language.DTOs;
using Clean.WinF.Applications.Features.Part.DTOs;
using Clean.WinF.Applications.Features.SerialNumber.DTOs;
using Clean.WinF.Applications.Features.SewingMachine.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clean.Win.AppUI.UICommon
{
    public delegate void FormClosed(Control _subControl);
    public sealed class UICommon
    {
        //implement singleton design pattern for this object
        public static UICommon instance = null;
        private static readonly object padlock = new object();

        public static UICommon Instance
        {
            get
            {
                lock (padlock)
                {

                    if (instance == null)
                    {
                        instance = new UICommon();
                    }
                    return instance;
                }
            }
        }

        public Control GetMainContentPanel(MainForm mainForm)
        {
            Control ret = null;
            if (mainForm != null)
            {
                var pnlMainContent = FindControlByName(mainForm, UIConstants.PANEL_CONTENT_NAME);
                if (pnlMainContent != null)
                {
                    if (pnlMainContent.Controls.Count > 0)
                        pnlMainContent.Controls.Clear();

                    ret = pnlMainContent;
                }
            }
            return ret;
        }

        //public void DisplayingThreadsInformation(MainForm mainForm)
        //{
        //    var pnlMainContent = this.clearControls(mainForm);
        //    if (pnlMainContent != null)
        //    {
        //        var uc = new ucThreads(mainForm._threadCommandServices, mainForm._threadQueryServices,
        //            mainForm._windingParamCommandServices);
        //        uc.Dock = DockStyle.Fill;
        //        pnlMainContent.Controls.Add(uc);
        //    }
        //}
        //public void DisplayingSupplierInformation(MainForm mainForm)
        //{
        //    var pnlMainContent = this.clearControls(mainForm);
        //    if (pnlMainContent != null)
        //    {
        //        var uc = new ucSuppliers(mainForm._supplierCommandServices, mainForm._supplierQueryServices);
        //        uc.Dock = DockStyle.Fill;
        //        pnlMainContent.Controls.Add(uc);
        //    }

        //}

        //public void DisplayingUserManagementInformation(MainForm mainForm)
        //{
        //    var pnlMainContent = this.clearControls(mainForm);
        //    if (pnlMainContent != null)
        //    {
        //        var uc = new ucUserManagement(mainForm._userCommandServices, mainForm._partQueryService);
        //        uc.Dock = DockStyle.Fill;
        //        pnlMainContent.Controls.Add(uc);
        //    }
        //}

        //public void DisplayingUserGroupInformation(MainForm mainForm)
        //{
        //    var pnlMainContent = this.clearControls(mainForm);
        //    if (pnlMainContent != null)
        //    {
        //        var uc = new ucUserGroups(mainForm._partCommandService, mainForm._partQueryService);
        //        uc.Dock = DockStyle.Fill;
        //        pnlMainContent.Controls.Add(uc);
        //    }

        //}

        //public void DisplayingComputerConfigurationInformation(MainForm mainForm)
        //{
        //    var pnlMainContent = this.clearControls(mainForm);
        //    if (pnlMainContent != null)
        //    {
        //        var uc = new ucComputerConfiguration(mainForm._partCommandService, mainForm._partQueryService);
        //        uc.Dock = DockStyle.Fill;
        //        pnlMainContent.Controls.Add(uc);
        //    }
        //}

        public void DisplayDBConfigurationInformation(MainForm mainForm)
        {
            var pnlMainContent = GetMainContentPanel(mainForm);
            if (pnlMainContent != null)
            {
                var uc = new ucDBInformation(mainForm);
                uc.Dock = DockStyle.Fill;
                pnlMainContent.Controls.Add(uc);
            }
        }

        public void DisplayBobbinsConfiguration(MainForm mainForm)
        {
            var pnlMainContent = GetMainContentPanel(mainForm);
            if (pnlMainContent != null)
            {
                var uc = new ucBobbinConfig(mainForm);
                uc.Dock = DockStyle.Fill;
                pnlMainContent.Controls.Add(uc);
            }
        }

        public void DisplayComputerConfiguration(MainForm mainForm, ComputerDto dto)
        {
            var pnlMainContent = GetMainContentPanel(mainForm);
            if (pnlMainContent != null)
            {
                var uc = new ucComputerConfig(mainForm._computerCommandServices, mainForm._systemConfigurationCommandServices, mainForm._languageQueryService, dto);
                uc.Dock = DockStyle.Fill;
                pnlMainContent.Controls.Add(uc);
            }
        }

        public void DisplayPermissionConfiguration(MainForm mainForm)
        {
            //MessageBox.Show($"DisplayPermissionConfiguration");
            var pnlMainContent = GetMainContentPanel(mainForm);
            if (pnlMainContent != null)
            {
                var uc = new ucPermissionConfig(mainForm._permissionCommandServices);
                uc.Dock = DockStyle.Fill;
                pnlMainContent.Controls.Add(uc);
            }
        }

        public void DisplayWindingParamConfiguration(MainForm mainForm)
        {
            //MessageBox.Show($"DisplayWindingParamConfiguration");
            var pnlMainContent = GetMainContentPanel(mainForm);
            if (pnlMainContent != null)
            {
                var uc = new ucWindingParamConfig(mainForm._windingParamCommandServices);
                uc.Dock = DockStyle.Fill;
                pnlMainContent.Controls.Add(uc);
            }
        }

        public void DisplayUserConfiguration(MainForm mainForm)
        {
            //MessageBox.Show($"DisplayUserConfiguration");
            var pnlMainContent = GetMainContentPanel(mainForm);
            if (pnlMainContent != null)
            {
                var uc = new ucUserConfig(mainForm._userCommandServices);
                uc.Dock = DockStyle.Fill;
                pnlMainContent.Controls.Add(uc);
            }
        }

        public void DisplaySewingMachineConfiguration(MainForm mainForm, List<SewingMachineConfigurationDto> dtos)
        {
            var pnlMainContent = GetMainContentPanel(mainForm);
            if (pnlMainContent != null)
            {
                var uc = new ucMachineConfig(
                    mainForm._sewingMachineConfigurationCommandServices,
                    mainForm._clipSensorActivationCommandServices,
                    dtos,
                    mainForm._portCommandServices,
                    mainForm._deviceTypeCommandServices,
                    mainForm._deviceRoutingeCommandServices,
                    mainForm._connectedDeviceCommandServices);
                uc.Dock = DockStyle.Fill;
                pnlMainContent.Controls.Add(uc);
            }
        }
        public void DisplaySerialNumberConfiguration(MainForm mainForm, SerialNumberDto dto)
        {
            var pnlMainContent = GetMainContentPanel(mainForm);
            if (pnlMainContent != null)
            {
                var uc = new ucSerialNumberConfig(
                    mainForm._serialNumberCommandServices,
                    mainForm._counterTypeCommandServices,
                    mainForm._resetTypeCommandServices,
                    dto);
                uc.Dock = DockStyle.Fill;
                pnlMainContent.Controls.Add(uc);
            }
        }

        //public void DisplayingPartInformation(MainForm mainForm, MenuEnums mainMenu)
        //{
        //    var pnlMainContent = this.clearControls(mainForm);
        //    if (pnlMainContent != null)
        //    {
        //        var uc = new ucParts(mainForm._partCommandService, mainForm._partQueryService);
        //        uc.Dock = DockStyle.Fill;
        //        pnlMainContent.Controls.Add(uc);
        //    }
        //}


        public void DisplayingAutomatInformation(MainForm mainForm, AutomatDto automatDto)
        {
            if (mainForm != null)
            {
                var pnlMainContent = FindControlByName(mainForm, UIConstants.PANEL_CONTENT_NAME);
                if (pnlMainContent != null)
                {
                    if (pnlMainContent.Controls.Count > 0)
                        pnlMainContent.Controls.Clear();


                    var ucAutomat = GetUserAutomatControl(mainForm._automatCommandServices, mainForm._automatQueryServices, automatDto);
                    ucAutomat.Dock = DockStyle.Fill;
                    pnlMainContent.Controls.Add(ucAutomat);
                }
            }
        }
        private ucAutomat GetUserAutomatControl(
        IAutomatCommandServices _automatCommandServices,
        IAutomatQueryServices _automatQueryServices,
        AutomatDto automatDto)
        {
            var userAutomatControl = new ucAutomat(_automatCommandServices, _automatQueryServices, automatDto);
            return userAutomatControl;
        }

        //This function will help to find any existing controls(label, button, textbox, panel...) in main form
        public Control FindControlByName(Control container, string name)
        {
            if (container.Name == name)
            {
                return container;
            }

            foreach (Control control in container.Controls)
            {
                Control foundControl = FindControlByName(control, name);
                if (foundControl != null)
                {
                    return foundControl;
                }
            }

            return null;
        }

        public Form FindMainForm(Control subControl)
        {
            Form mainForm = null;
            if (subControl != null)
            {
                mainForm = subControl.FindForm() as Form;
            }
            return mainForm;
        }

        #region Menu handling
        public void DisplayLeftMenuFormating(MainForm mainForm, Button btnComputerAutomat)
        {

            switch (btnComputerAutomat.Tag.ToString())
            {
                case nameof(MainMenuEnums.Computer):
                    {
                        mainForm.dgrComputer.Visible = true;
                        mainForm.dgrMachine.Visible = true;
                        FormatDisplayingLeftMenu(mainForm);
                        break;
                    }
                case nameof(MainMenuEnums.Automat):
                    {
                        mainForm.dgrAutomatConfig.Visible = true;
                        mainForm.dgrSerialNumber.Visible = true;
                        mainForm.dgrProjectSpecific.Visible = true;
                        mainForm.dgrStockThread.Visible = true;
                        mainForm.dgrLabelDef.Visible = true;
                        mainForm.dgrPrinterScript.Visible = true;
                        FormatDisplayingLeftMenu(mainForm);
                        break;
                    }
            }
        }

        public void FormatDisplayingLeftMenu(MainForm mainForm)
        {
            var marginValue = 2;
            mainForm.dgrComputer.Left = mainForm.tblComputer.Left;
            mainForm.dgrComputer.Top = mainForm.tblComputer.Top + mainForm.tblComputer.Height + marginValue;
            mainForm.dgrComputer.Width = mainForm.tblComputer.Width;

            if (mainForm.dgrComputer.Visible)
            {
                mainForm.tblSewingMachine.Top = mainForm.dgrComputer.Top + mainForm.dgrComputer.Height + marginValue;
                mainForm.dgrMachine.Top = mainForm.tblSewingMachine.Top + mainForm.tblSewingMachine.Height + marginValue;
            }
            else
            {
                mainForm.tblSewingMachine.Top = mainForm.tblComputer.Top + mainForm.tblComputer.Height + marginValue;
                mainForm.dgrMachine.Top = mainForm.tblSewingMachine.Top + mainForm.tblSewingMachine.Height + marginValue;
            }

            if (mainForm.dgrMachine.Visible)
            {
                mainForm.tblAutomatConfig.Top = mainForm.dgrMachine.Top + mainForm.dgrMachine.Height + marginValue;
                mainForm.dgrAutomatConfig.Top = mainForm.tblAutomatConfig.Top + mainForm.tblAutomatConfig.Height + marginValue;
            }
            else
            {
                mainForm.tblAutomatConfig.Top = mainForm.tblSewingMachine.Top + mainForm.tblSewingMachine.Height + marginValue;
                mainForm.dgrAutomatConfig.Top = mainForm.tblAutomatConfig.Top + mainForm.tblAutomatConfig.Height + marginValue;
            }

            if (mainForm.dgrAutomatConfig.Visible)
            {
                mainForm.tblSerialNumber.Top = mainForm.dgrAutomatConfig.Top + mainForm.dgrAutomatConfig.Height + marginValue;
                mainForm.dgrSerialNumber.Top = mainForm.tblSerialNumber.Top + mainForm.tblSerialNumber.Height + marginValue;
            }
            else
            {
                mainForm.tblSerialNumber.Top = mainForm.tblAutomatConfig.Top + mainForm.tblAutomatConfig.Height + marginValue;
                mainForm.dgrSerialNumber.Top = mainForm.tblSerialNumber.Top + mainForm.tblSerialNumber.Height + marginValue;
            }

            if (mainForm.dgrSerialNumber.Visible)
            {
                mainForm.tblProjectSpecific.Top = mainForm.dgrSerialNumber.Top + mainForm.dgrSerialNumber.Height + marginValue;
                mainForm.dgrProjectSpecific.Top = mainForm.tblProjectSpecific.Top + mainForm.tblProjectSpecific.Height + marginValue;
            }
            else
            {
                mainForm.tblProjectSpecific.Top = mainForm.tblSerialNumber.Top + mainForm.tblSerialNumber.Height + marginValue;
                mainForm.dgrProjectSpecific.Top = mainForm.tblProjectSpecific.Top + mainForm.tblProjectSpecific.Height + marginValue;
            }

            if (mainForm.dgrProjectSpecific.Visible)
            {
                mainForm.tblStockThread.Top = mainForm.dgrProjectSpecific.Top + mainForm.dgrProjectSpecific.Height + marginValue;
                mainForm.dgrStockThread.Top = mainForm.tblStockThread.Top + mainForm.tblStockThread.Height + marginValue;
            }
            else
            {
                mainForm.tblStockThread.Top = mainForm.tblProjectSpecific.Top + mainForm.tblProjectSpecific.Height + marginValue;
                mainForm.dgrStockThread.Top = mainForm.tblStockThread.Top + mainForm.tblStockThread.Height + marginValue;
            }

            if (mainForm.dgrStockThread.Visible)
            {
                mainForm.tblLabelDef.Top = mainForm.dgrStockThread.Top + mainForm.dgrStockThread.Height + marginValue;
                mainForm.dgrLabelDef.Top = mainForm.tblLabelDef.Top + mainForm.tblLabelDef.Height + marginValue;
            }
            else
            {
                mainForm.tblLabelDef.Top = mainForm.tblStockThread.Top + mainForm.tblStockThread.Height + marginValue;
                mainForm.dgrLabelDef.Top = mainForm.tblLabelDef.Top + mainForm.tblLabelDef.Height + marginValue;
            }

            if (mainForm.dgrLabelDef.Visible)
            {
                mainForm.tblPrinterScript.Top = mainForm.dgrLabelDef.Top + mainForm.dgrLabelDef.Height + marginValue;
                mainForm.dgrPrinterScript.Top = mainForm.tblPrinterScript.Top + mainForm.tblPrinterScript.Height + marginValue;
            }
            else
            {
                mainForm.tblPrinterScript.Top = mainForm.tblLabelDef.Top + mainForm.tblLabelDef.Height + marginValue;
                mainForm.dgrPrinterScript.Top = mainForm.tblPrinterScript.Top + mainForm.tblPrinterScript.Height + marginValue;
            }
        }

        public void ActivateMainTopMenu(MainForm mainform, bool isActive)
        {
            mainform.pnlLeftMenu.Visible = isActive;
            mainform.grpDatabase.Enabled = isActive;
            mainform.grpMiscellaneous.Enabled = isActive;
            mainform.grpMenuItems.Enabled = isActive;

            mainform.btnComputer.Enabled = isActive;
            mainform.btnDBRefresh.Enabled = isActive;
            mainform.btnAutomat.Enabled = isActive;

            mainform.btnInfo.Visible = isActive;
            mainform.btnBobbin.Visible = isActive;
            mainform.btnCommonSetting.Visible = isActive;
            mainform.btnDefValue.Visible = isActive;
            mainform.btnLanguage.Visible = isActive;
            mainform.btnPermission.Visible = isActive;
            mainform.btnScannedPart.Visible = isActive;
            mainform.btnUser.Visible = isActive;
            mainform.btnWinding.Visible = isActive;
            if (mainform.pnlMainContent.Controls.Count > 0)
            {
                mainform.pnlMainContent.Controls.Clear();
                mainform.pnlMainContent.Controls.Add(mainform.lblMainContent);
            }

        }

        //public async void LoadLeftMenuData(MainForm mainForm, Button btnLeftMenu, TreeView leftTreeView, ImageList imgLeftMenu)
        //{
        //    if (mainForm is null) return;

        //    if (btnLeftMenu.Tag.ToString().Equals(nameof(LeftMenuEnums.LANGUAGE)))
        //    {
        //        //for language
        //        DisplayLanguageLeftMenu(mainForm, leftTreeView, imgLeftMenu, true);
        //    }

        //    //main menu
        //    if (btnLeftMenu.Tag.ToString().Equals(nameof(LeftMenuEnums.MENU)))
        //    {
        //        var leftDatasoucre = new List<MenuDto>();
        //        var allMenus = await mainForm._menuQueryService.GetAllMenus(mainForm.Tag.ToString());
        //        if (allMenus != null && allMenus.Count > 0)
        //        {
        //            if (imgLeftMenu != null && imgLeftMenu.Images.Count > 0)
        //            {
        //                imgLeftMenu.Images.Clear();
        //            }

        //            var mainMenus = allMenus.FindAll(p => p.ParentName == "0");
        //            foreach (var submenu in mainMenus)
        //            {
        //                imgLeftMenu.Images.Add(Image.FromFile(submenu.IconImg));
        //            }
        //            if (mainMenus != null && mainMenus.Count > 0)
        //            {
        //                imgLeftMenu.Images.Add(Image.FromFile(mainMenus[0].IconImg));
        //                for (var i = 0; i < mainMenus.Count; i++)
        //                {
        //                    var menu = mainMenus[i];

        //                    var subMenus = allMenus.ToList().FindAll(p => p.ParentName == menu.Tag).ToList();
        //                    if (subMenus != null && subMenus.Count > 0)
        //                    {
        //                        var myTreeNodeArray = new TreeNode[subMenus.Count];
        //                        var countIndex = 0;
        //                        foreach (var subMenu in subMenus)
        //                        {
        //                            // Add the Order tree node to the array.                                    
        //                            myTreeNodeArray[countIndex] = new TreeNode(subMenu.Name, 0, 0);
        //                            myTreeNodeArray[countIndex].Tag = subMenu.Tag;
        //                            countIndex++;
        //                        }

        //                        // Add a main root tree node.
        //                        var mainNode = new TreeNode(menu.Name, 0, 0, myTreeNodeArray);
        //                        mainNode.Tag = menu.Tag;
        //                        leftTreeView.Nodes.Add(mainNode);
        //                    }
        //                    else
        //                    {
        //                        TreeNode mainNode = new TreeNode(menu.Name, 0, 0);
        //                        mainNode.Tag = menu.Tag;
        //                        leftTreeView.Nodes.Add(mainNode);
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    leftTreeView.ExpandAll();

        //    //leftTreeView.AfterSelect += LeftTreeView_AfterSelect;
        //    if (btnLeftMenu.Tag.ToString().Equals(nameof(LeftMenuEnums.MENU)))
        //    {
        //        //Opent article as default
        //        var existedArticle = FindControlByName(mainForm.pnlContent, UIConstants.UC_ARTICLE_NAME);
        //        if (existedArticle is null)
        //            leftTreeView.SelectedNode = GetSelectedNodeAsDefault(leftTreeView, nameof(MenuEnums.Articles));
        //    }

        //    if (btnLeftMenu.Tag.ToString().Equals(nameof(LeftMenuEnums.LANGUAGE)))
        //    {
        //        leftTreeView.SelectedNode = GetSelectedNodeAsDefault(leftTreeView, "English");
        //    }
        //    //set the height for treeview
        //    int expandedNodes = leftTreeView.GetNodeCount(true);
        //    int newHeight = expandedNodes * leftTreeView.ItemHeight;
        //    leftTreeView.Height = newHeight + 25;
        //}

        //private async void DisplayLanguageLeftMenu(MainForm mainForm, TreeView leftTreeView, ImageList imgLeftMenu, bool isNewNode)
        //{
        //    var leftLanguageDatasource = new List<LanguageDto>();
        //    var allLangs = await mainForm._languageQueryService.GetAllLanguages(mainForm.Tag.ToString().Trim());
        //    if (allLangs != null && allLangs.Count > 0)
        //    {
        //        if (isNewNode)
        //        {
        //            int idexImage = 0;
        //            foreach (var lang in allLangs)
        //            {
        //                imgLeftMenu.Images.Add(Image.FromFile(lang.IconImg));
        //                TreeNode mainNode = new TreeNode(lang.Lang, idexImage, idexImage);
        //                mainNode.Tag = lang.Code;
        //                leftTreeView.Nodes.Add(mainNode);
        //                idexImage++;
        //            }
        //        }
        //        else
        //        {
        //            foreach (TreeNode node in leftTreeView.Nodes)
        //            {
        //                var textTranslation = allLangs.ToList().FirstOrDefault(p => p.Code.Equals(node.Tag.ToString().Trim()));
        //                node.Text = textTranslation.Lang;
        //            }
        //        }
        //    }
        //}

        //private void LeftTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        //{
        //    if (sender != null)
        //    {
        //        var treeView = sender as System.Windows.Forms.TreeView;
        //        var mainForm = FindMainForm(treeView) as MainForm;
        //        var lblLeftMenuTitle = FindControlByName(mainForm.pnlLeftMenuTitle, "lblLeftPanelTitle") as Label;
        //        var lblContentTitle = FindControlByName(mainForm.pnlContentTitle, "lblContentTitle") as Label;
        //        if (treeView != null && treeView.SelectedNode != null)
        //        {
        //            // Get the selected node
        //            TreeNode selectedNode = treeView.SelectedNode;

        //            // Access the properties of the selected node                
        //            string nodeText = selectedNode.Text;
        //            string subMenuName = selectedNode.Tag.ToString();
        //            lblLeftMenuTitle.Text = nodeText;
        //            lblLeftMenuTitle.Left = (mainForm.pnlLeftMenuTitle.Width / 2) - (lblLeftMenuTitle.Width / 2);
        //            lblContentTitle.Text = nodeText;
        //            lblContentTitle.Left = (mainForm.pnlContentTitle.Width / 2) - (lblContentTitle.Width / 2);
        //            switch (subMenuName)
        //            {
        //                case nameof(MenuEnums.Articles):
        //                    {
        //                        var existedArticle = FindControlByName(mainForm.pnlContent, UIConstants.UC_ARTICLE_NAME);
        //                        if (existedArticle is null)
        //                        {
        //                            DisplayingArticleInformation(mainForm, MenuEnums.Articles);
        //                        }

        //                        break;
        //                    }
        //                case nameof(MenuEnums.Bobbins):
        //                    {
        //                        var existedBobbin = FindControlByName(mainForm.pnlContent, UIConstants.UC_BOBBIN_NAME);
        //                        if (existedBobbin is null)
        //                            DisplayingBobbinsInformation(mainForm);
        //                        break;
        //                    }
        //                case nameof(MenuEnums.ComputerConfigurations):
        //                    {
        //                        var existedComp = FindControlByName(mainForm.pnlContent, UIConstants.UC_COMPUTER_NAME);
        //                        if (existedComp is null)
        //                            DisplayingComputerConfigurationInformation(mainForm);
        //                        break;
        //                    }
        //                case nameof(MenuEnums.GoodsIncomming):
        //                    {
        //                        break;
        //                    }
        //                case nameof(MenuEnums.Machines):
        //                    {
        //                        var existedMachine = FindControlByName(mainForm.pnlContent, UIConstants.UC_MACHINE_NAME);
        //                        if (existedMachine is null)
        //                            DisplayingSewingMachineInformation(mainForm);
        //                        break;
        //                    }
        //                case nameof(MenuEnums.MasterData):
        //                    {
        //                        break;
        //                    }
        //                case nameof(MenuEnums.UserManagements):
        //                    {
        //                        var existedUser = FindControlByName(mainForm.pnlContent, UIConstants.UC_USER_MANAGEMENT_NAME);
        //                        if (existedUser is null)
        //                            DisplayingUserManagementInformation(mainForm);
        //                        break;
        //                    }
        //                case nameof(MenuEnums.Parts):
        //                    {
        //                        var existedPart = FindControlByName(mainForm.pnlContent, UIConstants.UC_PART_NAME);
        //                        if (existedPart is null)
        //                            DisplayingPartInformation(mainForm, MenuEnums.Parts);
        //                        break;
        //                    }
        //                case nameof(MenuEnums.Orders):
        //                    {
        //                        break;
        //                    }
        //                case nameof(MenuEnums.ProductionData):
        //                    {
        //                        break;
        //                    }
        //                case nameof(MenuEnums.Protocols):
        //                    {
        //                        break;
        //                    }
        //                case nameof(MenuEnums.Threads):
        //                    {
        //                        var existedThread = FindControlByName(mainForm.pnlContent, UIConstants.UC_THREAD_NAME);
        //                        if (existedThread is null)
        //                            DisplayingThreadsInformation(mainForm);
        //                        break;
        //                    }
        //                case nameof(MenuEnums.Suppliers):
        //                    {
        //                        var existedSupp = FindControlByName(mainForm.pnlContent, UIConstants.UC_SUPPLIER_NAME);
        //                        if (existedSupp is null)
        //                            DisplayingSupplierInformation(mainForm);
        //                        break;
        //                    }
        //                case nameof(MenuEnums.UserGroups):
        //                    {
        //                        var existedUserGroup = FindControlByName(mainForm.pnlContent, UIConstants.UC_USER_GROUP_NAME);
        //                        if (existedUserGroup is null)
        //                            DisplayingUserGroupInformation(mainForm);
        //                        break;
        //                    }
        //                case nameof(MenuEnums.Reports):
        //                    {
        //                        break;
        //                    }
        //                //for language
        //                case "en":
        //                case "de":
        //                case "cn":
        //                case "vn":
        //                    {
        //                        mainForm.Tag = subMenuName;
        //                        ProcessMultipleLanguages(mainForm, mainForm, UIConstants.Main_GUI, subMenuName);
        //                        DisplayLanguageLeftMenu(mainForm, treeView, null, false);
        //                        break;
        //                    }
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("No node is currently selected.");
        //        }
        //    }
        //}

        //private TreeNode GetSelectedNodeAsDefault(TreeView leftTreeViewMenu, string findNode)
        //{
        //    TreeNode existingNode = null;

        //    foreach (TreeNode node in leftTreeViewMenu.Nodes)
        //    {
        //        for (var i = 0; i < node.Nodes.Count; i++)
        //        {
        //            var subnode = node.Nodes[i];
        //            if (findNode.Equals(subnode.Text.Trim()) || findNode.Equals(subnode.Tag.ToString().Trim()))
        //            {
        //                existingNode = subnode;
        //                break;
        //            }
        //        }
        //        if (existingNode != null)
        //            break;
        //    }

        //    return existingNode;
        //}

        #endregion

        #region private functions

        //this functions will help to create new user control instance
        //private ucCommonGrid GetCommonGridControl(string gridName, string[] gridHeaderNames, string[] gridHeaderTexts)
        //{
        //    var commonGrid = new ucCommonGrid();
        //    commonGrid.gridDataHeaderNameColumns = gridHeaderNames;
        //    commonGrid.gridDataHeaderTextColumns = gridHeaderTexts;
        //    commonGrid.Tag = string.Concat("ucCommon", gridName);
        //    commonGrid.dgrMainControl.Tag = gridName;
        //    commonGrid.isLoadData = true;
        //    return commonGrid;
        //}

        //private ucParts GetUserPartControl(IPartCommandServices cmdServices, IPartQueryServices queryServices, string gridName, string[] gridHeaderNames, string[] gridHeaderTexts)
        //{
        //    var userPartControl = new ucParts(cmdServices, queryServices);
        //    var commonGrid = GetCommonGridControl(gridName, gridHeaderNames, gridHeaderTexts);
        //    commonGrid.Dock = DockStyle.Fill;
        //    userPartControl.mainGridView.Controls.Add(commonGrid);
        //    return userPartControl;
        //}

        //private ucArticle GetUserArticleControl(
        //    IArticleCommandServices cmdServices,
        //    IArticleQueryServices queryServices,
        //    IAutomatCommandServices automatCmdServices,
        //    IAutomatQueryServices automatQueryServices,
        //    IPartCommandServices partCmdServices,
        //    IPartQueryServices partQueryServices,
        //    IThreadCommandServices threadCmdServices,
        //    IThreadQueryServices threadQueryServices,
        //    string gridName,
        //    string[] gridHeaderNames,
        //    string[] gridHeaderTexts)
        //{
        //    var userArticleControl = new ucArticle(
        //        cmdServices,
        //        queryServices,
        //        automatCmdServices,
        //        automatQueryServices,
        //        partCmdServices,
        //        partQueryServices,
        //        threadCmdServices,
        //        threadQueryServices
        //        );
        //    //var commonGrid = GetCommonGridControl(gridName, gridHeaderNames, gridHeaderTexts);
        //    //commonGrid.Dock = DockStyle.Fill;
        //    //userArticleControl.pnlArticle.Controls.Add(commonGrid);
        //    return userArticleControl;
        //}

        private void GetLeftMenuButtonPositionAsDefault(Panel pnlLeftMenu)
        {
            Button btnOthers = FindControlByName(pnlLeftMenu, "btnOthers") as Button;
            btnOthers.Top = 42;
            Button btnLogin = FindControlByName(pnlLeftMenu, "btnLogin") as Button;
            btnLogin.Top = 75;
            Button btnLanguage = FindControlByName(pnlLeftMenu, "btnLanguage") as Button;
            btnLanguage.Top = 110;
            Button btnMenu = FindControlByName(pnlLeftMenu, "btnMenu") as Button;
            btnMenu.Top = 144;
            Button btnReport = FindControlByName(pnlLeftMenu, "btnReport") as Button;
            btnReport.Top = 179;
            Button btnBobbin = FindControlByName(pnlLeftMenu, "btnBobbin") as Button;
            btnBobbin.Top = 214;
        }

        private bool CheckPartDataChanges(IList<PartDto> currSources, IList<PartDto> backupSources)
        {
            bool result = false;
            //check 2 these arrays is match or not?
            if (currSources != null && backupSources != null)
            {
                foreach (var part in currSources)
                {
                    var existedPart = backupSources.ToList().FindAll(p => p.Code.Equals(part.Code) && p.Name.Equals(part.Name));
                    if (existedPart is null || existedPart.Count == 0)
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }

        public async void ProcessMultipleLanguages(MainForm mainForm, Control subControl, string codeGroupGUI, string codeLanguage)
        {
            Cursor.Current = Cursors.WaitCursor;
            var currentCodeGUILangs = await mainForm._languageQueryService.GetAllLanguagesByCodeDefinition(mainForm.appID, codeGroupGUI, codeLanguage);
            var result = ProcessTextControlTranslations(subControl, (IList<AppCodeGUIDefinitionDto>)currentCodeGUILangs);
            Cursor.Current = Cursors.Default;
        }

        //Recursive functions
        private bool ProcessTextControlTranslations(Control control, IList<AppCodeGUIDefinitionDto> currentCodeGUILangs)
        {
            var result = true;
            try
            {
                if (control is MenuStrip || control is ToolStrip)
                {
                    foreach (ToolStripItem item in ((ToolStrip)control).Items)
                    {
                        var toolStripItem = currentCodeGUILangs.ToList().FirstOrDefault(p => p.CodeGUI.Equals(item.Name));
                        if (toolStripItem != null)
                            item.Text = toolStripItem.Description;
                    }
                }
                else if (control is StatusStrip)
                {
                    foreach (ToolStripItem item in ((StatusStrip)control).Items)
                    {
                        var statusItem = currentCodeGUILangs.ToList().FirstOrDefault(p => p.CodeGUI.Equals(item.Name));
                        if (statusItem != null)
                            item.Text = statusItem.Description;
                    }
                }
                else if (control is DataGridView)
                {
                    foreach (DataGridViewColumn col in ((DataGridView)control).Columns)
                    {
                        var colHeader = currentCodeGUILangs.ToList().FirstOrDefault(p => p.CodeGUI.Equals(col.Name));
                        if (colHeader != null)
                            col.HeaderText = colHeader.Description;
                    }
                }
                else if (control.HasChildren)
                {
                    foreach (Control subControl in control.Controls)
                    {
                        if (subControl.Name.StartsWith("uc"))
                        {
                            var mainForm = subControl.FindForm() as MainForm;
                            if (mainForm != null)
                            {
                                var ucCodeGUILangs = mainForm._languageQueryService.GetAllLanguagesByCodeDefinition(mainForm.appID, subControl.Tag.ToString(), mainForm.Tag.ToString()).Result;
                                ProcessTextControlTranslations(subControl, (IList<AppCodeGUIDefinitionDto>)ucCodeGUILangs);
                            }
                        }
                        else
                        {
                            ProcessTextControlTranslations(subControl, currentCodeGUILangs);
                        }
                    }
                }

                var controlItem = currentCodeGUILangs.ToList().FirstOrDefault(p => p.CodeGUI.Equals(control.Name));
                if (controlItem != null)
                    control.Text = controlItem.Description;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        #endregion
    }
}
