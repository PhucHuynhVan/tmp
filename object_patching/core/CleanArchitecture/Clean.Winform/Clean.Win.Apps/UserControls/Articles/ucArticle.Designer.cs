using System.Windows.Forms;

namespace Clean.Win.AppUI.UserControls
{
    partial class ucArticle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucArticle));
            lblArticle = new Label();
            txtArticleName = new TextBox();
            txtArticleCode = new TextBox();
            lblName = new Label();
            pnlUcArticleOperation = new Panel();
            lnkStockFabrics = new LinkLabel();
            lnkProductionData = new LinkLabel();
            btnImport = new Button();
            btnExport = new Button();
            btnInsert = new Button();
            btnSave = new Button();
            btnRejectChanges = new Button();
            pnlArticle = new Panel();
            drgArticle = new DataGridView();
            pnlProfile = new Panel();
            pnlContent = new Panel();
            ucSewingMachineParameter = new ucSewingMachineParameter();
            pnlProfileDetail = new Panel();
            ucStitchSection5 = new Articles.ucStitchSection5();
            ucStitchSection3 = new Articles.ucStitchSection3();
            ucStitchSection1 = new Articles.ucStitchSection1();
            ucSeamProfile = new ucSeamProfile();
            pnlTop = new Panel();
            grbSeam = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtMaxNumberOfStitchesPerSeam = new TextBox();
            txtNumberOfFreeSeam = new TextBox();
            pictureBox1 = new PictureBox();
            btnCustomSeam = new Button();
            btn1Critical4notches = new Button();
            btn1Critical2notches = new Button();
            btn1Critical0notches = new Button();
            ucThreadsPartsEndlabelInformation = new Articles.ucThreadsPartsEndlabelInformation();
            btnSeamProfile = new Button();
            btnSewingMachineParameter = new Button();
            btnMaterialMiscellaneousParameter = new Button();
            pnlDetail = new Panel();
            pnlUcArticleOperation.SuspendLayout();
            pnlArticle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)drgArticle).BeginInit();
            pnlProfile.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlProfileDetail.SuspendLayout();
            pnlTop.SuspendLayout();
            grbSeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlDetail.SuspendLayout();
            SuspendLayout();
            // 
            // lblArticle
            // 
            lblArticle.AutoSize = true;
            lblArticle.Location = new System.Drawing.Point(13, 27);
            lblArticle.Name = "lblArticle";
            lblArticle.Size = new System.Drawing.Size(94, 20);
            lblArticle.TabIndex = 3;
            lblArticle.Text = "Article Code:";
            // 
            // txtArticleName
            // 
            txtArticleName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtArticleName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtArticleName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtArticleName.Location = new System.Drawing.Point(480, 23);
            txtArticleName.Name = "txtArticleName";
            txtArticleName.Size = new System.Drawing.Size(374, 27);
            txtArticleName.TabIndex = 1;
            txtArticleName.Tag = "ArticleName";
            txtArticleName.KeyUp += onKeyUp;
            // 
            // txtArticleCode
            // 
            txtArticleCode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            txtArticleCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtArticleCode.Location = new System.Drawing.Point(114, 23);
            txtArticleCode.Name = "txtArticleCode";
            txtArticleCode.Size = new System.Drawing.Size(266, 27);
            txtArticleCode.TabIndex = 1;
            txtArticleCode.Tag = "ArticleCode";
            txtArticleCode.KeyUp += onKeyUp;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(400, 27);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(52, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // pnlUcArticleOperation
            // 
            pnlUcArticleOperation.BorderStyle = BorderStyle.FixedSingle;
            pnlUcArticleOperation.Controls.Add(lnkStockFabrics);
            pnlUcArticleOperation.Controls.Add(lnkProductionData);
            pnlUcArticleOperation.Controls.Add(btnImport);
            pnlUcArticleOperation.Controls.Add(btnExport);
            pnlUcArticleOperation.Controls.Add(btnInsert);
            pnlUcArticleOperation.Controls.Add(btnSave);
            pnlUcArticleOperation.Controls.Add(btnRejectChanges);
            pnlUcArticleOperation.Dock = DockStyle.Bottom;
            pnlUcArticleOperation.Location = new System.Drawing.Point(0, 1123);
            pnlUcArticleOperation.Name = "pnlUcArticleOperation";
            pnlUcArticleOperation.Size = new System.Drawing.Size(1499, 77);
            pnlUcArticleOperation.TabIndex = 2;
            // 
            // lnkStockFabrics
            // 
            lnkStockFabrics.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lnkStockFabrics.AutoSize = true;
            lnkStockFabrics.Location = new System.Drawing.Point(1400, 27);
            lnkStockFabrics.Name = "lnkStockFabrics";
            lnkStockFabrics.Size = new System.Drawing.Size(94, 20);
            lnkStockFabrics.TabIndex = 1;
            lnkStockFabrics.TabStop = true;
            lnkStockFabrics.Text = "Stock Fabrics";
            // 
            // lnkProductionData
            // 
            lnkProductionData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lnkProductionData.AutoSize = true;
            lnkProductionData.Location = new System.Drawing.Point(1377, 45);
            lnkProductionData.Name = "lnkProductionData";
            lnkProductionData.Size = new System.Drawing.Size(117, 20);
            lnkProductionData.TabIndex = 1;
            lnkProductionData.TabStop = true;
            lnkProductionData.Text = "Production Data";
            // 
            // btnImport
            // 
            btnImport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImport.Location = new System.Drawing.Point(1233, 11);
            btnImport.Name = "btnImport";
            btnImport.Size = new System.Drawing.Size(138, 51);
            btnImport.TabIndex = 0;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExport.Location = new System.Drawing.Point(1089, 11);
            btnExport.Name = "btnExport";
            btnExport.Size = new System.Drawing.Size(138, 51);
            btnExport.TabIndex = 0;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new System.Drawing.Point(299, 11);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new System.Drawing.Size(138, 51);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(155, 11);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(138, 51);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRejectChanges
            // 
            btnRejectChanges.Location = new System.Drawing.Point(11, 11);
            btnRejectChanges.Name = "btnRejectChanges";
            btnRejectChanges.Size = new System.Drawing.Size(138, 51);
            btnRejectChanges.TabIndex = 0;
            btnRejectChanges.Text = "Reject Changes";
            btnRejectChanges.UseVisualStyleBackColor = true;
            btnRejectChanges.Click += btnRejectChanges_Click;
            // 
            // pnlArticle
            // 
            pnlArticle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlArticle.Controls.Add(drgArticle);
            pnlArticle.Location = new System.Drawing.Point(5, 5);
            pnlArticle.Name = "pnlArticle";
            pnlArticle.Size = new System.Drawing.Size(1495, 291);
            pnlArticle.TabIndex = 3;
            // 
            // drgArticle
            // 
            drgArticle.AllowUserToAddRows = false;
            drgArticle.AllowUserToDeleteRows = false;
            drgArticle.AllowUserToOrderColumns = true;
            drgArticle.AllowUserToResizeColumns = false;
            drgArticle.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            drgArticle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            drgArticle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            drgArticle.DefaultCellStyle = dataGridViewCellStyle2;
            drgArticle.Dock = DockStyle.Fill;
            drgArticle.Location = new System.Drawing.Point(0, 0);
            drgArticle.Name = "drgArticle";
            drgArticle.RowHeadersWidth = 51;
            drgArticle.RowTemplate.Height = 29;
            drgArticle.SelectionMode = DataGridViewSelectionMode.CellSelect;
            drgArticle.Size = new System.Drawing.Size(1495, 291);
            drgArticle.TabIndex = 2;
            drgArticle.CellClick += drgArticle_CellClick;
            drgArticle.CellEndEdit += drgArticle_CellEndEdit;
            drgArticle.SelectionChanged += DataGridView_SelectionChanged;
            // 
            // pnlProfile
            // 
            pnlProfile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlProfile.BackColor = System.Drawing.Color.White;
            pnlProfile.BorderStyle = BorderStyle.Fixed3D;
            pnlProfile.Controls.Add(pnlContent);
            pnlProfile.Controls.Add(btnSeamProfile);
            pnlProfile.Controls.Add(btnSewingMachineParameter);
            pnlProfile.Controls.Add(btnMaterialMiscellaneousParameter);
            pnlProfile.Location = new System.Drawing.Point(5, 379);
            pnlProfile.Name = "pnlProfile";
            pnlProfile.Size = new System.Drawing.Size(1494, 740);
            pnlProfile.TabIndex = 4;
            // 
            // pnlContent
            // 
            pnlContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlContent.AutoScroll = true;
            pnlContent.Controls.Add(pnlProfileDetail);
            pnlContent.Controls.Add(ucSewingMachineParameter);
            pnlContent.Controls.Add(ucThreadsPartsEndlabelInformation);
            pnlContent.Location = new System.Drawing.Point(0, 31);
            pnlContent.Margin = new Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new System.Drawing.Size(1495, 705);
            pnlContent.TabIndex = 12;
            // 
            // ucSewingMachineParameter
            // 
            ucSewingMachineParameter.AutoSize = true;
            ucSewingMachineParameter.Dock = DockStyle.Fill;
            ucSewingMachineParameter.dto = null;
            ucSewingMachineParameter.Location = new System.Drawing.Point(0, 0);
            ucSewingMachineParameter.Name = "ucSewingMachineParameter";
            ucSewingMachineParameter.Size = new System.Drawing.Size(1495, 705);
            ucSewingMachineParameter.TabIndex = 10;
            ucSewingMachineParameter.Visible = false;
            // 
            // pnlProfileDetail
            // 
            pnlProfileDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlProfileDetail.AutoScroll = true;
            pnlProfileDetail.Controls.Add(ucStitchSection5);
            pnlProfileDetail.Controls.Add(ucStitchSection3);
            pnlProfileDetail.Controls.Add(ucStitchSection1);
            pnlProfileDetail.Controls.Add(ucSeamProfile);
            pnlProfileDetail.Controls.Add(pnlTop);
            pnlProfileDetail.Controls.Add(btnCustomSeam);
            pnlProfileDetail.Controls.Add(btn1Critical4notches);
            pnlProfileDetail.Controls.Add(btn1Critical2notches);
            pnlProfileDetail.Controls.Add(btn1Critical0notches);
            pnlProfileDetail.Location = new System.Drawing.Point(0, 0);
            pnlProfileDetail.Margin = new Padding(3, 4, 3, 4);
            pnlProfileDetail.Name = "pnlProfileDetail";
            pnlProfileDetail.Size = new System.Drawing.Size(1495, 705);
            pnlProfileDetail.TabIndex = 3;
            // 
            // ucStitchSection5
            // 
            ucStitchSection5.dto = null;
            ucStitchSection5.Location = new System.Drawing.Point(873, 176);
            ucStitchSection5.Margin = new Padding(3, 5, 3, 5);
            ucStitchSection5.Name = "ucStitchSection5";
            ucStitchSection5.Size = new System.Drawing.Size(590, 379);
            ucStitchSection5.TabIndex = 16;
            // 
            // ucStitchSection3
            // 
            ucStitchSection3.dto = null;
            ucStitchSection3.Location = new System.Drawing.Point(1008, 176);
            ucStitchSection3.Margin = new Padding(3, 5, 3, 5);
            ucStitchSection3.Name = "ucStitchSection3";
            ucStitchSection3.Size = new System.Drawing.Size(458, 379);
            ucStitchSection3.TabIndex = 15;
            // 
            // ucStitchSection1
            // 
            ucStitchSection1.dto = null;
            ucStitchSection1.Location = new System.Drawing.Point(1008, 176);
            ucStitchSection1.Margin = new Padding(3, 5, 3, 5);
            ucStitchSection1.Name = "ucStitchSection1";
            ucStitchSection1.Size = new System.Drawing.Size(401, 379);
            ucStitchSection1.TabIndex = 14;
            // 
            // ucSeamProfile
            // 
            ucSeamProfile.dto = null;
            ucSeamProfile.Location = new System.Drawing.Point(8, 176);
            ucSeamProfile.Name = "ucSeamProfile";
            ucSeamProfile.Size = new System.Drawing.Size(619, 520);
            ucSeamProfile.TabIndex = 13;
            // 
            // pnlTop
            // 
            pnlTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTop.BorderStyle = BorderStyle.FixedSingle;
            pnlTop.Controls.Add(grbSeam);
            pnlTop.Controls.Add(pictureBox1);
            pnlTop.Location = new System.Drawing.Point(5, 36);
            pnlTop.Margin = new Padding(3, 4, 3, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new System.Drawing.Size(1465, 133);
            pnlTop.TabIndex = 9;
            // 
            // grbSeam
            // 
            grbSeam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            grbSeam.Controls.Add(label2);
            grbSeam.Controls.Add(label1);
            grbSeam.Controls.Add(txtMaxNumberOfStitchesPerSeam);
            grbSeam.Controls.Add(txtNumberOfFreeSeam);
            grbSeam.Location = new System.Drawing.Point(1002, 13);
            grbSeam.Margin = new Padding(3, 4, 3, 4);
            grbSeam.Name = "grbSeam";
            grbSeam.Padding = new Padding(3, 4, 3, 4);
            grbSeam.Size = new System.Drawing.Size(453, 107);
            grbSeam.TabIndex = 9;
            grbSeam.TabStop = false;
            grbSeam.Text = "Number of free seams before starting SAB seam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(87, 71);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(234, 20);
            label2.TabIndex = 3;
            label2.Text = "Max. Number of stitches per seam";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(87, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(156, 20);
            label1.TabIndex = 2;
            label1.Text = "Number of free seams";
            // 
            // txtMaxNumberOfStitchesPerSeam
            // 
            txtMaxNumberOfStitchesPerSeam.Location = new System.Drawing.Point(23, 67);
            txtMaxNumberOfStitchesPerSeam.Margin = new Padding(3, 4, 3, 4);
            txtMaxNumberOfStitchesPerSeam.Name = "txtMaxNumberOfStitchesPerSeam";
            txtMaxNumberOfStitchesPerSeam.Size = new System.Drawing.Size(57, 27);
            txtMaxNumberOfStitchesPerSeam.TabIndex = 1;
            txtMaxNumberOfStitchesPerSeam.Text = "0";
            txtMaxNumberOfStitchesPerSeam.TextAlign = HorizontalAlignment.Right;
            txtMaxNumberOfStitchesPerSeam.KeyUp += onKeyUp;
            // 
            // txtNumberOfFreeSeam
            // 
            txtNumberOfFreeSeam.Location = new System.Drawing.Point(23, 27);
            txtNumberOfFreeSeam.Margin = new Padding(3, 4, 3, 4);
            txtNumberOfFreeSeam.Name = "txtNumberOfFreeSeam";
            txtNumberOfFreeSeam.Size = new System.Drawing.Size(57, 27);
            txtNumberOfFreeSeam.TabIndex = 0;
            txtNumberOfFreeSeam.Text = "0";
            txtNumberOfFreeSeam.TextAlign = HorizontalAlignment.Right;
            txtNumberOfFreeSeam.KeyUp += onKeyUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(11, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(91, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnCustomSeam
            // 
            btnCustomSeam.Location = new System.Drawing.Point(857, 0);
            btnCustomSeam.Margin = new Padding(3, 4, 3, 4);
            btnCustomSeam.Name = "btnCustomSeam";
            btnCustomSeam.Size = new System.Drawing.Size(233, 31);
            btnCustomSeam.TabIndex = 7;
            btnCustomSeam.Text = "Custom seam";
            btnCustomSeam.UseVisualStyleBackColor = true;
            btnCustomSeam.Click += btnCustomSeam_Click;
            // 
            // btn1Critical4notches
            // 
            btn1Critical4notches.Location = new System.Drawing.Point(571, 0);
            btn1Critical4notches.Margin = new Padding(3, 4, 3, 4);
            btn1Critical4notches.Name = "btn1Critical4notches";
            btn1Critical4notches.Size = new System.Drawing.Size(286, 31);
            btn1Critical4notches.TabIndex = 6;
            btn1Critical4notches.Text = "1 critical section with 4 notches";
            btn1Critical4notches.UseVisualStyleBackColor = true;
            btn1Critical4notches.Click += btn1Critical4notches_Click;
            // 
            // btn1Critical2notches
            // 
            btn1Critical2notches.Location = new System.Drawing.Point(286, 0);
            btn1Critical2notches.Margin = new Padding(3, 4, 3, 4);
            btn1Critical2notches.Name = "btn1Critical2notches";
            btn1Critical2notches.Size = new System.Drawing.Size(286, 31);
            btn1Critical2notches.TabIndex = 5;
            btn1Critical2notches.Text = "1 critical section with 2 notches";
            btn1Critical2notches.UseVisualStyleBackColor = true;
            btn1Critical2notches.Click += btn1Critical2notches_Click;
            // 
            // btn1Critical0notches
            // 
            btn1Critical0notches.Location = new System.Drawing.Point(0, 0);
            btn1Critical0notches.Margin = new Padding(3, 4, 3, 4);
            btn1Critical0notches.Name = "btn1Critical0notches";
            btn1Critical0notches.Size = new System.Drawing.Size(286, 31);
            btn1Critical0notches.TabIndex = 4;
            btn1Critical0notches.Text = "1 critical section without notches";
            btn1Critical0notches.UseVisualStyleBackColor = false;
            btn1Critical0notches.Click += btn1Critical0notches_Click;
            // 
            // ucThreadsPartsEndlabelInformation
            // 
            ucThreadsPartsEndlabelInformation.Dock = DockStyle.Fill;
            ucThreadsPartsEndlabelInformation.Location = new System.Drawing.Point(0, 0);
            ucThreadsPartsEndlabelInformation.Name = "ucThreadsPartsEndlabelInformation";
            ucThreadsPartsEndlabelInformation.Size = new System.Drawing.Size(1495, 705);
            ucThreadsPartsEndlabelInformation.TabIndex = 11;
            ucThreadsPartsEndlabelInformation.Visible = false;
            // 
            // btnSeamProfile
            // 
            btnSeamProfile.Location = new System.Drawing.Point(0, 0);
            btnSeamProfile.Margin = new Padding(3, 4, 3, 4);
            btnSeamProfile.Name = "btnSeamProfile";
            btnSeamProfile.Size = new System.Drawing.Size(286, 31);
            btnSeamProfile.TabIndex = 0;
            btnSeamProfile.Text = "Seam Profile";
            btnSeamProfile.UseVisualStyleBackColor = true;
            btnSeamProfile.Click += btnSeamProfile_Click;
            // 
            // btnSewingMachineParameter
            // 
            btnSewingMachineParameter.Location = new System.Drawing.Point(286, 0);
            btnSewingMachineParameter.Margin = new Padding(3, 4, 3, 4);
            btnSewingMachineParameter.Name = "btnSewingMachineParameter";
            btnSewingMachineParameter.Size = new System.Drawing.Size(286, 31);
            btnSewingMachineParameter.TabIndex = 1;
            btnSewingMachineParameter.Text = "Sewing Machine Parameter";
            btnSewingMachineParameter.UseVisualStyleBackColor = true;
            btnSewingMachineParameter.Click += btnSewingMachineParameter_Click;
            // 
            // btnMaterialMiscellaneousParameter
            // 
            btnMaterialMiscellaneousParameter.Location = new System.Drawing.Point(571, 0);
            btnMaterialMiscellaneousParameter.Margin = new Padding(3, 4, 3, 4);
            btnMaterialMiscellaneousParameter.Name = "btnMaterialMiscellaneousParameter";
            btnMaterialMiscellaneousParameter.Size = new System.Drawing.Size(286, 31);
            btnMaterialMiscellaneousParameter.TabIndex = 2;
            btnMaterialMiscellaneousParameter.Text = "Material / Miscellaneous Parameter";
            btnMaterialMiscellaneousParameter.UseVisualStyleBackColor = true;
            btnMaterialMiscellaneousParameter.Click += btnMaterialMiscellaneousParameter_Click;
            // 
            // pnlDetail
            // 
            pnlDetail.Controls.Add(lblArticle);
            pnlDetail.Controls.Add(txtArticleName);
            pnlDetail.Controls.Add(txtArticleCode);
            pnlDetail.Controls.Add(lblName);
            pnlDetail.Location = new System.Drawing.Point(0, 296);
            pnlDetail.Margin = new Padding(3, 4, 3, 4);
            pnlDetail.Name = "pnlDetail";
            pnlDetail.Size = new System.Drawing.Size(1495, 80);
            pnlDetail.TabIndex = 0;
            // 
            // ucArticle
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlDetail);
            Controls.Add(pnlArticle);
            Controls.Add(pnlProfile);
            Controls.Add(pnlUcArticleOperation);
            Name = "ucArticle";
            Size = new System.Drawing.Size(1499, 1200);
            Load += ucArticles_Load;
            pnlUcArticleOperation.ResumeLayout(false);
            pnlUcArticleOperation.PerformLayout();
            pnlArticle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)drgArticle).EndInit();
            pnlProfile.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlProfileDetail.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            grbSeam.ResumeLayout(false);
            grbSeam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlDetail.ResumeLayout(false);
            pnlDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Panel pnlUcArticleOperation;
        private LinkLabel lnkStockFabrics;
        private LinkLabel lnkProductionData;
        public Button btnImport;
        public Button btnExport;
        public Button btnInsert;
        public Button btnSave;
        public Button btnRejectChanges;
        private TextBox txtArticleName;
        private TextBox txtArticleCode;
        public Label lblName;
        public Panel pnlArticle;
        public Label lblArticle;
        public Panel pnlProfile;
        private Button btnSeamProfile;
        private Button btnSewingMachineParameter;
        private Button btnMaterialMiscellaneousParameter;
        private Panel pnlDetail;
        private Panel pnlProfileDetail;
        private Button btnCustomSeam;
        private Button btn1Critical4notches;
        private Button btn1Critical2notches;
        private Button btn1Critical0notches;
        private Panel pnlTop;
        private PictureBox pictureBox1;
        private GroupBox grbSeam;
        private TextBox txtMaxNumberOfStitchesPerSeam;
        private TextBox txtNumberOfFreeSeam;
        private Label label2;
        private Label label1;

        public Label lblStitchesLength { get; private set; }
        private TextBox textBox20;
        private TextBox textBox21;
        private TextBox textBox22;
        private TextBox textBox23;
        private TextBox textBox24;
        private TextBox textBox25;
        private TextBox textBox26;
        private TextBox textBox27;
        private TextBox textBox28;
        private Panel panel5;
        private Label label21;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private Panel panel3;
        private Label label16;
        private Panel pnlSection3;
        private Label label13;
        private Label label14;
        private Panel panel2;
        private Label label27;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private Label label29;
        private Label label30;
        private TextBox textBox36;
        private DataGridView drgArticle;
        private ucSeamProfile ucSeamProfile;
        private ucSewingMachineParameter ucSewingMachineParameter;
        private Panel pnlContent;
        private Articles.ucThreadsPartsEndlabelInformation ucThreadsPartsEndlabelInformation;
        private Label label4;
        private Articles.ucStitchSection5 ucStitchSection5;
        private Articles.ucStitchSection3 ucStitchSection3;
        private Articles.ucStitchSection1 ucStitchSection1;
    }
}
