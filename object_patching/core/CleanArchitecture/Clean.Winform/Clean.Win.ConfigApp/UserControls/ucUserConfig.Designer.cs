namespace Clean.Win.AppUI.UserControls
{
    partial class ucUserConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUserConfig));
            pnlGrid = new System.Windows.Forms.Panel();
            mainGridView = new System.Windows.Forms.DataGridView();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainGridView).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlGrid
            // 
            pnlGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlGrid.Controls.Add(toolStrip1);
            pnlGrid.Controls.Add(mainGridView);
            pnlGrid.Location = new System.Drawing.Point(0, -1);
            pnlGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new System.Drawing.Size(1074, 582);
            pnlGrid.TabIndex = 10;
            // 
            // mainGridView
            // 
            mainGridView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            mainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainGridView.Location = new System.Drawing.Point(0, 68);
            mainGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            mainGridView.Name = "mainGridView";
            mainGridView.RowHeadersWidth = 51;
            mainGridView.RowTemplate.Height = 25;
            mainGridView.Size = new System.Drawing.Size(1071, 397);
            mainGridView.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(1074, 27);
            toolStrip1.TabIndex = 16;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new System.Drawing.Size(82, 24);
            toolStripButton1.Text = "Refresh";
            toolStripButton1.Click += btnRefresh_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = (System.Drawing.Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new System.Drawing.Size(64, 24);
            toolStripButton2.Text = "Save";
            toolStripButton2.Click += btnSave_Click;
            // 
            // ucUserConfig
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pnlGrid);
            Name = "ucUserConfig";
            Size = new System.Drawing.Size(1074, 581);
            Load += onFormLoad;
            pnlGrid.ResumeLayout(false);
            pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainGridView).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView mainGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}
