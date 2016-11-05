using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_4_1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public bool isSave = true;
        public string saveFileDirectory = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Color clr = new Color();
            PropertyInfo[] colors = clr.GetType().GetProperties();
            for (int i = 8; i <= 72; i++)
            {
                tscbFontSize.Items.Add(i);
            }

            InstalledFontCollection fontsCollection = new InstalledFontCollection();
            FontFamily[] fontFamilies = fontsCollection.Families;
            foreach (FontFamily font in fontFamilies)
            {
                tscbFontFamily.Items.Add(font.Name);
            }

            this.tscbBackColor.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            this.tscbFontColor.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;

            foreach (PropertyInfo color in colors)
            {
                if (color.PropertyType == typeof(System.Drawing.Color))
                {
                    tscbFontColor.Items.Add(color.Name);
                    tscbBackColor.Items.Add(color.Name);
                }
            }

            //inisiasi
            tscbFontSize.SelectedIndex = 3;
            tscbFontFamily.Text = "Calibri";
            tscbFontColor.Text = "Black";
            tscbBackColor.Text = "White";
            changeText();
            //event
            this.tscbFontColor.ComboBox.DrawItem += new DrawItemEventHandler(tscbFontColor_DrawItem);
            this.tscbBackColor.ComboBox.DrawItem += new DrawItemEventHandler(tscbFontColor_DrawItem);
            this.rTTextBox.Focus();
        }

        private void tBtnBold_Click(object sender, EventArgs e)
        {
            tBtnBold.Checked ^= true;
            changeText(sender);
        }

        private void tBtnItalic_Click(object sender, EventArgs e)
        {
            tBtnItalic.Checked ^= true;
            changeText(sender);
        }

        private void tBtnUnderline_Click(object sender, EventArgs e)
        {
            tBtnUnderline.Checked ^= true;
            changeText(sender);
        }

        private void tscbFontColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            // a dropdownlist may initially have no item selected, so skip the highlighting:
            if (e.Index >= 0)
            {
                Graphics g = e.Graphics;
                Brush brush = new SolidBrush(e.BackColor);
                Brush tBrush = new SolidBrush(e.ForeColor);

                g.FillRectangle(brush, e.Bounds);
                string s = (string)this.tscbFontColor.Items[e.Index].ToString();
                SolidBrush b = new SolidBrush(Color.FromName(s));
                // Draw a rectangle and fill it with the current color
                // and add the name to the right of the color
                e.Graphics.DrawRectangle(Pens.Black, 2, e.Bounds.Top + 1, 20, 11);
                e.Graphics.FillRectangle(b, 3, e.Bounds.Top + 2, 19, 10);
                e.Graphics.DrawString(s, this.Font, Brushes.Black, 25, e.Bounds.Top);
                brush.Dispose();
                tBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        private void rTTextBox_SelectionChanged(object sender, EventArgs e)
        {

            tBtnBold.Checked = false;
            tBtnItalic.Checked = false;
            tBtnUnderline.Checked = false;
            if (rTTextBox.SelectionFont != null)
            {
                tscbFontFamily.Text = rTTextBox.SelectionFont.FontFamily.Name;
                tscbFontSize.Text = rTTextBox.SelectionFont.Size.ToString();
                if (rTTextBox.SelectionFont.Style.ToString().IndexOf("Bold") >= 0)
                {
                    tBtnBold.Checked = true;
                }
                if (rTTextBox.SelectionFont.Style.ToString().IndexOf("Italic") >= 0)
                {
                    tBtnItalic.Checked = true;
                }
                if (rTTextBox.SelectionFont.Style.ToString().IndexOf("Underline") >= 0)
                {
                    tBtnUnderline.Checked = true;
                }
            }
            else
            {
                tscbFontFamily.Text = "";
                tscbFontSize.Text = "";
            }

            if (rTTextBox.SelectionColor.Name == "0")
            {
                tscbFontColor.Text = "Black";
            }
            else
            {
                tscbFontColor.Text = rTTextBox.SelectionColor.Name;
            }

        }

        private void tscbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox tscb = (ToolStripComboBox)sender;
            if (!tscb.Focused)
            {
                return;
            }
            changeText(sender);
        }

        private void tscbFontColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox tscb = (ToolStripComboBox)sender;
            if (!tscb.Focused)
            {
                return;
            }
            rTTextBox.SelectionColor = Color.FromName(tscbFontColor.Text);
        }

        private void tscbFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox tscb = (ToolStripComboBox)sender;
            if (!tscb.Focused)
            {
                return;
            }
            changeText(sender);
        }

        private void tscbBackColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int length = rTTextBox.SelectionLength;
            int start = rTTextBox.SelectionStart;
            ToolStripComboBox tscb = (ToolStripComboBox)sender;
            if (!tscb.Focused)
            {
                return;
            }
            rTTextBox.SelectionBackColor = Color.FromName(tscbBackColor.Text);
            rTTextBox.Select(start, length);
        }

        private void tscbFontSize_LostFocus(object sender, EventArgs e)
        {
            changeText(sender);
        }

        private void tscbFontColor_LostFocus(object sender, EventArgs e)
        {
            rTTextBox.SelectionColor = Color.FromName(tscbFontColor.Text);
        }

        private void tscbFontFamily_LostFocus(object sender, EventArgs e)
        {
            changeText(sender);
        }

        private void tscbBackColor_LostFocus(object sender, EventArgs e)
        {
            int length = rTTextBox.SelectionLength;
            int start = rTTextBox.SelectionStart;
            rTTextBox.SelectionBackColor = Color.FromName(tscbBackColor.Text);
            rTTextBox.Select(start, length);
        }

       
        private void saveFile()
        {
            DialogResult dr;
            if (saveFileDirectory == "")
            {
                saveFileDialog1.Filter = "Text File | *.rtf";
                dr = saveFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    rTTextBox.SaveFile(saveFileDialog1.FileName);
                    saveFileDirectory = saveFileDialog1.FileName;
                    this.Text = "Latihan 4_1 - " + saveFileDialog1.FileName;
                }
            }
            else
            {
                dr = MessageBox.Show("File ini telah pernah disimpan. Apakah anda ingin menimpanya?", "Simpan File", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    rTTextBox.SaveFile(saveFileDirectory);
                }
            }
            isSave = true;
        }

        private void changeText(object sender = null)
        {
            bool isBold, isItalic, isUnderline;
            int length = rTTextBox.SelectionLength;
            int start = rTTextBox.SelectionStart;
            float fontSize;
            string fontFamily;
            System.Drawing.FontStyle currentStyle;
            this.rTTextBox.SelectionChanged -= new System.EventHandler(this.rTTextBox_SelectionChanged);
            if (length == 0)
            {
                fontFamily = (tscbFontFamily.Text == "") ? rTTextBox.SelectionFont.FontFamily.Name : tscbFontFamily.Text;
                fontSize = (tscbFontSize.Text == "") ? rTTextBox.SelectionFont.Size : Convert.ToSingle(tscbFontSize.Text);

                isBold = rTTextBox.SelectionFont.Bold;
                isItalic = rTTextBox.SelectionFont.Italic;
                isUnderline = rTTextBox.SelectionFont.Underline;

                if (sender != null && sender.ToString() == "Bold")
                {
                    isBold = tBtnBold.Checked;
                }
                else if (sender != null && sender.ToString() == "Italic")
                {
                    isItalic = tBtnItalic.Checked;
                }
                else if (sender != null && sender.ToString() == "Underline")
                {
                    isUnderline = tBtnUnderline.Checked;
                }

                currentStyle = (isBold) ? FontStyle.Bold : FontStyle.Regular;
                currentStyle |= (isItalic) ? FontStyle.Italic : FontStyle.Regular;
                currentStyle |= (isUnderline) ? FontStyle.Underline : FontStyle.Regular;

                rTTextBox.SelectionFont = new Font(fontFamily,
                                                fontSize,
                                                currentStyle);
            }
            for (int i = start; i < start + length; i++)
            {
                rTTextBox.SelectionChanged -= new System.EventHandler(this.rTTextBox_SelectionChanged);
                rTTextBox.Select(i, 1);
                fontFamily = (tscbFontFamily.Text == "") ? rTTextBox.SelectionFont.FontFamily.Name : tscbFontFamily.Text;
                fontSize = (tscbFontSize.Text == "") ? rTTextBox.SelectionFont.Size : Convert.ToSingle(tscbFontSize.Text);

                isBold = rTTextBox.SelectionFont.Bold;
                isItalic = rTTextBox.SelectionFont.Italic;
                isUnderline = rTTextBox.SelectionFont.Underline;

                if (sender != null && sender.ToString() == "tBtnBold")
                {
                    isBold = tBtnBold.Checked;
                }
                else if (sender != null && sender.ToString() == "tBtnItalic")
                {
                    isItalic = tBtnItalic.Checked;
                }
                else if (sender != null && sender.ToString() == "tBtnUnderline")
                {
                    isUnderline = tBtnUnderline.Checked;
                }

                currentStyle = (isBold) ? FontStyle.Bold : FontStyle.Regular;
                currentStyle |= (isItalic) ? FontStyle.Italic : FontStyle.Regular;
                currentStyle |= (isUnderline) ? FontStyle.Underline : FontStyle.Regular;

                rTTextBox.SelectionFont = new Font(fontFamily,
                                                fontSize,
                                                currentStyle);
            }

            rTTextBox.Focus();
            rTTextBox.Select(start, length);

            this.rTTextBox.SelectionChanged += new System.EventHandler(this.rTTextBox_SelectionChanged);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            if (!isSave)
            {
                dr = MessageBox.Show("Apakah Anda ingin menyimpan file terlebih dahulu?", "Simpan file", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    saveFile();
                }
            }
            isSave = true;
            saveFileDirectory = "";
            this.Text = "Latihan 4_1";
            rTTextBox.Rtf = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult dr;
            if (!isSave)
            {
                dr = MessageBox.Show("Apakah Anda ingin menyimpan file terlebih dahulu?", "Simpan file", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    saveFile();
                }
            }
            dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                rTTextBox.LoadFile(openFileDialog1.FileName);
                saveFileDirectory = openFileDialog1.FileName;
                this.Text = "Latihan 4_1 - " + openFileDialog1.FileName;
            }
        }

        private void rTTextBox_TextChanged(object sender, EventArgs e)
        {
            isSave = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        
    }


}
