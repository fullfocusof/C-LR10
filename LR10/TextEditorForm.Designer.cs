namespace LR10
{
    partial class TextEditorForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditorForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItalicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnderlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SizeInMenuToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontBackColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.CreateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CopyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.InsertToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.HelpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BoldToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ItalicToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UnderlineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SizeTSComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.FontColorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FontBackColorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FontToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LeftToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CenterToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RightToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.TextEdit = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MainMenu.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.BuffToolStripMenuItem,
            this.FontToolStripMenuItem,
            this.AllignToolStripMenuItem,
            this.FontStyleToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MainMenu.Size = new System.Drawing.Size(800, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.CheckOnClick = true;
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.CreateToolStripMenuItem.Text = "Создать";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripButton_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripButton_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripButton_Click);
            // 
            // BuffToolStripMenuItem
            // 
            this.BuffToolStripMenuItem.CheckOnClick = true;
            this.BuffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem});
            this.BuffToolStripMenuItem.Name = "BuffToolStripMenuItem";
            this.BuffToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.BuffToolStripMenuItem.Text = "Буфер обмена";
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.CutToolStripMenuItem.Text = "Вырезать";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripButton_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.CopyToolStripMenuItem.Text = "Копировать";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripButton_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.PasteToolStripMenuItem.Text = "Вставить";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.InsertToolStripButton_Click);
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BoldToolStripMenuItem,
            this.ItalicToolStripMenuItem,
            this.UnderlineToolStripMenuItem,
            this.toolStripSeparator2,
            this.SizeInMenuToolStripComboBox,
            this.toolStripSeparator1,
            this.FontColorToolStripMenuItem,
            this.FontBackColorToolStripMenuItem});
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.FontToolStripMenuItem.Text = "Шрифт";
            // 
            // BoldToolStripMenuItem
            // 
            this.BoldToolStripMenuItem.CheckOnClick = true;
            this.BoldToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoldToolStripMenuItem.Name = "BoldToolStripMenuItem";
            this.BoldToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.BoldToolStripMenuItem.Text = "Жирный";
            this.BoldToolStripMenuItem.Click += new System.EventHandler(this.BoldToolStripMenuItem_Click);
            // 
            // ItalicToolStripMenuItem
            // 
            this.ItalicToolStripMenuItem.CheckOnClick = true;
            this.ItalicToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItalicToolStripMenuItem.Name = "ItalicToolStripMenuItem";
            this.ItalicToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ItalicToolStripMenuItem.Text = "Курсив";
            this.ItalicToolStripMenuItem.Click += new System.EventHandler(this.ItalicToolStripMenuItem_Click);
            // 
            // UnderlineToolStripMenuItem
            // 
            this.UnderlineToolStripMenuItem.CheckOnClick = true;
            this.UnderlineToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnderlineToolStripMenuItem.Name = "UnderlineToolStripMenuItem";
            this.UnderlineToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.UnderlineToolStripMenuItem.Text = "Подчеркнутый";
            this.UnderlineToolStripMenuItem.Click += new System.EventHandler(this.UnderlineToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(197, 6);
            // 
            // SizeInMenuToolStripComboBox
            // 
            this.SizeInMenuToolStripComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "24",
            "28",
            "32",
            "36",
            "40"});
            this.SizeInMenuToolStripComboBox.Name = "SizeInMenuToolStripComboBox";
            this.SizeInMenuToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.SizeInMenuToolStripComboBox.DropDownClosed += new System.EventHandler(this.SizeInMenuToolStripComboBox_DropDownClosed);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // FontColorToolStripMenuItem
            // 
            this.FontColorToolStripMenuItem.ForeColor = System.Drawing.Color.IndianRed;
            this.FontColorToolStripMenuItem.Name = "FontColorToolStripMenuItem";
            this.FontColorToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.FontColorToolStripMenuItem.Text = "Цвет текста";
            this.FontColorToolStripMenuItem.Click += new System.EventHandler(this.FontColorToolStripButton_Click);
            // 
            // FontBackColorToolStripMenuItem
            // 
            this.FontBackColorToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.FontBackColorToolStripMenuItem.Name = "FontBackColorToolStripMenuItem";
            this.FontBackColorToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.FontBackColorToolStripMenuItem.Text = "Цвет выделения текста";
            this.FontBackColorToolStripMenuItem.Click += new System.EventHandler(this.FontBackColorToolStripButton_Click);
            // 
            // AllignToolStripMenuItem
            // 
            this.AllignToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LeftToolStripMenuItem,
            this.CenterToolStripMenuItem,
            this.RightToolStripMenuItem});
            this.AllignToolStripMenuItem.Name = "AllignToolStripMenuItem";
            this.AllignToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.AllignToolStripMenuItem.Text = "Абзац";
            // 
            // LeftToolStripMenuItem
            // 
            this.LeftToolStripMenuItem.CheckOnClick = true;
            this.LeftToolStripMenuItem.Name = "LeftToolStripMenuItem";
            this.LeftToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.LeftToolStripMenuItem.Text = "Выравнивание по левому краю";
            this.LeftToolStripMenuItem.Click += new System.EventHandler(this.LeftToolStripMenuItem_Click);
            // 
            // CenterToolStripMenuItem
            // 
            this.CenterToolStripMenuItem.CheckOnClick = true;
            this.CenterToolStripMenuItem.Name = "CenterToolStripMenuItem";
            this.CenterToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.CenterToolStripMenuItem.Text = "Выравнивание по центру";
            this.CenterToolStripMenuItem.Click += new System.EventHandler(this.CenterToolStripMenuItem_Click);
            // 
            // RightToolStripMenuItem
            // 
            this.RightToolStripMenuItem.CheckOnClick = true;
            this.RightToolStripMenuItem.Name = "RightToolStripMenuItem";
            this.RightToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.RightToolStripMenuItem.Text = "Выравнивание по правому краю";
            this.RightToolStripMenuItem.Click += new System.EventHandler(this.RightToolStripMenuItem_Click);
            // 
            // FontStyleToolStripMenuItem
            // 
            this.FontStyleToolStripMenuItem.Name = "FontStyleToolStripMenuItem";
            this.FontStyleToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.FontStyleToolStripMenuItem.Text = "Стили";
            this.FontStyleToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripButton_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.HelpToolStripMenuItem.Text = "Справка";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripButton_Click);
            // 
            // ToolStrip
            // 
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripButton,
            this.OpenToolStripButton,
            this.SaveToolStripButton,
            this.CutToolStripButton,
            this.CopyToolStripButton,
            this.InsertToolStripButton,
            this.HelpToolStripButton,
            this.BoldToolStripButton,
            this.ItalicToolStripButton,
            this.UnderlineToolStripButton,
            this.SizeTSComboBox,
            this.FontColorToolStripButton,
            this.FontBackColorToolStripButton,
            this.FontToolStripButton,
            this.LeftToolStripButton,
            this.CenterToolStripButton,
            this.RightToolStripButton});
            this.ToolStrip.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip.Size = new System.Drawing.Size(800, 25);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "ToolStrip";
            // 
            // CreateToolStripButton
            // 
            this.CreateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CreateToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateToolStripButton.Image")));
            this.CreateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateToolStripButton.Name = "CreateToolStripButton";
            this.CreateToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CreateToolStripButton.Text = "Создать";
            this.CreateToolStripButton.Click += new System.EventHandler(this.CreateToolStripButton_Click);
            // 
            // OpenToolStripButton
            // 
            this.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripButton.Image")));
            this.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripButton.Name = "OpenToolStripButton";
            this.OpenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.OpenToolStripButton.Text = "Открыть";
            this.OpenToolStripButton.Click += new System.EventHandler(this.OpenToolStripButton_Click);
            // 
            // SaveToolStripButton
            // 
            this.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripButton.Image")));
            this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripButton.Name = "SaveToolStripButton";
            this.SaveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SaveToolStripButton.Text = "Сохранить";
            this.SaveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButton_Click);
            // 
            // CutToolStripButton
            // 
            this.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CutToolStripButton.Image")));
            this.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CutToolStripButton.Name = "CutToolStripButton";
            this.CutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CutToolStripButton.Text = "Вырезать";
            this.CutToolStripButton.Click += new System.EventHandler(this.CutToolStripButton_Click);
            // 
            // CopyToolStripButton
            // 
            this.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyToolStripButton.Image")));
            this.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyToolStripButton.Name = "CopyToolStripButton";
            this.CopyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CopyToolStripButton.Text = "Копировать";
            this.CopyToolStripButton.Click += new System.EventHandler(this.CopyToolStripButton_Click);
            // 
            // InsertToolStripButton
            // 
            this.InsertToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InsertToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("InsertToolStripButton.Image")));
            this.InsertToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InsertToolStripButton.Name = "InsertToolStripButton";
            this.InsertToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.InsertToolStripButton.Text = "Вставка";
            this.InsertToolStripButton.Click += new System.EventHandler(this.InsertToolStripButton_Click);
            // 
            // HelpToolStripButton
            // 
            this.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HelpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpToolStripButton.Image")));
            this.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpToolStripButton.Name = "HelpToolStripButton";
            this.HelpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.HelpToolStripButton.Text = "Справка";
            this.HelpToolStripButton.Click += new System.EventHandler(this.HelpToolStripButton_Click);
            // 
            // BoldToolStripButton
            // 
            this.BoldToolStripButton.CheckOnClick = true;
            this.BoldToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BoldToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoldToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BoldToolStripButton.Image")));
            this.BoldToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldToolStripButton.Name = "BoldToolStripButton";
            this.BoldToolStripButton.Size = new System.Drawing.Size(25, 22);
            this.BoldToolStripButton.Text = "Ж";
            this.BoldToolStripButton.Click += new System.EventHandler(this.BoldToolStripButton_Click);
            // 
            // ItalicToolStripButton
            // 
            this.ItalicToolStripButton.CheckOnClick = true;
            this.ItalicToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ItalicToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItalicToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ItalicToolStripButton.Image")));
            this.ItalicToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalicToolStripButton.Name = "ItalicToolStripButton";
            this.ItalicToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ItalicToolStripButton.Text = "К";
            this.ItalicToolStripButton.Click += new System.EventHandler(this.ItalicToolStripButton_Click);
            // 
            // UnderlineToolStripButton
            // 
            this.UnderlineToolStripButton.CheckOnClick = true;
            this.UnderlineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UnderlineToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.UnderlineToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UnderlineToolStripButton.Image")));
            this.UnderlineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnderlineToolStripButton.Name = "UnderlineToolStripButton";
            this.UnderlineToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.UnderlineToolStripButton.Text = "Ч";
            this.UnderlineToolStripButton.Click += new System.EventHandler(this.UnderlineToolStripButton_Click);
            // 
            // SizeTSComboBox
            // 
            this.SizeTSComboBox.AutoSize = false;
            this.SizeTSComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "24",
            "28",
            "32",
            "36",
            "40"});
            this.SizeTSComboBox.Name = "SizeTSComboBox";
            this.SizeTSComboBox.Size = new System.Drawing.Size(55, 23);
            this.SizeTSComboBox.Text = "12";
            this.SizeTSComboBox.DropDownClosed += new System.EventHandler(this.SizeTSComboBox_DropDownClosed);
            // 
            // FontColorToolStripButton
            // 
            this.FontColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FontColorToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FontColorToolStripButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.FontColorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FontColorToolStripButton.Image")));
            this.FontColorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontColorToolStripButton.Name = "FontColorToolStripButton";
            this.FontColorToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.FontColorToolStripButton.Text = "A";
            this.FontColorToolStripButton.Click += new System.EventHandler(this.FontColorToolStripButton_Click);
            // 
            // FontBackColorToolStripButton
            // 
            this.FontBackColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FontBackColorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FontBackColorToolStripButton.Image")));
            this.FontBackColorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontBackColorToolStripButton.Name = "FontBackColorToolStripButton";
            this.FontBackColorToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.FontBackColorToolStripButton.Text = "Цвет выделения текста";
            this.FontBackColorToolStripButton.Click += new System.EventHandler(this.FontBackColorToolStripButton_Click);
            // 
            // FontToolStripButton
            // 
            this.FontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FontToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FontToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FontToolStripButton.Image")));
            this.FontToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontToolStripButton.Name = "FontToolStripButton";
            this.FontToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.FontToolStripButton.Text = "F";
            this.FontToolStripButton.Click += new System.EventHandler(this.FontToolStripButton_Click);
            // 
            // LeftToolStripButton
            // 
            this.LeftToolStripButton.CheckOnClick = true;
            this.LeftToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LeftToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("LeftToolStripButton.Image")));
            this.LeftToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LeftToolStripButton.Name = "LeftToolStripButton";
            this.LeftToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.LeftToolStripButton.Text = "Выравнивание по левому краю";
            this.LeftToolStripButton.Click += new System.EventHandler(this.LeftToolStripButton_Click);
            // 
            // CenterToolStripButton
            // 
            this.CenterToolStripButton.CheckOnClick = true;
            this.CenterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CenterToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CenterToolStripButton.Image")));
            this.CenterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CenterToolStripButton.Name = "CenterToolStripButton";
            this.CenterToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CenterToolStripButton.Text = "Выравнивание по центру";
            this.CenterToolStripButton.Click += new System.EventHandler(this.CenterToolStripButton_Click);
            // 
            // RightToolStripButton
            // 
            this.RightToolStripButton.CheckOnClick = true;
            this.RightToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RightToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("RightToolStripButton.Image")));
            this.RightToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RightToolStripButton.Name = "RightToolStripButton";
            this.RightToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.RightToolStripButton.Text = "Выравнивание по правому краю";
            this.RightToolStripButton.Click += new System.EventHandler(this.RightToolStripButton_Click);
            // 
            // TextEdit
            // 
            this.TextEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextEdit.Location = new System.Drawing.Point(0, 49);
            this.TextEdit.Name = "TextEdit";
            this.TextEdit.Size = new System.Drawing.Size(800, 401);
            this.TextEdit.TabIndex = 2;
            this.TextEdit.Text = "";
            this.TextEdit.SelectionChanged += new System.EventHandler(this.TextEdit_SelectionChanged);
            this.TextEdit.TextChanged += new System.EventHandler(this.TextEdit_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Left.ico");
            this.imageList1.Images.SetKeyName(1, "Center.ico");
            this.imageList1.Images.SetKeyName(2, "Right.ico");
            // 
            // TextEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextEdit);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "TextEditorForm";
            this.Text = "Текстовый редактор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextEditorForm_FormClosing);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton CreateToolStripButton;
        private System.Windows.Forms.ToolStripButton OpenToolStripButton;
        private System.Windows.Forms.ToolStripButton SaveToolStripButton;
        private System.Windows.Forms.ToolStripButton CutToolStripButton;
        private System.Windows.Forms.ToolStripButton CopyToolStripButton;
        private System.Windows.Forms.ToolStripButton InsertToolStripButton;
        private System.Windows.Forms.ToolStripButton HelpToolStripButton;
        private System.Windows.Forms.RichTextBox TextEdit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton BoldToolStripButton;
        private System.Windows.Forms.ToolStripButton ItalicToolStripButton;
        private System.Windows.Forms.ToolStripButton UnderlineToolStripButton;
        private System.Windows.Forms.ToolStripComboBox SizeTSComboBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton FontColorToolStripButton;
        private System.Windows.Forms.ToolStripButton FontBackColorToolStripButton;
        private System.Windows.Forms.ToolStripButton FontToolStripButton;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripButton LeftToolStripButton;
        private System.Windows.Forms.ToolStripButton CenterToolStripButton;
        private System.Windows.Forms.ToolStripButton RightToolStripButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AllignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BoldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItalicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnderlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox SizeInMenuToolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem FontColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontBackColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CenterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RightToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

