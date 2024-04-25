
namespace WindowsFormsApp148451
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonCut = new System.Windows.Forms.Button();
            this.ButtonСopy = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttoncolor = new System.Windows.Forms.Button();
            this.buttonFont = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.seal = new System.Windows.Forms.ToolStripMenuItem();
            this.preview = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.араметрыСтраницыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.cut = new System.Windows.Forms.ToolStripMenuItem();
            this.copy = new System.Windows.Forms.ToolStripMenuItem();
            this.insert = new System.Windows.Forms.ToolStripMenuItem();
            this.clean = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.color = new System.Windows.Forms.ToolStripMenuItem();
            this.font = new System.Windows.Forms.ToolStripMenuItem();
            this.alignment = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutTheProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поПравомуКраюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЦентруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЛевомуКраюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCut
            // 
            this.buttonCut.Location = new System.Drawing.Point(713, 39);
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.Size = new System.Drawing.Size(75, 23);
            this.buttonCut.TabIndex = 0;
            this.buttonCut.Text = "Вырезать";
            this.buttonCut.UseVisualStyleBackColor = true;
            this.buttonCut.Click += new System.EventHandler(this.buttonCut_Click);
            // 
            // ButtonСopy
            // 
            this.ButtonСopy.Location = new System.Drawing.Point(713, 69);
            this.ButtonСopy.Name = "ButtonСopy";
            this.ButtonСopy.Size = new System.Drawing.Size(75, 23);
            this.ButtonСopy.TabIndex = 1;
            this.ButtonСopy.Text = "Копировать";
            this.ButtonСopy.UseVisualStyleBackColor = true;
            this.ButtonСopy.Click += new System.EventHandler(this.ButtonСopy_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(713, 98);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 2;
            this.buttonInsert.Text = "Вставить";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(713, 127);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(75, 23);
            this.buttonclear.TabIndex = 3;
            this.buttonclear.Text = "Очистить";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // buttoncolor
            // 
            this.buttoncolor.Location = new System.Drawing.Point(713, 234);
            this.buttoncolor.Name = "buttoncolor";
            this.buttoncolor.Size = new System.Drawing.Size(75, 23);
            this.buttoncolor.TabIndex = 5;
            this.buttoncolor.Text = "Цвет";
            this.buttoncolor.UseVisualStyleBackColor = true;
            this.buttoncolor.Click += new System.EventHandler(this.buttoncolor_Click);
            // 
            // buttonFont
            // 
            this.buttonFont.Location = new System.Drawing.Point(713, 263);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(75, 23);
            this.buttonFont.TabIndex = 6;
            this.buttonFont.Text = "Шрифт";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(713, 345);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 7;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(713, 374);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(713, 403);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.edit,
            this.сервисToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open,
            this.save,
            this.seal,
            this.preview,
            this.exit,
            this.араметрыСтраницыToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // open
            // 
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(233, 22);
            this.open.Text = "Открыть";
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(233, 22);
            this.save.Text = "Сохранить";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // seal
            // 
            this.seal.Name = "seal";
            this.seal.Size = new System.Drawing.Size(233, 22);
            this.seal.Text = "Печать";
            this.seal.Click += new System.EventHandler(this.seal_Click);
            // 
            // preview
            // 
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(233, 22);
            this.preview.Text = "Предварительный просмотр";
            this.preview.Click += new System.EventHandler(this.preview_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(233, 22);
            this.exit.Text = "Выход";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // араметрыСтраницыToolStripMenuItem
            // 
            this.араметрыСтраницыToolStripMenuItem.Name = "араметрыСтраницыToolStripMenuItem";
            this.араметрыСтраницыToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.араметрыСтраницыToolStripMenuItem.Text = "Параметры страницы";
            this.араметрыСтраницыToolStripMenuItem.Click += new System.EventHandler(this.араметрыСтраницыToolStripMenuItem_Click);
            // 
            // edit
            // 
            this.edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cut,
            this.copy,
            this.insert,
            this.clean});
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(99, 20);
            this.edit.Text = "Редактировать";
            // 
            // cut
            // 
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(139, 22);
            this.cut.Text = "Вырезать";
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // copy
            // 
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(139, 22);
            this.copy.Text = "Копировать";
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // insert
            // 
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(139, 22);
            this.insert.Text = "Вставить";
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // clean
            // 
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(139, 22);
            this.clean.Text = "Очистить";
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.color,
            this.font,
            this.alignment});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // color
            // 
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(155, 22);
            this.color.Text = "Цвет";
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // font
            // 
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(155, 22);
            this.font.Text = "Шрифт";
            this.font.Click += new System.EventHandler(this.font_Click);
            // 
            // alignment
            // 
            this.alignment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поПравомуКраюToolStripMenuItem,
            this.поЦентруToolStripMenuItem,
            this.поЛевомуКраюToolStripMenuItem});
            this.alignment.Name = "alignment";
            this.alignment.Size = new System.Drawing.Size(180, 22);
            this.alignment.Text = "Выравнивание";
            this.alignment.Click += new System.EventHandler(this.alignment_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutTheProgram});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе ";
            // 
            // AboutTheProgram
            // 
            this.AboutTheProgram.Name = "AboutTheProgram";
            this.AboutTheProgram.Size = new System.Drawing.Size(180, 22);
            this.AboutTheProgram.Text = "О программе ";
            this.AboutTheProgram.Click += new System.EventHandler(this.AboutTheProgram_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.вставитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 70);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать ";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.ButtonСopy_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать ";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.buttonCut_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить ";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // поПравомуКраюToolStripMenuItem
            // 
            this.поПравомуКраюToolStripMenuItem.Name = "поПравомуКраюToolStripMenuItem";
            this.поПравомуКраюToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поПравомуКраюToolStripMenuItem.Text = "По правому краю";
            this.поПравомуКраюToolStripMenuItem.Click += new System.EventHandler(this.поПравомуКраюToolStripMenuItem_Click);
            // 
            // поЦентруToolStripMenuItem
            // 
            this.поЦентруToolStripMenuItem.Name = "поЦентруToolStripMenuItem";
            this.поЦентруToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поЦентруToolStripMenuItem.Text = "По центру";
            this.поЦентруToolStripMenuItem.Click += new System.EventHandler(this.поЦентруToolStripMenuItem_Click);
            // 
            // поЛевомуКраюToolStripMenuItem
            // 
            this.поЛевомуКраюToolStripMenuItem.Name = "поЛевомуКраюToolStripMenuItem";
            this.поЛевомуКраюToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поЛевомуКраюToolStripMenuItem.Text = "По левому краю";
            this.поЛевомуКраюToolStripMenuItem.Click += new System.EventHandler(this.поЛевомуКраюToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Location = new System.Drawing.Point(0, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(707, 397);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonFont);
            this.Controls.Add(this.buttoncolor);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.ButtonСopy);
            this.Controls.Add(this.buttonCut);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Текстовый редактор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCut;
        private System.Windows.Forms.Button ButtonСopy;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button buttoncolor;
        private System.Windows.Forms.Button buttonFont;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem seal;
        private System.Windows.Forms.ToolStripMenuItem preview;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem cut;
        private System.Windows.Forms.ToolStripMenuItem copy;
        private System.Windows.Forms.ToolStripMenuItem insert;
        private System.Windows.Forms.ToolStripMenuItem clean;
        private System.Windows.Forms.ToolStripMenuItem color;
        private System.Windows.Forms.ToolStripMenuItem font;
        private System.Windows.Forms.ToolStripMenuItem alignment;
        private System.Windows.Forms.ToolStripMenuItem AboutTheProgram;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem араметрыСтраницыToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поПравомуКраюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЦентруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЛевомуКраюToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

