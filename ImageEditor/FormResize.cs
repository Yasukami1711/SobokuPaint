using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq;

namespace ImageEditor
{
    public partial class FormResize : Form
    {
        public int NewWidth { get; private set; }
        public int NewHeight { get; private set; }

        public int OriginalWidth { get; private set; }

        public int OriginalHeight { get; private set; }

        private List<RadioButton> radioButtons;
        public FormResize(int bmpWidth, int bmpHeight)
        {
            InitializeComponent();

            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            radioButtons = new List<RadioButton>
            {
                radioButtonAbs,
                radioButtonRel,
                radioButtonRatio
            };

            RadioButtonClick(radioButtonAbs);

            foreach (var rb in radioButtons)
            {
                rb.Click += (_, _) => RadioButtonClick(rb);
            }

            OriginalWidth = bmpWidth;
            OriginalHeight = bmpHeight;
        }

        private void FormResize_Load(object sender, EventArgs e)
        {
            numericUpDownAbsWidth.Value = OriginalWidth;
            numericUpDownAbsHeight.Value = OriginalHeight;

            numericUpDownRelWidth.Value = 100.00m;
            numericUpDownRelHeight.Value = 100.00m;

            UpdateControlEnabledStates();
        }

        private void groupBoxAbs_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonAbs_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void RadioButtonClick(RadioButton self)
        {
            foreach (var rb in radioButtons)
            {
                rb.Checked = false;
            }
            self.Checked = true;

            UpdateControlEnabledStates();
        }

        private void UpdateControlEnabledStates()
        {
            bool absSelected = radioButtonAbs.Checked;
            bool relSelected = radioButtonRel.Checked;
            bool ratioSelected = radioButtonRatio.Checked;
            bool ratioLocked = checkBoxRatio.Checked;

            numericUpDownAbsWidth.Enabled = absSelected;
            numericUpDownAbsHeight.Enabled = absSelected && !ratioLocked;

            numericUpDownRelWidth.Enabled = relSelected;
            numericUpDownRelHeight.Enabled = relSelected && !ratioLocked;

            comboBoxRatio.Enabled = ratioSelected;
            if (ratioSelected)
            {
                numericUpDownAbsWidth.Enabled = false;
                numericUpDownAbsHeight.Enabled = false;
                numericUpDownRelWidth.Enabled = false;
                numericUpDownRelHeight.Enabled = false;
            }

            checkBoxRatio.Enabled = true;
            checkBoxFlip.Enabled = true;
        }

        private void checkBoxRatio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRatio.Checked)
            {
                decimal ratio = numericUpDownRelWidth.Value;
                numericUpDownRelHeight.Value = ratio;
                numericUpDownAbsHeight.Value = (OriginalHeight * ratio) / 100.0m;
            }

            UpdateControlEnabledStates();
        }

        private void numericUpDownAbsWidth_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownAbsHeight.Enabled == false && checkBoxRatio.Checked)
            {
                decimal ratio = numericUpDownAbsWidth.Value / OriginalWidth * 100.0m;
                numericUpDownRelWidth.Value = ratio;
                numericUpDownAbsHeight.Value = (OriginalHeight * ratio) / 100.0m;
            }
        }

        private void numericUpDownAbsHeight_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownAbsHeight.Enabled == false && checkBoxRatio.Checked)
            {
                decimal ratio = numericUpDownAbsHeight.Value / OriginalHeight * 100.0m;
                numericUpDownRelWidth.Value = ratio;
                numericUpDownAbsWidth.Value = (OriginalWidth * ratio) / 100.0m;
            }
        }

        private void numericUpDownRelWidth_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownAbsHeight.Enabled == false && checkBoxRatio.Checked)
            {
                decimal ratio = numericUpDownRelWidth.Value;
                numericUpDownRelHeight.Value = ratio;
                numericUpDownAbsWidth.Value = (OriginalWidth * ratio) / 100.0m;
                numericUpDownAbsHeight.Value = (OriginalHeight * ratio) / 100.0m;
            }
        }

        private void numericUpDownRelHeight_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownAbsHeight.Enabled == false && checkBoxRatio.Checked)
            {
                decimal ratio = numericUpDownRelHeight.Value;
                numericUpDownRelWidth.Value = ratio;
                numericUpDownAbsWidth.Value = (OriginalWidth * ratio) / 100.0m;
                numericUpDownAbsHeight.Value = (OriginalHeight * ratio) / 100.0m;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            NewWidth = (int)numericUpDownAbsWidth.Value;
            NewHeight = (int)numericUpDownAbsHeight.Value;
        }
        public static bool SizeTryParse(string text, out (int w, int h) ret)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                Debug.WriteLine("Input is null or empty.", nameof(text));
                ret = default;
                return false;
            }

            string[] parts = text.Split('x', 'X'); // 大文字Xにも対応

            if (parts.Length != 2)
            {
                Debug.WriteLine("Format must be \"<int>x<int>\".");
                ret = default;
                return false;
            }

            if (!int.TryParse(parts[0], out int w) || w <= 0)
            {
                Debug.WriteLine("Width is not a valid integer.");
                ret = default;
                return false;
            }

            if (!int.TryParse(parts[1], out int h) || h <= 0)
            {
                Debug.WriteLine("Height is not a valid integer.");
                ret = default;
                return false;
            }

            ret = (w, h);
            return true;
        }
        public static string SizeToString(in (int w, int h) size)
        {
            return $"{size.w}x{size.h}";
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SizeTryParse(comboBoxRatio.SelectedItem?.ToString() ?? "", out var size))
            {
                numericUpDownAbsWidth.Value = size.w;
                numericUpDownAbsHeight.Value = size.h;
                numericUpDownRelWidth.Value = size.w * 100.0m / OriginalWidth;
                numericUpDownRelHeight.Value = size.h * 100.0m / OriginalHeight;
            }
        }


        private void checkBoxFlip_CheckedChanged(object sender, EventArgs e)
        {
            decimal tmp = numericUpDownAbsWidth.Value;
            numericUpDownAbsWidth.Value = numericUpDownAbsHeight.Value;
            numericUpDownAbsHeight.Value = tmp;
            tmp = numericUpDownRelWidth.Value;
            numericUpDownRelWidth.Value = numericUpDownRelHeight.Value;
            numericUpDownRelHeight.Value = tmp;
            var tmpItems = comboBoxRatio.Items.Cast<string>().Select(item =>
            {
                if (SizeTryParse(item?.ToString() ?? "", out var size))
                {
                    return SizeToString((size.h, size.w));
                }
                else
                {
                    return item;
                }
            }).ToArray();
            comboBoxRatio.Items.Clear();
            comboBoxRatio.Items.AddRange(tmpItems!);

        }
    }
}
