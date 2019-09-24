/*
 * Создано в SharpDevelop.
 * Пользователь: yaser
 * Дата: 14.07.2019
 * Время: 9:21
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Библиотека
{
	partial class FormEditOneTheme
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.TextBox textBoxEdit;
		private System.Windows.Forms.Button buttonCansel;
		private System.Windows.Forms.Button buttonOk;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditOneTheme));
			this.textBoxEdit = new System.Windows.Forms.TextBox();
			this.buttonCansel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxEdit
			// 
			this.textBoxEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxEdit.Location = new System.Drawing.Point(25, 27);
			this.textBoxEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxEdit.Name = "textBoxEdit";
			this.textBoxEdit.Size = new System.Drawing.Size(477, 26);
			this.textBoxEdit.TabIndex = 0;
			// 
			// buttonCansel
			// 
			this.buttonCansel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCansel.Location = new System.Drawing.Point(220, 61);
			this.buttonCansel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonCansel.Name = "buttonCansel";
			this.buttonCansel.Size = new System.Drawing.Size(112, 35);
			this.buttonCansel.TabIndex = 1;
			this.buttonCansel.Text = "Отмена";
			this.buttonCansel.UseVisualStyleBackColor = true;
			// 
			// buttonOk
			// 
			this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(390, 61);
			this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(112, 35);
			this.buttonOk.TabIndex = 2;
			this.buttonOk.Text = "Да";
			this.buttonOk.UseVisualStyleBackColor = true;
			// 
			// FormEditOneTheme
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(515, 102);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.buttonCansel);
			this.Controls.Add(this.textBoxEdit);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormEditOneTheme";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
