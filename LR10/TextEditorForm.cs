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

            openFileDialog1.Filter = "RTF files|*.rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextEdit.LoadFile(openFileDialog1.FileName);
                Text = "Текстовый редактор:   " + openFileDialog1.FileName;
            }
            path = openFileDialog1.FileName;

            docChanged = false;
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

            docChanged = false;
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

        private void ChangeFontStyle(FontStyle fs, bool needAdd)
        {
            int start = TextEdit.SelectionStart;
            int length = TextEdit.SelectionLength;
            int temp = 0;

            if(length <= 1 && TextEdit.SelectionFont != null)
            {
                if(needAdd) 
                {
                    TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | fs);
                }
                else
                {
                    TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~fs);
                }

                return;
            }

            RichTextBox textEditTemp = new RichTextBox();
            textEditTemp.Rtf = TextEdit.SelectedRtf;
            for (int i = 0; i < length; i++)
            {
                textEditTemp.Select(temp + i, 1);

                if (needAdd)
                {
                    textEditTemp.SelectionFont = new Font(textEditTemp.SelectionFont, textEditTemp.SelectionFont.Style | fs);
                }
                else
                {
                    textEditTemp.SelectionFont = new Font(textEditTemp.SelectionFont, textEditTemp.SelectionFont.Style & ~fs);
                }
            }

            textEditTemp.Select(temp, length);
            TextEdit.SelectedRtf = textEditTemp.SelectedRtf;
            TextEdit.Select(start, length);

            return;
        }


        private void BoldToolStripButton_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Bold, BoldToolStripButton.Checked);
        }

        private void ItalicToolStripButton_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Italic, ItalicToolStripButton.Checked);
        }

        private void UnderlineToolStripButton_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Underline, UnderlineToolStripButton.Checked);
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

            if (TextEdit.SelectionAlignment == HorizontalAlignment.Center)
            {
                TextEdit.SelectionAlignment = HorizontalAlignment.Left;
                LeftToolStripButton.Checked = true;
                LeftToolStripMenuItem.Checked = true;
            }
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

            if (TextEdit.SelectionAlignment == HorizontalAlignment.Right)
            {
                TextEdit.SelectionAlignment = HorizontalAlignment.Left;
                LeftToolStripButton.Checked = true;
                LeftToolStripMenuItem.Checked = true;
            }
            else TextEdit.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void CutToolStripButton_Click(object sender, EventArgs e)
        {
            if (TextEdit.SelectionLength > 0)
            {
                Clipboard.SetText(TextEdit.SelectedRtf, TextDataFormat.Rtf);
                TextEdit.SelectedText = "";
            }
        }

        private void CopyToolStripButton_Click(object sender, EventArgs e)
        {
            if (TextEdit.SelectionLength > 0)
            {
                Clipboard.SetText(TextEdit.SelectedRtf, TextDataFormat.Rtf);
            }
        }

        private void InsertToolStripButton_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                TextEdit.SelectedRtf = Clipboard.GetText(TextDataFormat.Rtf);
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
            ChangeFontStyle(FontStyle.Bold, BoldToolStripMenuItem.Checked);
        }

        private void ItalicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Italic, ItalicToolStripMenuItem.Checked);
        }

        private void UnderlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Underline, UnderlineToolStripMenuItem.Checked);
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




        private void SizeTSComboBox_DropDownClosed(object sender, EventArgs e) // ??????????????????????????
        {
            if(SizeTSComboBox.SelectedItem != null) // выбрал либо принадлежит списку
            {
                int selectSize = Convert.ToInt16(SizeTSComboBox.SelectedItem.ToString()); // выбранный либо предыдущий
                if (int.TryParse(SizeTSComboBox.Text, out int customSize) && selectSize != customSize)
                {
                    ChangeFontSize(customSize);
                }
                else
                {
                    ChangeFontSize(selectSize);
                }
            }
            else
            {
                if (int.TryParse(SizeTSComboBox.Text, out int customSize))
                {
                    ChangeFontSize(customSize);
                }
            }                            
            TextEdit.Focus();
        }


        private void SizeInMenuToolStripComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (SizeInMenuToolStripComboBox.SelectedItem != null)
            {
                ChangeFontSize(Convert.ToInt16(SizeInMenuToolStripComboBox.SelectedItem.ToString()));
            }
            else
            {
                if (int.TryParse(SizeInMenuToolStripComboBox.Text, out int customSize))
                {
                    ChangeFontSize(customSize);
                }
            }
            TextEdit.Focus();
        }

        private void ChangeFontSize(int fs)
        {
            int start = TextEdit.SelectionStart;
            int length = TextEdit.SelectionLength;
            int temp = 0;

            if (length <= 1 && TextEdit.SelectionFont != null)
            {
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, fs, TextEdit.SelectionFont.Style);
                return;
            }

            RichTextBox textEditTemp = new RichTextBox();
            textEditTemp.Rtf = TextEdit.SelectedRtf;
            for (int i = 0; i < length; i++)
            {
                textEditTemp.Select(temp + i, 1);
                textEditTemp.SelectionFont = new Font(textEditTemp.SelectionFont.FontFamily, fs, textEditTemp.SelectionFont.Style);
            }

            textEditTemp.Select(temp, length);
            TextEdit.SelectedRtf = textEditTemp.SelectedRtf;
            TextEdit.Select(start, length);

            return;
        }

        
    }
}