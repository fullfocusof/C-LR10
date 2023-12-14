using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LR10
{
    public partial class TextEditorForm : Form
    {
        Font MyFont = new Font("Arial", 12);
        string path = "";
        bool docChanged = false;

        public TextEditorForm()
        {
            InitializeComponent();
            TextEdit.Font = MyFont;

            ToolStrip.ImageList = imageList1;
            LeftToolStripButton.ImageIndex = 0;
            CenterToolStripButton.ImageIndex = 1;   
            RightToolStripButton.ImageIndex = 2;
        }

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "RTF files|*.rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextEdit.LoadFile(openFileDialog1.FileName);
                Text = "Текстовый редактор:   " + openFileDialog1.FileName;
            }
            path = openFileDialog1.FileName;
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "RTF files|*.rtf";
            if (path != "" || File.Exists(path))
            {
                TextEdit.SaveFile(path);              
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    TextEdit.SaveFile(saveFileDialog1.FileName);
                    Text = "Текстовый редактор:   " + saveFileDialog1.FileName;
                    path = saveFileDialog1.FileName;
                }   
            }
        }

        private void CreateToolStripButton_Click(object sender, EventArgs e)
        {
            if(docChanged)
            {
                DialogResult result = MessageBox.Show("Хотите сохранить текущий документ?", "Сохранение документа", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SaveToolStripButton_Click(sender, e);
                }
                else if(result == DialogResult.Cancel)
                {
                    return;
                }
            }

            TextEdit.Clear();
            Text = "Текстовый редактор";
            path = "";
            docChanged = false;
        }

        private void TextEdit_TextChanged(object sender, EventArgs e)
        {
            docChanged = true;         
        }

        private void HelpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Главный разработчик: Мельников Максим\n Контактные данные:\n GitHub - github.com/fullfocusof \n VK - vk.com/y_u_kiddin_me", "Авторы", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BoldToolStripButton_Click(object sender, EventArgs e)
        {
            if (BoldToolStripButton.Checked)
            {
                BoldToolStripMenuItem.Checked = true;
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | FontStyle.Bold);
            }
            else
            {
                BoldToolStripMenuItem.Checked = false;
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Bold);
            }
        }

        private void ItalicToolStripButton_Click(object sender, EventArgs e)
        {
            if (ItalicToolStripButton.Checked)
            {
                ItalicToolStripMenuItem.Checked = true;
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | FontStyle.Italic);
            }   
            else
            {
                ItalicToolStripMenuItem.Checked = false;
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Italic);
            }
                
        }

        private void UnderlineToolStripButton_Click(object sender, EventArgs e)
        {
            if (UnderlineToolStripButton.Checked)
            {
                UnderlineToolStripMenuItem.Checked = true;
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | FontStyle.Underline);
            }
            else
            {
                UnderlineToolStripMenuItem.Checked = false;
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Underline);
            }
        }

        private void TextEdit_SelectionChanged(object sender, EventArgs e)
        {
            if (TextEdit.SelectionFont == null) return;

            BoldToolStripButton.Checked = BoldToolStripMenuItem.Checked = TextEdit.SelectionFont.Bold;
            ItalicToolStripButton.Checked = ItalicToolStripMenuItem.Checked = TextEdit.SelectionFont.Italic;
            UnderlineToolStripButton.Checked = UnderlineToolStripMenuItem.Checked = TextEdit.SelectionFont.Underline;

            SizeTSComboBox.Text = TextEdit.SelectionFont.Size.ToString();
            SizeInMenuToolStripComboBox.Text = TextEdit.SelectionFont.Size.ToString();

            CenterToolStripButton.Checked = CenterToolStripMenuItem.Checked = TextEdit.SelectionAlignment == HorizontalAlignment.Center;
            LeftToolStripButton.Checked = LeftToolStripMenuItem.Checked = TextEdit.SelectionAlignment == HorizontalAlignment.Left;
            RightToolStripButton.Checked = RightToolStripMenuItem.Checked = TextEdit.SelectionAlignment == HorizontalAlignment.Right;
        }

        private void FontColorToolStripButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                TextEdit.SelectionColor = colorDialog1.Color;
                TextEdit.Focus();
            }
        }

        private void FontToolStripButton_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                TextEdit.SelectionFont = fontDialog1.Font;
                TextEdit.Focus();
            }
        }

        private void CenterToolStripButton_Click(object sender, EventArgs e)
        {
            CenterToolStripMenuItem.Checked = true;
            if (RightToolStripButton.Checked) RightToolStripButton.Checked = false; RightToolStripMenuItem.Checked = false;
            if (LeftToolStripButton.Checked) LeftToolStripButton.Checked = false; LeftToolStripMenuItem.Checked = false;

            if (TextEdit.SelectionAlignment == HorizontalAlignment.Center) TextEdit.SelectionAlignment = HorizontalAlignment.Left;
            else TextEdit.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void LeftToolStripButton_Click(object sender, EventArgs e)
        {
            LeftToolStripMenuItem.Checked = true;
            if (CenterToolStripButton.Checked) CenterToolStripButton.Checked = false; CenterToolStripMenuItem.Checked = false;
            if (RightToolStripButton.Checked) RightToolStripButton.Checked = false; RightToolStripMenuItem.Checked = false;

            TextEdit.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void RightToolStripButton_Click(object sender, EventArgs e)
        {
            RightToolStripMenuItem.Checked = true;
            if (CenterToolStripButton.Checked) CenterToolStripButton.Checked = false; CenterToolStripMenuItem.Checked = false;
            if (LeftToolStripButton.Checked) LeftToolStripButton.Checked = false; LeftToolStripMenuItem.Checked = false;

            if (TextEdit.SelectionAlignment == HorizontalAlignment.Right) TextEdit.SelectionAlignment = HorizontalAlignment.Left;
            else TextEdit.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void CutToolStripButton_Click(object sender, EventArgs e)
        {
            if (TextEdit.SelectedText != "")
            {
                Clipboard.SetText(TextEdit.SelectedText);
                TextEdit.SelectedText = "";
            }
        }

        private void CopyToolStripButton_Click(object sender, EventArgs e)
        {
            if (TextEdit.SelectedText != "")
            {
                Clipboard.SetText(TextEdit.SelectedText);
            }
        }

        private void InsertToolStripButton_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                TextEdit.SelectedText = Clipboard.GetText();
            }
        }

        private void FontBackColorToolStripButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                TextEdit.SelectionBackColor = colorDialog1.Color;
                TextEdit.Focus();
            }
        }

        private void BoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BoldToolStripMenuItem.Checked)
            {
                BoldToolStripButton.Checked = true;
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | FontStyle.Bold);
            }
            else
            {
                BoldToolStripButton.Checked = false;
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Bold);
            }
        }

        private void ItalicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ItalicToolStripMenuItem.Checked)
            {
                ItalicToolStripButton.Checked = true;
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | FontStyle.Italic);
            }
            else
            {
                ItalicToolStripButton.Checked = false;
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Italic);
            }
        }

        private void UnderlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UnderlineToolStripMenuItem.Checked)
            {
                UnderlineToolStripButton.Checked = true;
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | FontStyle.Underline);
            } 
            else
            {
                UnderlineToolStripButton.Checked = false;
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Underline);
            }          
        }

        private void LeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeftToolStripButton.Checked = true;
            if (CenterToolStripMenuItem.Checked) CenterToolStripButton.Checked = false; CenterToolStripMenuItem.Checked = false;
            if (RightToolStripMenuItem.Checked) RightToolStripButton.Checked = false; RightToolStripMenuItem.Checked = false;

            TextEdit.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void CenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CenterToolStripButton.Checked = true;
            if (RightToolStripMenuItem.Checked) RightToolStripButton.Checked = false; RightToolStripMenuItem.Checked = false;
            if (LeftToolStripMenuItem.Checked) LeftToolStripButton.Checked = false; LeftToolStripMenuItem.Checked = false;

            if (TextEdit.SelectionAlignment == HorizontalAlignment.Center) TextEdit.SelectionAlignment = HorizontalAlignment.Left;
            else TextEdit.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void RightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RightToolStripButton.Checked = true;
            if (CenterToolStripMenuItem.Checked) CenterToolStripButton.Checked = false; CenterToolStripMenuItem.Checked = false;
            if (LeftToolStripMenuItem.Checked) LeftToolStripButton.Checked = false; LeftToolStripMenuItem.Checked = false;

            if (TextEdit.SelectionAlignment == HorizontalAlignment.Right) TextEdit.SelectionAlignment = HorizontalAlignment.Left;
            else TextEdit.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void TextEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (docChanged)
            {
                DialogResult result = MessageBox.Show("Хотите сохранить текущий документ?", "Сохранение документа", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SaveToolStripButton_Click(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
        }

        private void SizeTSComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (SizeTSComboBox.SelectedItem != null)
            {
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, Convert.ToInt16(SizeTSComboBox.SelectedItem.ToString()));
            }
            else
            {
                if (int.TryParse(SizeTSComboBox.Text, out int customSize))
                {
                    TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, customSize);
                }
            }
            TextEdit.Focus();
        }

        private void SizeInMenuToolStripComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (SizeInMenuToolStripComboBox.SelectedItem != null)
            {
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, Convert.ToInt16(SizeInMenuToolStripComboBox.SelectedItem.ToString()));
            }
            else
            {
                if (int.TryParse(SizeInMenuToolStripComboBox.Text, out int customSize))
                {
                    TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, customSize);
                }
            }
            TextEdit.Focus();
        }
    }
}