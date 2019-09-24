/*
 * Создано в SharpDevelop.
 * Пользователь: yaser
 * Дата: 14.07.2019
 * Время: 9:21
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Библиотека
{
	/// <summary>
	/// Description of FormEditOneTheme.
	/// </summary>
	public partial class FormEditOneTheme : Form
	{
		public FormEditOneTheme()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public FormEditOneTheme(string editText)
		{
			InitializeComponent();
			textBoxEdit.Text = editText;
		}
	}
}
