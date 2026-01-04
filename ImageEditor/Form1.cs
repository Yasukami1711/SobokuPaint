using System.Windows.Forms;

namespace ImageEditor
{
    public partial class Form1 : Form
    {
        private string filePath = "";
        public Form1()
        {
            InitializeComponent();

            // スクロールイベント
            hScrollBar1.Scroll += (_, _) => UpdatePicturePosition();
            vScrollBar1.Scroll += (_, _) => UpdatePicturePosition();

            CalcSize(); // 初期化時は中央に配置

            pictureBox.AllowDrop = true; // ← 必須
            pictureBox.DragEnter += Form1_DragEnter!;
            pictureBox.DragDrop += Form1_DragDrop!;
        }


        //--------------------------------------
        // 画像サイズ変更・ズーム時に呼ぶ
        //--------------------------------------
        public void CalcSize()
        {
            if (pictureBox.Image == null)
                return;

            int imgW = pictureBox.Image.Width;
            int imgH = pictureBox.Image.Height;

            int viewW = panelPicture.Width;
            int viewH = panelPicture.Height;

            pictureBox.Size = new Size(imgW, imgH);

            // ★ スクロール最大値（画像が完全に見えなくなるまで）
            int hMax = (imgW + viewW) / 2;
            int vMax = (imgH + viewH) / 2;

            hScrollBar1.Minimum = -hMax;
            hScrollBar1.Maximum = hMax;

            vScrollBar1.Minimum = -vMax;
            vScrollBar1.Maximum = vMax;

            // ズーム時は範囲内に収める
            hScrollBar1.Value = Math.Max(hScrollBar1.Minimum, Math.Min(hScrollBar1.Value, hScrollBar1.Maximum));
            vScrollBar1.Value = Math.Max(vScrollBar1.Minimum, Math.Min(vScrollBar1.Value, vScrollBar1.Maximum));

            UpdatePicturePosition();
        }


        //--------------------------------------
        // PictureBox の位置を更新（中心基準）
        //--------------------------------------
        private void UpdatePicturePosition()
        {
            int imgW = pictureBox.Width;
            int imgH = pictureBox.Height;

            int viewW = panelPicture.Width;
            int viewH = panelPicture.Height;

            pictureBox.Left = viewW / 2 - (imgW / 2) - hScrollBar1.Value;
            pictureBox.Top = viewH / 2 - (imgH / 2) - vScrollBar1.Value;
        }

        private bool Open()
        {
            using var ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff;*.ico";
            if (ofd.ShowDialog() != DialogResult.OK) return false;
            try
            {
                filePath = ofd.FileName;
                pictureBox.Image = Image.FromFile(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("画像の読み込みに失敗しました。\n" + ex.Message);
                return false;
            }
            CalcSize();
            return true;
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Open();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            CalcSize();
        }
        private bool SaveAs()
        {
            using SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "画像ファイル(*.bmp)|*.bmp|画像ファイル(*.jpg)|*.jpg|画像ファイル(*.png)|*.png|すべてのファイル(*.*)|*.*";
            if (sfd.ShowDialog() != DialogResult.OK) return false;
            if (pictureBox.Image == null)
            {
                MessageBox.Show("画像の保存に失敗しました。\n");
                return false;
            }
            try
            {
                pictureBox.Image.Save(sfd.FileName);
                filePath = sfd.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("画像の保存に失敗しました。\n" + ex.Message);
                return false;
            }
            return true;
        }
        private bool Save()
        {
            if (string.IsNullOrEmpty(filePath) || pictureBox.Image == null)
            {
                return SaveAs();
            }
            try
            {
                pictureBox.Image.Save(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("画像の保存に失敗しました。\n" + ex.Message);
                return false;
            }
            return true;
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }
        private static bool IsImageFile(string path)
        {
            string ext = Path.GetExtension(path).ToLower();
            return ext == ".jpg" || ext == ".jpeg" || ext == ".png" ||
                   ext == ".bmp" || ext == ".gif" || ext == ".tiff";
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;

            if (!(e.Data?.GetDataPresent(DataFormats.FileDrop) ?? false)) return;

            string[] files = (string[])e.Data?.GetData(DataFormats.FileDrop)!;

            if (files == null) return;
            if (files.Length <= 0) return;
            if (!IsImageFile(files[0])) return;

            e.Effect = DragDropEffects.Copy;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data?.GetData(DataFormats.FileDrop)!;

            if (files == null) return;
            if (files.Length <= 0) return;
            if (!IsImageFile(files[0])) return;

            pictureBox.Image = Image.FromFile(files[0]);
            CalcSize(); // ← あなたの画像配置ロジック
        }

        private bool SizeChange()
        {
            Bitmap bmp = (pictureBox.Image as Bitmap)!;
            if (bmp == null)
            {
                MessageBox.Show("画像のサイズ変更に失敗しました。\n");
                return false;
            }
            using FormResize formResize = new FormResize(bmp.Width, bmp.Height);
            if (formResize.ShowDialog() == DialogResult.OK)
            {
                var newBmp = new Bitmap(bmp, new Size(formResize.NewWidth, formResize.NewHeight));
                using var gfx = Graphics.FromImage(newBmp);
                gfx.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                gfx.DrawImage(bmp, 0, 0, newBmp.Width, newBmp.Height);
                pictureBox.Image = newBmp;
                CalcSize();
            }
            return true;
        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SizeChange();
        }
    }
}
