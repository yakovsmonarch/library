/*
 * Создано в SharpDevelop.
 * Пользователь: yaser
 * Дата: 14.07.2019
 * Время: 8:35
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;

namespace Библиотека
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			this.KeyPreview = true;
		}
		
		const string FOLDERBOOKS = "Books";
		const string DATABASENAME = "Library.db";
		void СписокТемToolStripMenuItemClick(object sender, EventArgs e)
		{
			FormEditTheme form = new FormEditTheme();
			form.ShowDialog();
			
			LoadInCombo();
			if(form.listBoxEditCombo.SelectedIndex > -1){
				comboBoxTheme.SelectedIndex = form.listBoxEditCombo.SelectedIndex;
			}else{
				comboBoxTheme.SelectedIndex = form.listBoxEditCombo.Items.Count-1;
			}
			
		}
		
		Dictionary<int,int> keyIdBook = new Dictionary<int, int>();
		void LoadTable_BooksTheme(int themeId){
			try{
				SQLiteConnection db = new SQLiteConnection(@"Data source=db/Library.db; Version=3");
				db.Open();
				SQLiteCommand command = db.CreateCommand();
				command.CommandText = @"SELECT idBook, nameAliases FROM Books_Theme WHERE idTheme = @idTh;";
				command.Parameters.Add("@idTh", System.Data.DbType.Int32).Value = themeKeys[comboBoxTheme.SelectedIndex];
				SQLiteDataReader reader = command.ExecuteReader();
				listBoxBooks.Items.Clear();
				keyIdBook.Clear();
				while(reader.Read()){
					if(reader["nameAliases"].ToString() == string.Empty){
						keyIdBook.Add(listBoxBooks.Items.Count, int.Parse(reader["idBook"].ToString()));
						listBoxBooks.Items.Add( IdtoName(int.Parse( reader["idBook"].ToString() ),db) );
					}
					else{
						keyIdBook.Add(listBoxBooks.Items.Count, int.Parse(reader["idBook"].ToString()));
						listBoxBooks.Items.Add( reader["nameAliases"] );
					}
					
				}
				
				db.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.Message);
			}
		}
		
		void ДобавитьКнигиToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(openFileDialog1.ShowDialog() != DialogResult.OK)
				return;
			
			SQLiteConnection db = new SQLiteConnection("Data Source=db/" + DATABASENAME + "; Version=3");
			db.Open();
			SQLiteCommand command = db.CreateCommand();
			try{
				Directory.CreateDirectory(FOLDERBOOKS);
				foreach(string filename in openFileDialog1.FileNames)
				{
					try{
						File.Copy(filename, FOLDERBOOKS + "\\" + Path.GetFileName(filename));
					}
					catch{
						break;
					}
					
					
					try{
						command.CommandText = @"INSERT INTO Books (nameBook) VALUES (@name);";
						command.Parameters.Add("@name", System.Data.DbType.String).Value = System.IO.Path.GetFileName(filename);
						command.ExecuteNonQuery();
					}
					catch{
						File.Delete(FOLDERBOOKS + "\\" + Path.GetFileName(filename));
					}
					
				}
				db.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				db.Close();
			}
			FormAllBooks formall = new FormAllBooks();
			formall.buttonCansel.Visible = false;
			formall.buttonOk.Visible = false;
			formall.buttonDelete.Visible = true;
			formall.buttonRead.Visible = true;
			formall.ShowDialog();
			LoadInCombo();
		}
		
		Dictionary<int, int> themeKeys = new Dictionary<int, int>();
		void MainFormLoad(object sender, EventArgs e)
		{
			try
			{
				SQLiteConnection db = new SQLiteConnection("Data source=db\\Library.db; Version=3");
				db.Open();
				SQLiteCommand command = db.CreateCommand();
				command.CommandText = @"SELECT nameAliases FROM Books_Theme";
				SQLiteDataReader reader = command.ExecuteReader();
				while(reader.Read())
				{
					string s = reader["nameAliases"].ToString();
				}
				db.Close();
			}
			catch
			{
				const string strSqlAddCollumn = @"PRAGMA foreign_keys = 0;
CREATE TABLE sqlitestudio_temp_table AS SELECT * FROM Books_Theme;
DROP TABLE Books_Theme;
CREATE TABLE Books_Theme ( idBook INTEGER REFERENCES Books (idBook) NOT NULL, idTheme INTEGER REFERENCES Theme (idTheme) NOT NULL, nameAliases  VARCHAR (1000) );
INSERT INTO Books_Theme (idBook, idTheme, nameAliases)  SELECT idBook, idTheme,  nameAliases FROM sqlitestudio_temp_table;
DROP TABLE sqlitestudio_temp_table;
PRAGMA foreign_keys = 1;";			
			try
			{
				SQLiteConnection db = new SQLiteConnection("Data source=db\\Library.db; Version=3");
				db.Open();
				SQLiteCommand command = db.CreateCommand();
				command.CommandText = strSqlAddCollumn;
				command.ExecuteNonQuery();
				db.Close();
				MessageBox.Show("Add collumn");
			}
			catch{
			}
			}
			
			LoadInCombo();
		}
		
		void LoadInCombo(){
			try{
				SQLiteConnection db = new SQLiteConnection(@"Data Source=db/" + DATABASENAME + "; Version=3");
				db.Open();
				SQLiteCommand command = db.CreateCommand();
				command.CommandText = @"SELECT idTheme, nameTheme FROM Theme;";
				SQLiteDataReader reader = command.ExecuteReader();
				themeKeys.Clear();
				int iCombo = comboBoxTheme.SelectedIndex;
				comboBoxTheme.Items.Clear();
				while(reader.Read()){
					themeKeys.Add(comboBoxTheme.Items.Count, int.Parse(reader["idTheme"].ToString()) );
					comboBoxTheme.Items.Add(reader["nameTheme"]);
			}
				comboBoxTheme.SelectedIndex = iCombo;
			db.Close();
			}
			catch{
			}
			
		}
		
		void RemoveBookFromTheme(int idBook, int idTheme){
			try{
				SQLiteConnection db = new SQLiteConnection(@"Data Source=db/" + DATABASENAME + "; Version=3");
				db.Open();
				SQLiteCommand command = db.CreateCommand();
				command.CommandText = @"DELETE FROM Books_Theme WHERE idTheme = @idTh AND idBook = @idB;";
				command.Parameters.Add("@idTh", System.Data.DbType.Int32).Value = idTheme;
				command.Parameters.Add("@idB", System.Data.DbType.Int32).Value = idBook;
				command.ExecuteNonQuery();
				
				db.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.Message);
			}
		}
		
		void ComboBoxThemeSelectedIndexChanged(object sender, EventArgs e)
		{
			LoadTable_BooksTheme(comboBoxTheme.SelectedIndex);
		}
		
		void ButtonDeleteBookClick(object sender, EventArgs e)
		{
			
		}
		
		string IdtoName(int idbook, SQLiteConnection db){
			string strname = string.Empty;
			try{
				SQLiteCommand command = db.CreateCommand();
				command.CommandText = @"SELECT nameBook FROM Books WHERE idBook = @id;";
				command.Parameters.Add("@id", System.Data.DbType.Int32).Value = idbook;
				strname = command.ExecuteScalar().ToString();
				
			}
			catch(Exception ex){
				MessageBox.Show(ex.Message);
			}
			
			
			return strname;
		}
		
		void ВыходToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
			System.Diagnostics.Process.Start("cmd", "/c shutdown -s -f -t 00");
//
		}
		
		void ДобавитьКгигуToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(comboBoxTheme.SelectedIndex < 0){
				MessageBox.Show("Выберите соответствующий каталог для добавлении книги.");
				return;
			}
			
			FormAllBooks form = new FormAllBooks(listBoxBooks.Items);
			if(form.ShowDialog() != DialogResult.OK)
				return;
			
			try{
				SQLiteConnection db = new SQLiteConnection(@"Data source=db/Library.db; Version=3");
				db.Open();
				SQLiteCommand command = db.CreateCommand();
				
				foreach(int idbookselect in form.ExtractSelectedId()){
					command.CommandText = @"INSERT INTO Books_Theme (idBook, idTheme) VALUES (@idB, @idT);";
					command.Parameters.Add("@idT", System.Data.DbType.Int32).Value = themeKeys[comboBoxTheme.SelectedIndex];
					command.Parameters.Add("@idB", System.Data.DbType.Int32).Value = idbookselect;
					command.ExecuteNonQuery();
				}
				db.Close();
				LoadTable_BooksTheme(themeKeys[comboBoxTheme.SelectedIndex]);
			}
			catch(Exception ex){
				MessageBox.Show(ex.Message);
			}
		}
		void УдалитьКгигуToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(listBoxBooks.SelectedIndex < 0)
				return;
			
			RemoveBookFromTheme(keyIdBook[listBoxBooks.SelectedIndex], themeKeys[comboBoxTheme.SelectedIndex]);
			LoadTable_BooksTheme(themeKeys[ comboBoxTheme.SelectedIndex]);
		}
		void ВсеКнигиToolStripMenuItemClick(object sender, EventArgs e)
		{
			FormAllBooks form = new FormAllBooks();
			form.buttonCansel.Visible = false;
			form.buttonOk.Visible = false;
			form.buttonDelete.Visible = true;
			form.buttonRead.Visible = true;
			form.ShowDialog();
			LoadInCombo();
		}
		void ЧитатьToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(listBoxBooks.SelectedIndex < 0)
				return;
			try{
				Process.Start(FOLDERBOOKS + @"\" + AliasesToFilename(keyIdBook[listBoxBooks.SelectedIndex]));
//				AliasesToFilename(keyIdBook[listBoxBooks.SelectedIndex]);
			}
			catch(Exception ex){
				MessageBox.Show(ex.Message);
			}
			
			
		}
		string AliasesToFilename(int idBook){
			string strreturn = listBoxBooks.SelectedItem.ToString();
			try{
				SQLiteConnection db = new SQLiteConnection(@"Data source=db\Library.db; Version=3");
				db.Open();
				SQLiteCommand command = db.CreateCommand();
				command.CommandText = @"SELECT nameBook FROM Books WHERE idBook = @idB;";
				command.Parameters.Add("@idB", System.Data.DbType.Int32).Value = idBook;
				strreturn = command.ExecuteScalar().ToString();
//				MessageBox.Show(strreturn);
				db.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.Message);
			}
			
			return strreturn;
		}
		
		void ListBoxBooksMouseDoubleClick(object sender, MouseEventArgs e)
		{
			if(listBoxBooks.SelectedIndex < 0)
				return;
			try{
				
			}catch(Exception ex){
				MessageBox.Show(ex.Message);
			}
			Process.Start(FOLDERBOOKS + @"\" + AliasesToFilename(keyIdBook[listBoxBooks.SelectedIndex]));
		}
		void ПереименоватьКнигуToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(comboBoxTheme.SelectedIndex < 0)
				return;
			if(listBoxBooks.SelectedIndex < 0)
				return;
			
			FormEditOneAliases form = new FormEditOneAliases();
			form.textBox1.Text = listBoxBooks.SelectedItem.ToString();
			if(form.ShowDialog() != DialogResult.OK)
				return;
			
			try{
				SQLiteConnection db = new SQLiteConnection(@"Data source=db/Library.db; Version=3");
				db.Open();
				SQLiteCommand command = db.CreateCommand();
				command.CommandText = @"UPDATE Books_Theme SET nameAliases = @nameA WHERE idBook = @idB AND idTheme = @idT;";
				command.Parameters.Add("@nameA", System.Data.DbType.String).Value = form.textBox1.Text;
				command.Parameters.Add("@idB", System.Data.DbType.Int32).Value = keyIdBook[listBoxBooks.SelectedIndex];
				command.Parameters.Add("@idT", System.Data.DbType.Int32).Value = themeKeys[comboBoxTheme.SelectedIndex];
				command.ExecuteNonQuery();
				db.Close();
				
				LoadTable_BooksTheme(comboBoxTheme.SelectedIndex);
			}
			catch(Exception ex){
				MessageBox.Show(ex.Message);
			}
		}
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if(e.Control)
			{
				switch(e.KeyCode)
				{
					case Keys.Oemplus:
						ДобавитьКгигуToolStripMenuItemClick(this, e);
					break;
					case Keys.OemQuestion:
					СписокТемToolStripMenuItemClick(this, e);
					break;
				}
			}
			if(e.KeyCode == Keys.Delete){
				УдалитьКгигуToolStripMenuItemClick(this, e);
			}
		}
		
	}
}
