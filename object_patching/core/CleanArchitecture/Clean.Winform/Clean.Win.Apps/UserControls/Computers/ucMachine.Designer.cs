namespace Clean.Win.AppUI.UserControls
{
    partial class ucMachine
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
            pnlUcOperation = new System.Windows.Forms.Panel();
            btnInsert = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnRejectChanges = new System.Windows.Forms.Button();
            grpDetail = new System.Windows.Forms.GroupBox();
            btnClipSensorActivate = new System.Windows.Forms.Button();
            txtClipSensorActivate = new System.Windows.Forms.TextBox();
            cbActivateFoot = new System.Windows.Forms.CheckBox();
            lblClipSensor = new System.Windows.Forms.Label();
            lblActiveFootLift = new System.Windows.Forms.Label();
            lblMaxNo = new System.Windows.Forms.Label();
            txtMaxNo = new System.Windows.Forms.TextBox();
            txtAlterMachine = new System.Windows.Forms.TextBox();
            lblAlterMachine = new System.Windows.Forms.Label();
            txtMachine = new System.Windows.Forms.TextBox();
            lblMachine = new System.Windows.Forms.Label();
            pnl = new System.Windows.Forms.Panel();
            sewingMachineGridView = new System.Windows.Forms.DataGridView();
            grpChangeOfNeedle = new System.Windows.Forms.GroupBox();
            panel2 = new System.Windows.Forms.Panel();
            ClipSensorGridView = new System.Windows.Forms.DataGridView();
            dateTimePickerUntil = new System.Windows.Forms.DateTimePicker();
            checkBoxUntil = new System.Windows.Forms.CheckBox();
            lblUntil = new System.Windows.Forms.Label();
            dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            checkBoxFrom = new System.Windows.Forms.CheckBox();
            lblFrom = new System.Windows.Forms.Label();
            txtMachineNeedles = new System.Windows.Forms.TextBox();
            lblMachineNeedles = new System.Windows.Forms.Label();
            pnlUcOperation.SuspendLayout();
            grpDetail.SuspendLayout();
            pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sewingMachineGridView).BeginInit();
            grpChangeOfNeedle.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClipSensorGridView).BeginInit();
            SuspendLayout();
            // 
            // pnlUcOperation
            // 
            pnlUcOperation.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlUcOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlUcOperation.Controls.Add(btnInsert);
            pnlUcOperation.Controls.Add(btnSave);
            pnlUcOperation.Controls.Add(btnRejectChanges);
            pnlUcOperation.Location = new System.Drawing.Point(3, 617);
            pnlUcOperation.Margin = new System.Windows.Forms.Padding(3, 3, 3, 27);
            pnlUcOperation.Name = "pnlUcOperation";
            pnlUcOperation.Size = new System.Drawing.Size(1099, 70);
            pnlUcOperation.TabIndex = 15;
            // 
            // btnInsert
            // 
            btnInsert.Location = new System.Drawing.Point(317, 11);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new System.Drawing.Size(138, 51);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(164, 11);
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
            // grpDetail
            // 
            grpDetail.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpDetail.Controls.Add(btnClipSensorActivate);
            grpDetail.Controls.Add(txtClipSensorActivate);
            grpDetail.Controls.Add(cbActivateFoot);
            grpDetail.Controls.Add(lblClipSensor);
            grpDetail.Controls.Add(lblActiveFootLift);
            grpDetail.Controls.Add(lblMaxNo);
            grpDetail.Controls.Add(txtMaxNo);
            grpDetail.Controls.Add(txtAlterMachine);
            grpDetail.Controls.Add(lblAlterMachine);
            grpDetail.Controls.Add(txtMachine);
            grpDetail.Controls.Add(lblMachine);
            grpDetail.Location = new System.Drawing.Point(6, 410);
            grpDetail.Name = "grpDetail";
            grpDetail.Size = new System.Drawing.Size(1096, 201);
            grpDetail.TabIndex = 16;
            grpDetail.TabStop = false;
            grpDetail.Text = "Details";
            // 
            // btnClipSensorActivate
            // 
            btnClipSensorActivate.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClipSensorActivate.Location = new System.Drawing.Point(1046, 154);
            btnClipSensorActivate.Name = "btnClipSensorActivate";
            btnClipSensorActivate.Size = new System.Drawing.Size(43, 29);
            btnClipSensorActivate.TabIndex = 10;
            btnClipSensorActivate.UseVisualStyleBackColor = true;
            btnClipSensorActivate.Click += btnClipSensorActivate_Click;
            // 
            // txtClipSensorActivate
            // 
            txtClipSensorActivate.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtClipSensorActivate.Location = new System.Drawing.Point(382, 156);
            txtClipSensorActivate.Name = "txtClipSensorActivate";
            txtClipSensorActivate.Size = new System.Drawing.Size(659, 27);
            txtClipSensorActivate.TabIndex = 9;
            // 
            // cbActivateFoot
            // 
            cbActivateFoot.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbActivateFoot.AutoSize = true;
            cbActivateFoot.Location = new System.Drawing.Point(382, 131);
            cbActivateFoot.Name = "cbActivateFoot";
            cbActivateFoot.Size = new System.Drawing.Size(18, 17);
            cbActivateFoot.TabIndex = 8;
            cbActivateFoot.UseVisualStyleBackColor = true;
            // 
            // lblClipSensor
            // 
            lblClipSensor.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblClipSensor.AutoSize = true;
            lblClipSensor.Location = new System.Drawing.Point(16, 163);
            lblClipSensor.Name = "lblClipSensor";
            lblClipSensor.Size = new System.Drawing.Size(154, 20);
            lblClipSensor.TabIndex = 7;
            lblClipSensor.Text = "Clip Sensor Activation";
            // 
            // lblActiveFootLift
            // 
            lblActiveFootLift.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblActiveFootLift.AutoSize = true;
            lblActiveFootLift.Location = new System.Drawing.Point(16, 131);
            lblActiveFootLift.Name = "lblActiveFootLift";
            lblActiveFootLift.Size = new System.Drawing.Size(241, 20);
            lblActiveFootLift.TabIndex = 6;
            lblActiveFootLift.Text = "Activate Foot Lift In Critical Section";
            // 
            // lblMaxNo
            // 
            lblMaxNo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblMaxNo.AutoSize = true;
            lblMaxNo.Location = new System.Drawing.Point(16, 99);
            lblMaxNo.Name = "lblMaxNo";
            lblMaxNo.Size = new System.Drawing.Size(200, 20);
            lblMaxNo.TabIndex = 5;
            lblMaxNo.Text = "Max. No. Stitches per Needle";
            // 
            // txtMaxNo
            // 
            txtMaxNo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtMaxNo.Location = new System.Drawing.Point(382, 92);
            txtMaxNo.Name = "txtMaxNo";
            txtMaxNo.Size = new System.Drawing.Size(708, 27);
            txtMaxNo.TabIndex = 4;
            // 
            // txtAlterMachine
            // 
            txtAlterMachine.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtAlterMachine.Location = new System.Drawing.Point(382, 59);
            txtAlterMachine.Name = "txtAlterMachine";
            txtAlterMachine.Size = new System.Drawing.Size(708, 27);
            txtAlterMachine.TabIndex = 3;
            // 
            // lblAlterMachine
            // 
            lblAlterMachine.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblAlterMachine.AutoSize = true;
            lblAlterMachine.Location = new System.Drawing.Point(16, 67);
            lblAlterMachine.Name = "lblAlterMachine";
            lblAlterMachine.Size = new System.Drawing.Size(141, 20);
            lblAlterMachine.TabIndex = 2;
            lblAlterMachine.Text = "Alternative Machine";
            // 
            // txtMachine
            // 
            txtMachine.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtMachine.Location = new System.Drawing.Point(382, 26);
            txtMachine.Name = "txtMachine";
            txtMachine.Size = new System.Drawing.Size(708, 27);
            txtMachine.TabIndex = 1;
            // 
            // lblMachine
            // 
            lblMachine.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblMachine.AutoSize = true;
            lblMachine.Location = new System.Drawing.Point(16, 33);
            lblMachine.Name = "lblMachine";
            lblMachine.Size = new System.Drawing.Size(65, 20);
            lblMachine.TabIndex = 0;
            lblMachine.Text = "Machine";
            // 
            // pnl
            // 
            pnl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnl.Controls.Add(sewingMachineGridView);
            pnl.Location = new System.Drawing.Point(6, 12);
            pnl.Name = "pnl";
            pnl.Size = new System.Drawing.Size(697, 392);
            pnl.TabIndex = 17;
            // 
            // sewingMachineGridView
            // 
            sewingMachineGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sewingMachineGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            sewingMachineGridView.Location = new System.Drawing.Point(0, 0);
            sewingMachineGridView.Name = "sewingMachineGridView";
            sewingMachineGridView.RowHeadersWidth = 51;
            sewingMachineGridView.RowTemplate.Height = 29;
            sewingMachineGridView.Size = new System.Drawing.Size(697, 392);
            sewingMachineGridView.TabIndex = 0;
            // 
            // grpChangeOfNeedle
            // 
            grpChangeOfNeedle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            grpChangeOfNeedle.Controls.Add(panel2);
            grpChangeOfNeedle.Controls.Add(dateTimePickerUntil);
            grpChangeOfNeedle.Controls.Add(checkBoxUntil);
            grpChangeOfNeedle.Controls.Add(lblUntil);
            grpChangeOfNeedle.Controls.Add(dateTimePickerFrom);
            grpChangeOfNeedle.Controls.Add(checkBoxFrom);
            grpChangeOfNeedle.Controls.Add(lblFrom);
            grpChangeOfNeedle.Controls.Add(txtMachineNeedles);
            grpChangeOfNeedle.Controls.Add(lblMachineNeedles);
            grpChangeOfNeedle.Location = new System.Drawing.Point(709, 12);
            grpChangeOfNeedle.Name = "grpChangeOfNeedle";
            grpChangeOfNeedle.Size = new System.Drawing.Size(393, 398);
            grpChangeOfNeedle.TabIndex = 18;
            grpChangeOfNeedle.TabStop = false;
            grpChangeOfNeedle.Text = "Change of Needles";
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            panel2.Controls.Add(ClipSensorGridView);
            panel2.Location = new System.Drawing.Point(9, 141);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(377, 251);
            panel2.TabIndex = 8;
            // 
            // ClipSensorGridView
            // 
            ClipSensorGridView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            ClipSensorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClipSensorGridView.Location = new System.Drawing.Point(0, 0);
            ClipSensorGridView.Name = "ClipSensorGridView";
            ClipSensorGridView.RowHeadersWidth = 51;
            ClipSensorGridView.RowTemplate.Height = 29;
            ClipSensorGridView.Size = new System.Drawing.Size(377, 251);
            ClipSensorGridView.TabIndex = 0;
            // 
            // dateTimePickerUntil
            // 
            dateTimePickerUntil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePickerUntil.Location = new System.Drawing.Point(137, 99);
            dateTimePickerUntil.Name = "dateTimePickerUntil";
            dateTimePickerUntil.Size = new System.Drawing.Size(183, 27);
            dateTimePickerUntil.TabIndex = 7;
            // 
            // checkBoxUntil
            // 
            checkBoxUntil.AutoSize = true;
            checkBoxUntil.Location = new System.Drawing.Point(98, 109);
            checkBoxUntil.Name = "checkBoxUntil";
            checkBoxUntil.Size = new System.Drawing.Size(18, 17);
            checkBoxUntil.TabIndex = 6;
            checkBoxUntil.UseVisualStyleBackColor = true;
            checkBoxUntil.CheckedChanged += checkBoxUntil_CheckedChanged;
            // 
            // lblUntil
            // 
            lblUntil.AutoSize = true;
            lblUntil.Location = new System.Drawing.Point(12, 109);
            lblUntil.Name = "lblUntil";
            lblUntil.Size = new System.Drawing.Size(40, 20);
            lblUntil.TabIndex = 5;
            lblUntil.Text = "Until";
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePickerFrom.Location = new System.Drawing.Point(137, 67);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new System.Drawing.Size(183, 27);
            dateTimePickerFrom.TabIndex = 4;
            // 
            // checkBoxFrom
            // 
            checkBoxFrom.AutoSize = true;
            checkBoxFrom.Location = new System.Drawing.Point(98, 75);
            checkBoxFrom.Name = "checkBoxFrom";
            checkBoxFrom.Size = new System.Drawing.Size(18, 17);
            checkBoxFrom.TabIndex = 3;
            checkBoxFrom.UseVisualStyleBackColor = true;
            checkBoxFrom.CheckedChanged += checkBoxFrom_CheckedChanged;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new System.Drawing.Point(12, 74);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new System.Drawing.Size(43, 20);
            lblFrom.TabIndex = 2;
            lblFrom.Text = "From";
            // 
            // txtMachineNeedles
            // 
            txtMachineNeedles.Location = new System.Drawing.Point(98, 33);
            txtMachineNeedles.Name = "txtMachineNeedles";
            txtMachineNeedles.Size = new System.Drawing.Size(125, 27);
            txtMachineNeedles.TabIndex = 1;
            // 
            // lblMachineNeedles
            // 
            lblMachineNeedles.AllowDrop = true;
            lblMachineNeedles.AutoSize = true;
            lblMachineNeedles.Location = new System.Drawing.Point(12, 40);
            lblMachineNeedles.Name = "lblMachineNeedles";
            lblMachineNeedles.Size = new System.Drawing.Size(65, 20);
            lblMachineNeedles.TabIndex = 0;
            lblMachineNeedles.Text = "Machine";
            // 
            // ucMachine
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(grpChangeOfNeedle);
            Controls.Add(pnl);
            Controls.Add(grpDetail);
            Controls.Add(pnlUcOperation);
            Name = "ucMachine";
            Size = new System.Drawing.Size(1105, 687);
            Load += onFormLoad;
            pnlUcOperation.ResumeLayout(false);
            grpDetail.ResumeLayout(false);
            grpDetail.PerformLayout();
            pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sewingMachineGridView).EndInit();
            grpChangeOfNeedle.ResumeLayout(false);
            grpChangeOfNeedle.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ClipSensorGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlUcOperation;
        public System.Windows.Forms.Button btnInsert;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnRejectChanges;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Label lblClipSensor;
        private System.Windows.Forms.Label lblActiveFootLift;
        private System.Windows.Forms.Label lblMaxNo;
        private System.Windows.Forms.TextBox txtMaxNo;
        private System.Windows.Forms.TextBox txtAlterMachine;
        private System.Windows.Forms.Label lblAlterMachine;
        private System.Windows.Forms.TextBox txtMachine;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.DataGridView sewingMachineGridView;
        private System.Windows.Forms.GroupBox grpChangeOfNeedle;
        private System.Windows.Forms.Button btnClipSensorActivate;
        private System.Windows.Forms.TextBox txtClipSensorActivate;
        private System.Windows.Forms.CheckBox cbActivateFoot;
        private System.Windows.Forms.DateTimePicker dateTimePickerUntil;
        private System.Windows.Forms.CheckBox checkBoxUntil;
        private System.Windows.Forms.Label lblUntil;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.CheckBox checkBoxFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txtMachineNeedles;
        private System.Windows.Forms.Label lblMachineNeedles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ClipSensorGridView;
    }
}
