using BiasysControl.UserControls;
using Clean.WinF.Applications.Features.Language.DTOs;
using Clean.WinF.Applications.Features.Menu.DTOs;
using Clean.WinF.Applications.Features.Part.DTOs;
using Clean.WinF.Applications.Features.UIProfile;
using Clean.WinF.Shared.Constants;

namespace BiasysControl.UICommon
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

        private Control clearControls(MainForm mainForm)
        {
            Control ret = null;
            if (mainForm != null)
            {
                var pnlMainContent = FindControlByName(mainForm, UIConstants.PANEL_RIGHT_CONTENT_NAME);
                if (pnlMainContent != null)
                {
                    if (pnlMainContent.Controls.Count > 0)
                        pnlMainContent.Controls.Clear();

                    ret = pnlMainContent;
                }
            }
            return ret;
        }

        public void DisplayInitialAppInformation(MainForm mainForm)
        {
            var pnlMainContent = this.clearControls(mainForm);
            if (pnlMainContent != null)
            {
                var uc = new ucAppInformation(mainForm);
                uc.Dock = DockStyle.Fill;
                pnlMainContent.Controls.Add(uc);
            }
        }

        public void DisplayAppContent(MainForm mainForm)
        {
            var pnlMainContent = this.clearControls(mainForm);
            if (pnlMainContent != null)
            {
                var uc = new ucContent(mainForm);
                uc.Dock = DockStyle.Fill;
                pnlMainContent.Controls.Add(uc);
            }
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
        public void DisplayLeftMenu(MainForm mainForm, Panel pnlLeftMenu, Button btnLeftMenu, TreeView treeLeftMenu, ImageList imgLeftMenus)
        {
            var marginValue = 6;
            treeLeftMenu.Visible = false;
            if (treeLeftMenu.Nodes.Count > 0)
                treeLeftMenu.Nodes.Clear();
            GetLeftMenuButtonPositionAsDefault(pnlLeftMenu);
            switch (btnLeftMenu.Tag.ToString())
            {
                case nameof(LeftMenuEnums.OTHERS):
                    {
                        break;
                    }
                case nameof(LeftMenuEnums.LOGIN):
                    {
                        break;
                    }
                case nameof(LeftMenuEnums.LANGUAGE):
                    {
                        LoadLeftMenuData(mainForm, btnLeftMenu, treeLeftMenu, imgLeftMenus);
                        treeLeftMenu.Visible = true;
                        treeLeftMenu.Top = btnLeftMenu.Top + btnLeftMenu.Height + marginValue;
                        Button btnMenu = FindControlByName(pnlLeftMenu, "btnMenu") as Button;
                        btnMenu.Top = treeLeftMenu.Top + treeLeftMenu.Height + marginValue;
                        Button btnReport = FindControlByName(pnlLeftMenu, "btnReport") as Button;
                        btnReport.Top = btnMenu.Top + btnMenu.Height + marginValue;
                        Button btnBobbin = FindControlByName(pnlLeftMenu, "btnBobbin") as Button;
                        btnBobbin.Top = btnReport.Top + btnReport.Height + marginValue;
                        break;
                    }
                case nameof(LeftMenuEnums.REPORT):
                    {
                        break;
                    }
                case nameof(LeftMenuEnums.MENU):
                    {
                        treeLeftMenu.Visible = true;
                        LoadLeftMenuData(mainForm, btnLeftMenu, treeLeftMenu, imgLeftMenus);
                        break;
                    }
                case nameof(LeftMenuEnums.BOBBINS):
                    {
                        break;
                    }
            }
        }

        public async void LoadLeftMenuData(MainForm mainForm, Button btnLeftMenu, TreeView leftTreeView, ImageList imgLeftMenu)
        {
            if (mainForm is null) return;

            if (btnLeftMenu.Tag.ToString().Equals(nameof(LeftMenuEnums.LANGUAGE)))
            {
                //for language
                DisplayLanguageLeftMenu(mainForm, leftTreeView, imgLeftMenu, true);
            }

            //main menu
            if (btnLeftMenu.Tag.ToString().Equals(nameof(LeftMenuEnums.MENU)))
            {
                var leftDatasoucre = new List<MenuDto>();
                var allMenus = await mainForm._menuQueryService.GetAllMenus(mainForm.Tag.ToString());
                if (allMenus != null && allMenus.Count > 0)
                {
                    if (imgLeftMenu != null && imgLeftMenu.Images.Count > 0)
                    {
                        imgLeftMenu.Images.Clear();
                    }

                    var mainMenus = allMenus.FindAll(p => p.ParentName == "0");
                    foreach (var submenu in mainMenus)
                    {
                        imgLeftMenu.Images.Add(Image.FromFile(submenu.IconImg));
                    }

                    if (mainMenus != null && mainMenus.Count > 0)
                    {
                        imgLeftMenu.Images.Add(Image.FromFile(mainMenus[0].IconImg));
                        for (var i = 0; i < mainMenus.Count; i++)
                        {
                            var menu = mainMenus[i];

                            var subMenus = allMenus.ToList().FindAll(p => p.ParentName == menu.Tag).ToList();
                            if (subMenus != null && subMenus.Count > 0)
                            {
                                subMenus = (List<MenuDto>)GetAvailableSubmenus(subMenus, UIUtility.uiProfiles);
                                // Add the Order tree node to the array.                              
                                var myTreeNodeArray = new TreeNode[subMenus.Count];
                                var countIndex = 0;
                                foreach (var subMenu in subMenus)
                                {
                                    myTreeNodeArray[countIndex] = new TreeNode(subMenu.Name, 0, 0);
                                    myTreeNodeArray[countIndex].Tag = subMenu.Tag;
                                    countIndex++;
                                }

                                // Add a main root tree node.
                                var mainNode = new TreeNode(menu.Name, 0, 0, myTreeNodeArray);
                                mainNode.Tag = menu.Tag;
                                leftTreeView.Nodes.Add(mainNode);
                            }
                            else
                            {
                                TreeNode mainNode = new TreeNode(menu.Name, 0, 0);
                                mainNode.Tag = menu.Tag;
                                leftTreeView.Nodes.Add(mainNode);
                            }
                        }
                    }
                }
            }

            leftTreeView.ExpandAll();

            leftTreeView.AfterSelect += LeftTreeView_AfterSelect;
            if (btnLeftMenu.Tag.ToString().Equals(nameof(LeftMenuEnums.MENU)))
            {
                //Opent article as default
                //var existedArticle = FindControlByName(mainForm.pnlContent, UIConstants.UC_ARTICLE_NAME);
                //if (existedArticle is null)
                //leftTreeView.SelectedNode = GetSelectedNodeAsDefault(leftTreeView, nameof(MenuEnums.Articles));
            }

            if (btnLeftMenu.Tag.ToString().Equals(nameof(LeftMenuEnums.LANGUAGE)))
            {
                leftTreeView.SelectedNode = GetSelectedNodeAsDefault(leftTreeView, "English");
            }
            //set the height for treeview
            int expandedNodes = leftTreeView.GetNodeCount(true);
            int newHeight = expandedNodes * leftTreeView.ItemHeight;
            leftTreeView.Height = newHeight + 25;
        }

        private IList<MenuDto> GetAvailableSubmenus(IList<MenuDto> subMenus, IList<UIProfileDto> availables)
        {
            IList<MenuDto> result = new List<MenuDto>();
            for (var i = subMenus.Count - 1; i >= 0; i--)
            {
                var menu = subMenus[i];
                var existedUIPermission = availables.ToArray().FirstOrDefault(p => p.MenuName.Equals(menu.Name) || p.MenuName.Equals(menu.Tag));
                if (existedUIPermission != null && existedUIPermission.IsPermission == false)
                {
                    subMenus.Remove(menu);
                }
            }
            result = subMenus;
            return result;
        }

        private async void DisplayLanguageLeftMenu(MainForm mainForm, TreeView leftTreeView, ImageList imgLeftMenu, bool isNewNode)
        {
            var leftLanguageDatasource = new List<LanguageDto>();
            var allLangs = await mainForm._languageQueryService.GetAllLanguages(mainForm.Tag.ToString().Trim());
            if (allLangs != null && allLangs.Count > 0)
            {
                if (isNewNode)
                {
                    int idexImage = 0;
                    foreach (var lang in allLangs)
                    {
                        imgLeftMenu.Images.Add(Image.FromFile(lang.IconImg));
                        TreeNode mainNode = new TreeNode(lang.Lang, idexImage, idexImage);
                        mainNode.Tag = lang.Code;
                        leftTreeView.Nodes.Add(mainNode);
                        idexImage++;
                    }
                }
                else
                {
                    foreach (TreeNode node in leftTreeView.Nodes)
                    {
                        var textTranslation = allLangs.ToList().FirstOrDefault(p => p.Code.Equals(node.Tag.ToString().Trim()));
                        node.Text = textTranslation.Lang;
                    }
                }
            }
        }

        private void LeftTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (sender != null)
            {
                var treeView = sender as System.Windows.Forms.TreeView;
                var mainForm = FindMainForm(treeView) as MainForm;
                //var lblLeftMenuTitle = FindControlByName(mainForm.pnlLeftMenuTitle, "lblLeftPanelTitle") as Label;
                //var lblContentTitle = FindControlByName(mainForm.pnlContentTitle, "lblContentTitle") as Label;
                if (treeView != null && treeView.SelectedNode != null)
                {
                    // Get the selected node
                    TreeNode selectedNode = treeView.SelectedNode;

                    // Access the properties of the selected node                
                    string nodeText = selectedNode.Text;
                    string subMenuName = selectedNode.Tag.ToString();
                    //lblLeftMenuTitle.Text = nodeText;
                    //lblLeftMenuTitle.Left = (mainForm.pnlLeftMenuTitle.Width / 2) - (lblLeftMenuTitle.Width / 2);
                    //lblContentTitle.Text = nodeText;
                    //lblContentTitle.Left = (mainForm.pnlContentTitle.Width / 2) - (lblContentTitle.Width / 2);
                    switch (subMenuName)
                    {
                        case nameof(MenuEnums.Articles):
                            {
                                //var existedArticle = FindControlByName(mainForm.pnlContent, UIConstants.UC_ARTICLE_NAME);
                                //if (existedArticle is null)                                
                                //    DisplayingArticleInformation(mainForm, MenuEnums.Articles);                               
                                break;
                            }
                        case nameof(MenuEnums.Bobbins):
                            {
                                //var existedBobbin = FindControlByName(mainForm.pnlContent, UIConstants.UC_BOBBIN_NAME);
                                //if (existedBobbin is null)
                                //    DisplayingBobbinsInformation(mainForm);
                                break;
                            }
                        case nameof(MenuEnums.ComputerConfigurations):
                            {

                                //var existedComp = FindControlByName(mainForm.pnlContent, UIConstants.UC_COMPUTER_NAME);
                                //if (existedComp is null)
                                //    DisplayingComputerConfigurationInformation(mainForm);
                                break;
                            }
                        case nameof(MenuEnums.GoodsIncomming):
                            {
                                break;
                            }
                        case nameof(MenuEnums.Machines):
                            {
                                //var existedMachine = FindControlByName(mainForm.pnlContent, UIConstants.UC_MACHINE_NAME);
                                //if (existedMachine is null)
                                //    DisplayingSewingMachineInformation(mainForm);
                                break;
                            }
                        case nameof(MenuEnums.MasterData):
                            {
                                break;
                            }
                        case nameof(MenuEnums.UserManagements):
                            {

                                //var existedUser = FindControlByName(mainForm.pnlContent, UIConstants.UC_USER_MANAGEMENT_NAME);
                                //if (existedUser is null)
                                //    DisplayingUserManagementInformation(mainForm);
                                break;
                            }
                        case nameof(MenuEnums.Parts):
                            {

                                //var existedPart = FindControlByName(mainForm.pnlContent, UIConstants.UC_PART_NAME);
                                //if (existedPart is null)
                                //    DisplayingPartInformation(mainForm, MenuEnums.Parts);
                                break;
                            }
                        case nameof(MenuEnums.Orders):
                            {
                                break;
                            }
                        case nameof(MenuEnums.ProductionData):
                            {
                                break;
                            }
                        case nameof(MenuEnums.Protocols):
                            {
                                break;
                            }
                        case nameof(MenuEnums.Threads):
                            {
                                //var existedThread = FindControlByName(mainForm.pnlContent, UIConstants.UC_THREAD_NAME);
                                //if (existedThread is null)
                                //    DisplayingThreadsInformation(mainForm);

                                break;
                            }
                        case nameof(MenuEnums.Suppliers):
                            {

                                //var existedSupp = FindControlByName(mainForm.pnlContent, UIConstants.UC_SUPPLIER_NAME);
                                //if (existedSupp is null)
                                //    DisplayingSupplierInformation(mainForm);
                                break;
                            }
                        case nameof(MenuEnums.UserGroups):
                            {

                                //var existedUserGroup = FindControlByName(mainForm.pnlContent, UIConstants.UC_USER_GROUP_NAME);
                                //if (existedUserGroup is null)
                                //    DisplayingUserGroupInformation(mainForm);
                                break;
                            }
                        case nameof(MenuEnums.Reports):
                            {
                                break;
                            }
                        //for language
                        case "en":
                        case "de":
                        case "cn":
                        case "vn":
                            {
                                mainForm.Tag = subMenuName;
                                ProcessMultipleLanguages(mainForm, mainForm, UIConstants.Main_GUI, subMenuName);
                                DisplayLanguageLeftMenu(mainForm, treeView, null, false);
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("No node is currently selected.");
                }
            }
        }

        private TreeNode GetSelectedNodeAsDefault(TreeView leftTreeViewMenu, string findNode)
        {
            TreeNode existingNode = null;

            foreach (TreeNode node in leftTreeViewMenu.Nodes)
            {
                for (var i = 0; i < node.Nodes.Count; i++)
                {
                    var subnode = node.Nodes[i];
                    if (findNode.Equals(subnode.Text.Trim()) || findNode.Equals(subnode.Tag.ToString().Trim()))
                    {
                        existingNode = subnode;
                        break;
                    }
                }
                if (existingNode != null)
                    break;
            }

            return existingNode;
        }

        #endregion

        #region private functions

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

        public UIProfileDto GetUIPermision(string featureName)
        {
            if (UIUtility.uiProfiles.Count > 0)
            {
                var existedUiPermission = UIUtility.uiProfiles.ToArray().FirstOrDefault(p => p.MenuName.Equals(featureName));
                if (existedUiPermission != null)
                {
                    return existedUiPermission;
                }
            }
            return null;
        }

        public bool IsImplementedUIPermision(Control control, string featureName)
        {
            var result = true;
            var existedUiPermission = GetUIPermision(featureName);
            if (existedUiPermission != null)
            {
                if (existedUiPermission.IsRead)
                {
                    if (control != null)
                    {
                        if (!existedUiPermission.IsInserted)
                            DisplayOperationButtons(control, false);
                        else
                            DisplayOperationButtons(control, true);
                    }
                }
                else
                {
                    UIUtility.AppShowMsg(CRUDPermissionMessageContants.EXECUTE_FUNC_MSG);
                    return false;
                }
            }
            return result;
        }

        private void DisplayOperationButtons(Control userControl, bool isVisible)
        {
            foreach (Control subControl in userControl.Controls)
            {
                var button = subControl as Button;
                if (button != null)
                {
                    button.Visible = isVisible;
                }
                else
                {
                    DisplayOperationButtons(subControl, isVisible);
                }
            }
        }

        public void ImplementNummericButton(TextBox lastFocused, Button currNummericButton)
        {
            if (lastFocused != null && currNummericButton != null)
            {
                var currentText = string.Empty;
                currentText = lastFocused.Text;

                if (currNummericButton.Name != "btnDel")
                {
                    currentText += currNummericButton.Text;
                    lastFocused.Text = currentText;
                }
                else
                {
                    if (lastFocused.Text.Trim().Length > 0)
                    {
                        var delText = lastFocused.Text.Trim().Substring(0, lastFocused.Text.Trim().Length - 1);
                        lastFocused.Text = delText;
                    }
                }
            }
        }
    }
}
