/*
 * Создано в SharpDevelop.
 * Пользователь: yaser
 * Дата: 14.07.2019
 * Время: 9:16
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Collections.Generic;

namespace Библиотека
{
	/// <summary>
	/// Description of FormEditTheme.
	/// </summary>
	public partial class FormEditTheme : Form
	{
		public FormEditTheme()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ButtonAddClick(object sender, EventArgs e)
		{
			FormEditOneTheme form = new FormEditOneTheme();
			if(form.ShowDialog() != DialogResult.OK)
				return;
			if(form.textBoxEdit.Text == string.Empty)
				return;
			
			using(SQLiteConnection db = new SQLiteConnection("Data Source=db/" + DATABASENAME + "; Version=3")){
				try{
					db.Open();
					SQLiteCommand command = db.CreateCommand();
					command.CommandText = @"INSERT INTO Theme (nameTheme) VALUES (@name);";
					command.Parameters.Add("@name", System.Data.DbType.String).Value = form.textBoxEdit.Text;
					command.ExecuteNonQuery();
					themesId.Add(listBoxEditCombo.Items.Count, currentId += 1);
					listBoxEditCombo.Items.Add(form.textBoxEdit.Text);
					
					db.Close();
				}
				catch(Exception ex){
					MessageBox.Show(ex.Message);
					db.Close();
				}
				
			}
			
			
		}
		
		const string FOLDERBOOKS = "Books";
		const string DATABASENAME = "Library.db";
		Dictionary<int, int> themesId = new Dictionary<int, int>();
		int currentId = 0;
		void FormEditThemeLoad(object sender, EventArgs e)
		{
			LoadAllCatalog();
		}
		void ButtonEditClick(object sender, EventArgs e)
		{
			if(listBoxEditCombo.SelectedIndex < 0)
				return;
			
			FormEditOneTheme formOne = new FormEditOneTheme(listBoxEditCombo.SelectedItem.ToString());
			if(formOne.ShowDialog() != DialogResult.OK)
				return;
			
			 try{
				SQLiteConnection db = new SQLiteConnection("Data source = db/Library.db; Version=3");
				db.Open();
				SQLiteCommand command = db.CreateCommand();
				
				command.CommandText = @"UPDATE Theme SET nameTheme = @nametheme WHERE idTheme = @idtheme;";
				command.Parameters.Add("@idtheme", System.Data.DbType.Int32).Value = themesId [listBoxEditCombo.SelectedIndex];
				
				command.Parameters.Add("@nametheme", System.Data.DbType.String).Value = formOne.textBoxEdit.Text;
				command.ExecuteNonQuery();
				db.Close();
				LoadAllCatalog();
			}
			catch(Exception ex){
				MessageBox.Show(ex.Message);
			}
			
		}
		void ButtonOkClick(object sender, EventArgs e)
		{
			Close();
		}
		void ButtonDeleteClick(object sender, EventArgs e)
		{
			try{
				SQLiteConnection db = new SQLiteConnection("Data source = db/Library.db; Version=3");
				db.Open();
				SQLiteCommand command = db.CreateCommand();
				
				command.CommandText = @"DELETE FROM Books_Theme WHERE idTheme = @idtheme;";
				command.Parameters.Add("@idtheme", System.Data.DbType.Int32).Value = themesId [listBoxEditCombo.SelectedIndex];
				command.ExecuteNonQuery();
					
					
				command.CommandText = @"DELETE FROM Theme WHERE idTheme = @idtheme2;";
				command.Parameters.Add("@idtheme2", System.Data.DbType.Int32).Value = themesId [listBoxEditCombo.SelectedIndex];
				command.ExecuteNonQuery();
					
//				themesId.Remove(listBoxEditCombo.SelectedIndex);
//				listBoxEditCombo.Items.RemoveAt(listBoxEditCombo.SelectedIndex);
				db.Close();
				LoadAllCatalog();
			}
			catch(Exception ex){
				MessageBox.Show(ex.Message);
			}
			
		}
		
		void LoadAllCatalog()
		{
			listBoxEditCombo.Items.Clear();
			themesId.Clear();
			try
			{
				SQLiteConnection db = new SQLiteConnection("Data Source=db/" + DATABASENAME + "; Version=3");
				db.Open();
				SQLiteCommand command = db.CreateCommand();
				command.CommandText = @"SELECT idTheme, nameTheme FROM Theme;";
				SQLiteDataReader reader = command.ExecuteReader();
				while(reader.Read()){
					themesId.Add(listBoxEditCombo.Items.Count, int.Parse(reader["idTheme"].ToString()));
					currentId = int.Parse( reader["idTheme"].ToString());
					listBoxEditCombo.Items.Add(reader["nameTheme"]);
			}
				db.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
