namespace ImageEditor
{
    partial class FormResize
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
            flowLayoutPanelResize = new FlowLayoutPanel();
            groupBoxAbs = new GroupBox();
            radioButtonAbs = new RadioButton();
            numericUpDownAbsHeight = new NumericUpDown();
            numericUpDownAbsWidth = new NumericUpDown();
            groupBoxRel = new GroupBox();
            radioButtonRel = new RadioButton();
            numericUpDownRelHeight = new NumericUpDown();
            numericUpDownRelWidth = new NumericUpDown();
            groupBoxList = new GroupBox();
            radioButtonRatio = new RadioButton();
            comboBoxRatio = new ComboBox();
            checkBoxRatio = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonCancel = new Button();
            buttonOk = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            checkBoxFlip = new CheckBox();
            flowLayoutPanelResize.SuspendLayout();
            groupBoxAbs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAbsHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAbsWidth).BeginInit();
            groupBoxRel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRelHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRelWidth).BeginInit();
            groupBoxList.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelResize
            // 
            flowLayoutPanelResize.Controls.Add(groupBoxAbs);
            flowLayoutPanelResize.Controls.Add(groupBoxRel);
            flowLayoutPanelResize.Controls.Add(groupBoxList);
            flowLayoutPanelResize.Controls.Add(flowLayoutPanel2);
            flowLayoutPanelResize.Controls.Add(flowLayoutPanel1);
            flowLayoutPanelResize.Dock = DockStyle.Fill;
            flowLayoutPanelResize.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelResize.Location = new Point(0, 0);
            flowLayoutPanelResize.Name = "flowLayoutPanelResize";
            flowLayoutPanelResize.Size = new Size(256, 321);
            flowLayoutPanelResize.TabIndex = 0;
            // 
            // groupBoxAbs
            // 
            groupBoxAbs.Controls.Add(radioButtonAbs);
            groupBoxAbs.Controls.Add(numericUpDownAbsHeight);
            groupBoxAbs.Controls.Add(numericUpDownAbsWidth);
            groupBoxAbs.Location = new Point(3, 3);
            groupBoxAbs.Name = "groupBoxAbs";
            groupBoxAbs.Size = new Size(250, 82);
            groupBoxAbs.TabIndex = 0;
            groupBoxAbs.TabStop = false;
            groupBoxAbs.Text = "Absolute Size";
            groupBoxAbs.Enter += groupBoxAbs_Enter;
            // 
            // radioButtonAbs
            // 
            radioButtonAbs.AutoSize = true;
            radioButtonAbs.Location = new Point(9, 22);
            radioButtonAbs.Name = "radioButtonAbs";
            radioButtonAbs.Size = new Size(56, 19);
            radioButtonAbs.TabIndex = 2;
            radioButtonAbs.TabStop = true;
            radioButtonAbs.Text = "Select";
            radioButtonAbs.UseVisualStyleBackColor = true;
            radioButtonAbs.CheckedChanged += radioButtonAbs_CheckedChanged;
            // 
            // numericUpDownAbsHeight
            // 
            numericUpDownAbsHeight.Location = new Point(109, 47);
            numericUpDownAbsHeight.Maximum = new decimal(new int[] { 65536, 0, 0, 0 });
            numericUpDownAbsHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAbsHeight.Name = "numericUpDownAbsHeight";
            numericUpDownAbsHeight.Size = new Size(120, 23);
            numericUpDownAbsHeight.TabIndex = 1;
            numericUpDownAbsHeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAbsHeight.ValueChanged += numericUpDownAbsHeight_ValueChanged;
            // 
            // numericUpDownAbsWidth
            // 
            numericUpDownAbsWidth.Location = new Point(109, 18);
            numericUpDownAbsWidth.Maximum = new decimal(new int[] { 65536, 0, 0, 0 });
            numericUpDownAbsWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAbsWidth.Name = "numericUpDownAbsWidth";
            numericUpDownAbsWidth.Size = new Size(120, 23);
            numericUpDownAbsWidth.TabIndex = 0;
            numericUpDownAbsWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAbsWidth.ValueChanged += numericUpDownAbsWidth_ValueChanged;
            // 
            // groupBoxRel
            // 
            groupBoxRel.Controls.Add(radioButtonRel);
            groupBoxRel.Controls.Add(numericUpDownRelHeight);
            groupBoxRel.Controls.Add(numericUpDownRelWidth);
            groupBoxRel.Location = new Point(3, 91);
            groupBoxRel.Name = "groupBoxRel";
            groupBoxRel.Size = new Size(250, 81);
            groupBoxRel.TabIndex = 1;
            groupBoxRel.TabStop = false;
            groupBoxRel.Text = "Relative Size";
            // 
            // radioButtonRel
            // 
            radioButtonRel.AutoSize = true;
            radioButtonRel.Location = new Point(9, 22);
            radioButtonRel.Name = "radioButtonRel";
            radioButtonRel.Size = new Size(56, 19);
            radioButtonRel.TabIndex = 2;
            radioButtonRel.TabStop = true;
            radioButtonRel.Text = "Select";
            radioButtonRel.UseVisualStyleBackColor = true;
            // 
            // numericUpDownRelHeight
            // 
            numericUpDownRelHeight.DecimalPlaces = 2;
            numericUpDownRelHeight.Location = new Point(109, 51);
            numericUpDownRelHeight.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownRelHeight.Name = "numericUpDownRelHeight";
            numericUpDownRelHeight.Size = new Size(120, 23);
            numericUpDownRelHeight.TabIndex = 1;
            numericUpDownRelHeight.ValueChanged += numericUpDownRelHeight_ValueChanged;
            // 
            // numericUpDownRelWidth
            // 
            numericUpDownRelWidth.DecimalPlaces = 2;
            numericUpDownRelWidth.Location = new Point(109, 22);
            numericUpDownRelWidth.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownRelWidth.Name = "numericUpDownRelWidth";
            numericUpDownRelWidth.Size = new Size(120, 23);
            numericUpDownRelWidth.TabIndex = 0;
            numericUpDownRelWidth.ValueChanged += numericUpDownRelWidth_ValueChanged;
            // 
            // groupBoxList
            // 
            groupBoxList.Controls.Add(radioButtonRatio);
            groupBoxList.Controls.Add(comboBoxRatio);
            groupBoxList.Location = new Point(3, 178);
            groupBoxList.Name = "groupBoxList";
            groupBoxList.Size = new Size(250, 56);
            groupBoxList.TabIndex = 3;
            groupBoxList.TabStop = false;
            groupBoxList.Text = "Size List";
            // 
            // radioButtonRatio
            // 
            radioButtonRatio.AutoSize = true;
            radioButtonRatio.Location = new Point(9, 22);
            radioButtonRatio.Name = "radioButtonRatio";
            radioButtonRatio.Size = new Size(56, 19);
            radioButtonRatio.TabIndex = 1;
            radioButtonRatio.TabStop = true;
            radioButtonRatio.Text = "Select";
            radioButtonRatio.UseVisualStyleBackColor = true;
            // 
            // comboBoxRatio
            // 
            comboBoxRatio.FormattingEnabled = true;
            comboBoxRatio.Items.AddRange(new object[] { "640x360", "854x480", "1280x720", "1920x1080", "2560x1440", "3840x2160", "7680x4320" });
            comboBoxRatio.Location = new Point(108, 22);
            comboBoxRatio.Name = "comboBoxRatio";
            comboBoxRatio.Size = new Size(121, 23);
            comboBoxRatio.TabIndex = 0;
            comboBoxRatio.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // checkBoxRatio
            // 
            checkBoxRatio.AutoSize = true;
            checkBoxRatio.Location = new Point(3, 3);
            checkBoxRatio.Name = "checkBoxRatio";
            checkBoxRatio.Padding = new Padding(10);
            checkBoxRatio.Size = new Size(141, 39);
            checkBoxRatio.TabIndex = 2;
            checkBoxRatio.Text = "Keep Aspect Ratio";
            checkBoxRatio.UseVisualStyleBackColor = true;
            checkBoxRatio.CheckedChanged += checkBoxRatio_CheckedChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonCancel);
            flowLayoutPanel1.Controls.Add(buttonOk);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(3, 288);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 30);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(172, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(91, 3);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(checkBoxRatio);
            flowLayoutPanel2.Controls.Add(checkBoxFlip);
            flowLayoutPanel2.Location = new Point(3, 240);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(250, 42);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // checkBoxFlip
            // 
            checkBoxFlip.AutoSize = true;
            checkBoxFlip.Location = new Point(150, 3);
            checkBoxFlip.Name = "checkBoxFlip";
            checkBoxFlip.Padding = new Padding(10);
            checkBoxFlip.Size = new Size(65, 39);
            checkBoxFlip.TabIndex = 3;
            checkBoxFlip.Text = "Flip";
            checkBoxFlip.UseVisualStyleBackColor = true;
            checkBoxFlip.CheckedChanged += checkBoxFlip_CheckedChanged;
            // 
            // FormResize
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 321);
            Controls.Add(flowLayoutPanelResize);
            Name = "FormResize";
            Text = "Resize";
            Load += FormResize_Load;
            flowLayoutPanelResize.ResumeLayout(false);
            groupBoxAbs.ResumeLayout(false);
            groupBoxAbs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAbsHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAbsWidth).EndInit();
            groupBoxRel.ResumeLayout(false);
            groupBoxRel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRelHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRelWidth).EndInit();
            groupBoxList.ResumeLayout(false);
            groupBoxList.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelResize;
        private GroupBox groupBoxAbs;
        private GroupBox groupBoxRel;
        private GroupBox groupBoxList;
        private CheckBox checkBoxRatio;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonCancel;
        private Button buttonOk;
        private NumericUpDown numericUpDownAbsHeight;
        private NumericUpDown numericUpDownAbsWidth;
        private NumericUpDown numericUpDownRelHeight;
        private NumericUpDown numericUpDownRelWidth;
        private ComboBox comboBoxRatio;
        private RadioButton radioButtonAbs;
        private RadioButton radioButtonRel;
        private RadioButton radioButtonRatio;
        private FlowLayoutPanel flowLayoutPanel2;
        private CheckBox checkBoxFlip;
    }
}