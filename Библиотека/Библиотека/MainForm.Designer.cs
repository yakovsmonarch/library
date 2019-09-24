/*
 * Создано в SharpDevelop.
 * Пользователь: yaser
 * Дата: 14.07.2019
 * Время: 8:35
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Библиотека
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox comboBoxTheme;
		private System.Windows.Forms.ListBox listBoxBooks;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem списокТемToolStripMenuItem;
		private System.Windows.Forms.Label labelCombo;
		private System.Windows.Forms.Label labelList;
		private System.Windows.Forms.ToolStripMenuItem добавитьКнигиToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem добавитьКгигуToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem удалитьКгигуToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem всеКнигиToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
		private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
		private System.Windows.Forms.ToolStripButton toolStripButtonEditCatalog;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripMenuItem читатьToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton toolStripButtonRead;
		private System.Windows.Forms.ToolStripMenuItem переименоватьКнигуToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.comboBoxTheme = new System.Windows.Forms.ComboBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.добавитьКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.всеКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.читатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.списокТемToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.добавитьКгигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.удалитьКгигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.переименоватьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.labelCombo = new System.Windows.Forms.Label();
			this.labelList = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.listBoxBooks = new System.Windows.Forms.ListBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonEditCatalog = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonRead = new System.Windows.Forms.ToolStripButton();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// comboBoxTheme
			// 
			this.comboBoxTheme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTheme.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBoxTheme.FormattingEnabled = true;
			this.comboBoxTheme.Items.AddRange(new object[] {
			"Тактика",
			"Стратегия",
			"Дебют",
			"Мительшпиль",
			"Эндшпиль",
			"Карпов",
			"Алехин",
			"Таль"});
			this.comboBoxTheme.Location = new System.Drawing.Point(114, 78);
			this.comboBoxTheme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxTheme.Name = "comboBoxTheme";
			this.comboBoxTheme.Size = new System.Drawing.Size(704, 27);
			this.comboBoxTheme.TabIndex = 0;
			this.comboBoxTheme.SelectedIndexChanged += new System.EventHandler(this.ComboBoxThemeSelectedIndexChanged);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.файлToolStripMenuItem,
			this.правкаToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
			this.menuStrip1.Size = new System.Drawing.Size(824, 31);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.добавитьКнигиToolStripMenuItem,
			this.всеКнигиToolStripMenuItem,
			this.читатьToolStripMenuItem,
			this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// добавитьКнигиToolStripMenuItem
			// 
			this.добавитьКнигиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("добавитьКнигиToolStripMenuItem.Image")));
			this.добавитьКнигиToolStripMenuItem.Name = "добавитьКнигиToolStripMenuItem";
			this.добавитьКнигиToolStripMenuItem.Size = new System.Drawing.Size(341, 26);
			this.добавитьКнигиToolStripMenuItem.Text = "Добавить книги в общее хранилище";
			this.добавитьКнигиToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьКнигиToolStripMenuItemClick);
			// 
			// всеКнигиToolStripMenuItem
			// 
			this.всеКнигиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("всеКнигиToolStripMenuItem.Image")));
			this.всеКнигиToolStripMenuItem.Name = "всеКнигиToolStripMenuItem";
			this.всеКнигиToolStripMenuItem.Size = new System.Drawing.Size(341, 26);
			this.всеКнигиToolStripMenuItem.Text = "Все книги";
			this.всеКнигиToolStripMenuItem.Click += new System.EventHandler(this.ВсеКнигиToolStripMenuItemClick);
			// 
			// читатьToolStripMenuItem
			// 
			this.читатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("читатьToolStripMenuItem.Image")));
			this.читатьToolStripMenuItem.Name = "читатьToolStripMenuItem";
			this.читатьToolStripMenuItem.Size = new System.Drawing.Size(341, 26);
			this.читатьToolStripMenuItem.Text = "Читать";
			this.читатьToolStripMenuItem.Click += new System.EventHandler(this.ЧитатьToolStripMenuItemClick);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem.Image")));
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(341, 26);
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItemClick);
			// 
			// правкаToolStripMenuItem
			// 
			this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.списокТемToolStripMenuItem,
			this.добавитьКгигуToolStripMenuItem,
			this.удалитьКгигуToolStripMenuItem,
			this.переименоватьКнигуToolStripMenuItem});
			this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
			this.правкаToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
			this.правкаToolStripMenuItem.Text = "Каталог";
			// 
			// списокТемToolStripMenuItem
			// 
			this.списокТемToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("списокТемToolStripMenuItem.Image")));
			this.списокТемToolStripMenuItem.Name = "списокТемToolStripMenuItem";
			this.списокТемToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
			this.списокТемToolStripMenuItem.Text = "Редактировать";
			this.списокТемToolStripMenuItem.Click += new System.EventHandler(this.СписокТемToolStripMenuItemClick);
			// 
			// добавитьКгигуToolStripMenuItem
			// 
			this.добавитьКгигуToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("добавитьКгигуToolStripMenuItem.Image")));
			this.добавитьКгигуToolStripMenuItem.Name = "добавитьКгигуToolStripMenuItem";
			this.добавитьКгигуToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
			this.добавитьКгигуToolStripMenuItem.Text = "Добавить книгу";
			this.добавитьКгигуToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьКгигуToolStripMenuItemClick);
			// 
			// удалитьКгигуToolStripMenuItem
			// 
			this.удалитьКгигуToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("удалитьКгигуToolStripMenuItem.Image")));
			this.удалитьКгигуToolStripMenuItem.Name = "удалитьКгигуToolStripMenuItem";
			this.удалитьКгигуToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
			this.удалитьКгигуToolStripMenuItem.Text = "Удалить книгу";
			this.удалитьКгигуToolStripMenuItem.Click += new System.EventHandler(this.УдалитьКгигуToolStripMenuItemClick);
			// 
			// переименоватьКнигуToolStripMenuItem
			// 
			this.переименоватьКнигуToolStripMenuItem.Name = "переименоватьКнигуToolStripMenuItem";
			this.переименоватьКнигуToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
			this.переименоватьКнигуToolStripMenuItem.Text = "Переименовать книгу";
			this.переименоватьКнигуToolStripMenuItem.Click += new System.EventHandler(this.ПереименоватьКнигуToolStripMenuItemClick);
			// 
			// labelCombo
			// 
			this.labelCombo.Location = new System.Drawing.Point(4, 78);
			this.labelCombo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelCombo.Name = "labelCombo";
			this.labelCombo.Size = new System.Drawing.Size(102, 28);
			this.labelCombo.TabIndex = 4;
			this.labelCombo.Text = "Список тем:";
			// 
			// labelList
			// 
			this.labelList.Location = new System.Drawing.Point(4, 111);
			this.labelList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelList.Name = "labelList";
			this.labelList.Size = new System.Drawing.Size(150, 26);
			this.labelList.TabIndex = 5;
			this.labelList.Text = "Книги по темам";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Multiselect = true;
			this.openFileDialog1.Title = "Выберите книги";
			// 
			// listBoxBooks
			// 
			this.listBoxBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxBooks.FormattingEnabled = true;
			this.listBoxBooks.HorizontalScrollbar = true;
			this.listBoxBooks.ItemHeight = 20;
			this.listBoxBooks.Location = new System.Drawing.Point(4, 142);
			this.listBoxBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listBoxBooks.Name = "listBoxBooks";
			this.listBoxBooks.Size = new System.Drawing.Size(814, 484);
			this.listBoxBooks.TabIndex = 1;
			this.listBoxBooks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxBooksMouseDoubleClick);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripButtonAdd,
			this.toolStripButtonDelete,
			this.toolStripButtonEditCatalog,
			this.toolStripSeparator1,
			this.toolStripButton1,
			this.toolStripButtonRead});
			this.toolStrip1.Location = new System.Drawing.Point(0, 31);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(824, 25);
			this.toolStrip1.TabIndex = 6;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButtonAdd
			// 
			this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
			this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonAdd.Name = "toolStripButtonAdd";
			this.toolStripButtonAdd.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonAdd.Text = "Добавить книгу в каталог";
			this.toolStripButtonAdd.Click += new System.EventHandler(this.ДобавитьКгигуToolStripMenuItemClick);
			// 
			// toolStripButtonDelete
			// 
			this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
			this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonDelete.Name = "toolStripButtonDelete";
			this.toolStripButtonDelete.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonDelete.Text = "Удалить кгигу из каталога";
			this.toolStripButtonDelete.Click += new System.EventHandler(this.УдалитьКгигуToolStripMenuItemClick);
			// 
			// toolStripButtonEditCatalog
			// 
			this.toolStripButtonEditCatalog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonEditCatalog.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditCatalog.Image")));
			this.toolStripButtonEditCatalog.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonEditCatalog.Name = "toolStripButtonEditCatalog";
			this.toolStripButtonEditCatalog.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonEditCatalog.Text = "Редактировать каталог";
			this.toolStripButtonEditCatalog.Click += new System.EventHandler(this.СписокТемToolStripMenuItemClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "Все книги";
			this.toolStripButton1.Click += new System.EventHandler(this.ВсеКнигиToolStripMenuItemClick);
			// 
			// toolStripButtonRead
			// 
			this.toolStripButtonRead.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonRead.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRead.Image")));
			this.toolStripButtonRead.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonRead.Name = "toolStripButtonRead";
			this.toolStripButtonRead.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonRead.Text = "Читать";
			this.toolStripButtonRead.Click += new System.EventHandler(this.ЧитатьToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 627);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.labelList);
			this.Controls.Add(this.labelCombo);
			this.Controls.Add(this.listBoxBooks);
			this.Controls.Add(this.comboBoxTheme);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Библиотека";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
