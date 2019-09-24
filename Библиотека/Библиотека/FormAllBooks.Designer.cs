/*
 * Создано в SharpDevelop.
 * Пользователь: yaser
 * Дата: 14.07.2019
 * Время: 9:34
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Библиотека
{
	partial class FormAllBooks
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Button buttonCansel;
		public System.Windows.Forms.Button buttonOk;
		public System.Windows.Forms.Button buttonDelete;
		public System.Windows.Forms.Button buttonRead;
		private System.Windows.Forms.CheckBox checkBoxAllBooks;
		private System.Windows.Forms.RadioButton radioButtonShift;
		private System.Windows.Forms.RadioButton radioButtonCtrl;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAllBooks));
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonCansel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonRead = new System.Windows.Forms.Button();
			this.checkBoxAllBooks = new System.Windows.Forms.CheckBox();
			this.radioButtonShift = new System.Windows.Forms.RadioButton();
			this.radioButtonCtrl = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.HorizontalScrollbar = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(3, 51);
			this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listBox1.Name = "listBox1";
			this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.listBox1.Size = new System.Drawing.Size(840, 464);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1SelectedIndexChanged);
			this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListBox1KeyDown);
			this.listBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListBox1KeyUp);
			this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox1MouseDoubleClick);
			this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox1MouseDown);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 21);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(320, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Все книги:";
			// 
			// buttonCansel
			// 
			this.buttonCansel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCansel.Location = new System.Drawing.Point(573, 522);
			this.buttonCansel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonCansel.Name = "buttonCansel";
			this.buttonCansel.Size = new System.Drawing.Size(130, 35);
			this.buttonCansel.TabIndex = 2;
			this.buttonCansel.Text = "Отменить";
			this.buttonCansel.UseVisualStyleBackColor = true;
			// 
			// buttonOk
			// 
			this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(712, 524);
			this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(132, 35);
			this.buttonOk.TabIndex = 3;
			this.buttonOk.Text = "Добавить";
			this.buttonOk.UseVisualStyleBackColor = true;
			// 
			// buttonDelete
			// 
			this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonDelete.Location = new System.Drawing.Point(3, 522);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(117, 35);
			this.buttonDelete.TabIndex = 4;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Visible = false;
			this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
			// 
			// buttonRead
			// 
			this.buttonRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRead.Location = new System.Drawing.Point(731, 524);
			this.buttonRead.Name = "buttonRead";
			this.buttonRead.Size = new System.Drawing.Size(113, 33);
			this.buttonRead.TabIndex = 5;
			this.buttonRead.Text = "Читать";
			this.buttonRead.UseVisualStyleBackColor = true;
			this.buttonRead.Visible = false;
			this.buttonRead.Click += new System.EventHandler(this.ButtonReadClick);
			// 
			// checkBoxAllBooks
			// 
			this.checkBoxAllBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxAllBooks.Location = new System.Drawing.Point(701, 21);
			this.checkBoxAllBooks.Name = "checkBoxAllBooks";
			this.checkBoxAllBooks.Size = new System.Drawing.Size(139, 24);
			this.checkBoxAllBooks.TabIndex = 6;
			this.checkBoxAllBooks.Text = "Выделить всё";
			this.checkBoxAllBooks.UseVisualStyleBackColor = true;
			this.checkBoxAllBooks.CheckedChanged += new System.EventHandler(this.CheckBoxAllBooksCheckedChanged);
			// 
			// radioButtonShift
			// 
			this.radioButtonShift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonShift.Location = new System.Drawing.Point(552, 19);
			this.radioButtonShift.Name = "radioButtonShift";
			this.radioButtonShift.Size = new System.Drawing.Size(56, 24);
			this.radioButtonShift.TabIndex = 7;
			this.radioButtonShift.Text = "Shift";
			this.radioButtonShift.UseVisualStyleBackColor = true;
			this.radioButtonShift.CheckedChanged += new System.EventHandler(this.RadioButtonShiftCheckedChanged);
			// 
			// radioButtonCtrl
			// 
			this.radioButtonCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonCtrl.Location = new System.Drawing.Point(487, 19);
			this.radioButtonCtrl.Name = "radioButtonCtrl";
			this.radioButtonCtrl.Size = new System.Drawing.Size(59, 24);
			this.radioButtonCtrl.TabIndex = 8;
			this.radioButtonCtrl.Text = "Ctrl";
			this.radioButtonCtrl.UseVisualStyleBackColor = true;
			this.radioButtonCtrl.CheckedChanged += new System.EventHandler(this.RadioButtonCtrlCheckedChanged);
			// 
			// FormAllBooks
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(852, 577);
			this.Controls.Add(this.radioButtonCtrl);
			this.Controls.Add(this.radioButtonShift);
			this.Controls.Add(this.checkBoxAllBooks);
			this.Controls.Add(this.buttonRead);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.buttonCansel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormAllBooks";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Все книги";
			this.Load += new System.EventHandler(this.FormAllBooksLoad);
			this.ResumeLayout(false);

		}
	}
}
