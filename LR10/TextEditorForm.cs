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

            HideAllToolStripButtons();
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
            SizeTSComboBox.Text = TextEdit.SelectionFont.Size.ToString();
        }

        private void HelpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Главный разработчик: Мельников Максим\n Контактные данные:\n GitHub - github.com/fullfocusof \n VK - vk.com/y_u_kiddin_me", "Авторы", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BoldToolStripButton_Click(object sender, EventArgs e)
        {
            if (BoldToolStripButton.Checked)
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | FontStyle.Bold);
            else
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Bold);
        }

        private void ItalicToolStripButton_Click(object sender, EventArgs e)
        {
            if (ItalicToolStripButton.Checked)
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | FontStyle.Italic);
            else
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Italic);
        }

        private void UnderlineToolStripButton_Click(object sender, EventArgs e)
        {
            if (UnderlineToolStripButton.Checked)
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style | FontStyle.Underline);
            else
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont, TextEdit.SelectionFont.Style & ~FontStyle.Underline);
        }

        private void TextEdit_SelectionChanged(object sender, EventArgs e)
        {
            if (TextEdit.SelectionFont == null) return;
            BoldToolStripButton.Checked = TextEdit.SelectionFont.Bold;
            ItalicToolStripButton.Checked = TextEdit.SelectionFont.Italic;
            UnderlineToolStripButton.Checked = TextEdit.SelectionFont.Underline;
            SizeTSComboBox.Text = TextEdit.SelectionFont.Size.ToString();

            CenterToolStripButton.Checked = TextEdit.SelectionAlignment == HorizontalAlignment.Center;
            LeftToolStripButton.Checked = TextEdit.SelectionAlignment == HorizontalAlignment.Left;
            RightToolStripButton.Checked = TextEdit.SelectionAlignment == HorizontalAlignment.Right;
        }

        private void SizeTSComboBox_DropDownClosed(object sender, EventArgs e) // не только так
        {
            if (SizeTSComboBox.SelectedItem != null)
            {
                int.TryParse(SizeTSComboBox.SelectedItem.ToString(), out int fontSize);    
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, fontSize);
            }
            else if (int.TryParse(SizeTSComboBox.Text, out int customFontSize))
            {
                TextEdit.SelectionFont = new Font(TextEdit.SelectionFont.FontFamily, customFontSize);
            }
            TextEdit.Focus();
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
            if (RightToolStripButton.Checked) RightToolStripButton.Checked = false;
            if (LeftToolStripButton.Checked) LeftToolStripButton.Checked = false;

            if (TextEdit.SelectionAlignment == HorizontalAlignment.Center) TextEdit.SelectionAlignment = HorizontalAlignment.Left;
            else TextEdit.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void LeftToolStripButton_Click(object sender, EventArgs e)
        {
            if (CenterToolStripButton.Checked) CenterToolStripButton.Checked = false;
            if (RightToolStripButton.Checked) RightToolStripButton.Checked = false;

            TextEdit.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void RightToolStripButton_Click(object sender, EventArgs e)
        {
            if (CenterToolStripButton.Checked) CenterToolStripButton.Checked = false;
            if (LeftToolStripButton.Checked) LeftToolStripButton.Checked = false;

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

        private void HideAllToolStripButtons()
        {
            foreach (ToolStripItem item in ToolStrip.Items)
            {
                if(item is ToolStripButton button)
                {
                    button.Visible = false;
                }
                if(item is ToolStripComboBox cb)
                {
                    cb.Visible = false;
                }
            }
        }

        private void Menu_Choose(object sender, EventArgs e)
        {
            var clickedItem = (ToolStripMenuItem)sender;

            if (clickedItem == FileToolStripMenuItem)
            {
                HideAllToolStripButtons();

                CreateToolStripButton.Visible = true;
                OpenToolStripButton.Visible = true;
                SaveToolStripButton.Visible = true;
            }
            else if (clickedItem == BuffToolStripMenuItem)
            {
                HideAllToolStripButtons();

                CutToolStripButton.Visible = true;
                CopyToolStripButton.Visible = true;
                InsertToolStripButton.Visible = true;
            }
            else if(clickedItem == FontToolStripMenuItem)
            {
                HideAllToolStripButtons();

                BoldToolStripButton.Visible = true;
                ItalicToolStripButton.Visible = true;
                UnderlineToolStripButton.Visible = true;
                FontColorToolStripButton.Visible = true;
                FontBackColorToolStripButton.Visible = true;
                SizeTSComboBox.Visible = true;
            }
            else if (clickedItem == AllignToolStripMenuItem)
            {
                HideAllToolStripButtons();

                LeftToolStripButton.Visible = true;
                CenterToolStripButton.Visible = true;
                RightToolStripButton.Visible = true;
            }
            else if(clickedItem == FontStyleToolStripMenuItem)
            {
                HideAllToolStripButtons();

                FontToolStripButton.Visible = true;
            }
        }
    }
}