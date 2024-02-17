namespace Clean.Win.AppUI.UserControls
{
    partial class ucBobbinConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBobbinConfig));
            panel1 = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            btnRefresh = new System.Windows.Forms.ToolStripButton();
            btnSave = new System.Windows.Forms.ToolStripButton();
            dgrBobbins = new System.Windows.Forms.DataGridView();
            colBobbinNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colBobbinLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colThreadLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStitchCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMachine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrBobbins).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(lblTitle);
            panel1.Location = new System.Drawing.Point(3, 40);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1100, 38);
            panel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(3, 7);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(57, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Bobbin";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnRefresh, btnSave });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(1105, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnRefresh
            // 
            btnRefresh.Enabled = false;
            btnRefresh.Image = (System.Drawing.Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(82, 24);
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Image = (System.Drawing.Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(64, 24);
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // dgrBobbins
            // 
            dgrBobbins.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgrBobbins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrBobbins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colBobbinNo, colBobbinLabel, colThreadLabel, colStitchCount, colMachine, colID });
            dgrBobbins.Location = new System.Drawing.Point(3, 88);
            dgrBobbins.Name = "dgrBobbins";
            dgrBobbins.RowHeadersWidth = 51;
            dgrBobbins.RowTemplate.Height = 29;
            dgrBobbins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            dgrBobbins.Size = new System.Drawing.Size(1099, 596);
            dgrBobbins.TabIndex = 3;
            dgrBobbins.CellValueChanged += dgrBobbins_CellValueChanged;
            dgrBobbins.KeyDown += dgrBobbins_KeyDown;
            // 
            // colBobbinNo
            // 
            colBobbinNo.DataPropertyName = "BobbinNo";
            colBobbinNo.HeaderText = "BobbinNo";
            colBobbinNo.MinimumWidth = 6;
            colBobbinNo.Name = "colBobbinNo";
            colBobbinNo.Width = 165;
            // 
            // colBobbinLabel
            // 
            colBobbinLabel.DataPropertyName = "BobbinLabel";
            colBobbinLabel.HeaderText = "BobbinLabel";
            colBobbinLabel.MinimumWidth = 6;
            colBobbinLabel.Name = "colBobbinLabel";
            colBobbinLabel.Width = 235;
            // 
            // colThreadLabel
            // 
            colThreadLabel.DataPropertyName = "ThreadLabel";
            colThreadLabel.HeaderText = "ThreadLabel";
            colThreadLabel.MinimumWidth = 6;
            colThreadLabel.Name = "colThreadLabel";
            colThreadLabel.Width = 245;
            // 
            // colStitchCount
            // 
            colStitchCount.DataPropertyName = "StitchCount";
            colStitchCount.HeaderText = "StitchCount";
            colStitchCount.MinimumWidth = 6;
            colStitchCount.Name = "colStitchCount";
            colStitchCount.Width = 155;
            // 
            // colMachine
            // 
            colMachine.DataPropertyName = "Machine";
            colMachine.HeaderText = "Machine";
            colMachine.MinimumWidth = 6;
            colMachine.Name = "colMachine";
            colMachine.Width = 185;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Visible = false;
            colID.Width = 125;
            // 
            // ucBobbinConfig
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(dgrBobbins);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ucBobbinConfig";
            Size = new System.Drawing.Size(1105, 687);
            Load += ucBobbinConfig_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrBobbins).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.DataGridView dgrBobbins;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBobbinNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBobbinLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThreadLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStitchCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMachine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
    }
}
