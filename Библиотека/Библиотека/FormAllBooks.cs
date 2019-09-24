/*
 * Создано в SharpDevelop.
 * Пользователь: yaser
 * Дата: 14.07.2019
 * Время: 9:34
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Collections.Generic;

namespace Библиотека
{
	/// <summary>
	/// Description of FormAllBooks.
	/// </summary>
	public partial class FormAllBooks : Form
	{
		public FormAllBooks()
		{
			InitializeComponent();
		}
		
		public FormAllBooks(ListBox.ObjectCollection list)
		{
			InitializeComponent();
			this.inputList.Items.AddRange(list);
		}
		
		ListBox inputList = new ListBox();
		
		Dictionary<int, int> books = new Dictionary<int, int>();
		Dictionary<int,int> Books{
			get{return this.books;}
		}
		
		List<int> FilterSelected(ListBox.SelectedIndexCollection selectedInd, ListBox.ObjectCollection filesCatalog)
		{
			List<int> bufreturn = new List<int>();
			foreach(int i in selectedInd)
			{
				if(!RepeatElement(listBox1.Items[i].ToString(), inputList.Items)){
					bufreturn.Add(i);
				}
			}
			return bufreturn;
		}
		
		bool RepeatElement(string strElem, ListBox.ObjectCollection listSearch){
			foreach(string s in listSearch){
				if(strElem == s)
				{
					return true;
				}
			}
			return false;
		}
		
		public List<int> ExtractSelectedId(){
			List<int> buf = new List<int>();
			foreach(int iSelect in FilterSelected(listBox1.SelectedIndices, inputList.Items)){
				buf.Add(iSelect);
			}
			List<int> idbuf = new List<int>();
			foreach(int keyId in buf){
				idbuf.Add(books[keyId]);
			}
			return idbuf;
		}
		
		List<int[]> historyList;
		void FormAllBooksLoad(object sender, EventArgs e)
		{
			LoadAllBooks();
			label1.Text += " " + listBox1.Items.Count;
			historyList = new List<int[]>();
			historyList.Add(ListToArray(listBox1.SelectedIndices));
		}
		
		int[] ListToArray(ListBox.SelectedIndexCollection coll){
			int[] a = new int[coll.Count];
			for(int i = 0; i<a.Length; i++){
				a[i] = coll[i];
			}
			return a;
		}
		
		void ButtonDeleteClick(object sender, EventArgs e)
		{
			if(listBox1.SelectedIndex < 0){
				MessageBox.Show("Выделите книгу из списка.");
				return;
			}
			
			try
			{
					SQLiteConnection db = new SQLiteConnection(@"Data Source=db/Library.db; Version=3");
					db.Open();
					SQLiteCommand command = db.CreateCommand();
					
					foreach(int idItem in listBox1.SelectedIndices){
						command.CommandText = @"DELETE FROM Books_Theme WHERE idBook = @idbook;";
						command.Parameters.Add("@idbook", System.Data.DbType.Int32).Value = books[idItem];
						command.ExecuteNonQuery();
						
						command.CommandText = @"DELETE FROM Books WHERE idBook = @idbook2 ;";
						command.Parameters.Add("@idbook2", System.Data.DbType.Int32).Value = books[idItem];
						command.ExecuteNonQuery();
					}
					db.Close();
					foreach(string fileDel in listBox1.SelectedItems){
						File.Delete("Books" + @"\" + fileDel);
					}
					
					LoadAllBooks();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		void ButtonReadClick(object sender, EventArgs e)
		{
			if(listBox1.SelectedIndex < 0){
				MessageBox.Show("Выберите кгигу из списка.");
				return;
			}
			System.Diagnostics.Process.Start("Books" + @"\" + listBox1.SelectedItem);
		}
		void ListBox1MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if(listBox1.SelectedIndex < 0){
				MessageBox.Show("Выберите кгигу из списка.");
				return;
			}
			System.Diagnostics.Process.Start("Books" + @"\" + listBox1.SelectedItem);
		}
		
		void LoadAllBooks()
		{
			books.Clear();
			listBox1.Items.Clear();
			try
			{
				SQLiteConnection db = new SQLiteConnection(@"Data Source=db/Library.db; Version=3");
				
					db.Open();
					
					SQLiteCommand command = db.CreateCommand();
					command.CommandText = @"SELECT idBook, nameBook FROM Books;";
					SQLiteDataReader reader = command.ExecuteReader();
					while(reader.Read()){
						books.Add(listBox1.Items.Count, int.Parse( reader["idBook"].ToString() ));
						listBox1.Items.Add(reader["nameBook"]);
					}
					db.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		void CheckBoxAllBooksCheckedChanged(object sender, EventArgs e)
		{
			if(checkBoxAllBooks.Checked){
				for(int i =0; i<listBox1.Items.Count;i++){
					listBox1.SetSelected(i,true);
				}
			}else{
				listBox1.SelectedIndex = -1;
			}
		}
		
		void ListBox1KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyValue == 16){
				radioButtonShift.Checked = true;
			}
			if(e.KeyValue == 17){
				radioButtonCtrl.Checked = true;
			}
		}
		void ListBox1KeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyValue == 16){
				radioButtonShift.Checked = false;
				two = 0;
			}
			if(e.KeyValue == 17){
				radioButtonCtrl.Checked = false;
				two = 0;
			}
		}
		
		
		void ListBox1MouseDown(object sender, MouseEventArgs e)
		{
			historyList.Add(ListToArray(listBox1.SelectedIndices));
			
			if(!radioButtonShift.Checked && !radioButtonCtrl.Checked){
				two = 0;
				return;
			}
			if((radioButtonShift.Checked || radioButtonCtrl.Checked) && two < 2)
				two += 1;
			
			int iStart,
				iEnd;
			if(radioButtonShift.Checked && two == 2)
			{
				iStart = ChangedNumber(historyList, 2);
				iEnd = ChangedNumber(historyList, 1);
				if(iStart < 0 || iEnd < 0)
					return;
				
				for(int i = (iStart < iEnd ? iStart : iEnd); i <= (iEnd > iStart ? iEnd:iStart); i++)
			 	{
					listBox1.SelectedIndex = i;
					historyList.Add(ListToArray(listBox1.SelectedIndices));
				}
				two = 0;
			}
			else
			{
				if(radioButtonCtrl.Checked && two == 2)
				{
					iStart = ChangedNumber(historyList, 2);
					iEnd = ChangedNumber(historyList, 1);
					if(iStart < 0 || iEnd < 0)
					return;
				
//					Text = "";
//					Text = iStart.ToString() + "   " + iEnd.ToString();
//					two = 0;
//					return;
					
					for(int i = (iStart < iEnd ? iStart : iEnd); i <= (iEnd > iStart ? iEnd:iStart); i++)
				 	{
						listBox1.SetSelected(i, false);
						historyList.Add(ListToArray(listBox1.SelectedIndices));
					}
					two = 0;
				}
				
			}
		}
		
		int ChangedNumber(List<int[]> history, int step)
		{
			int buf = -1;
			if(step == 1)
			{
				foreach(int i in history[history.Count-1].Length > history[history.Count-2].Length ? history[history.Count-1] : history[history.Count-2])
				{
					bool flagUnipue = true;
					foreach(int j in history[history.Count-1].Length < history[history.Count-2].Length ? history[history.Count-1] : history[history.Count-2])
					{
						if(i == j){
							flagUnipue = false;
							break;
						}
					}
					if(flagUnipue == true)
						return i;
				}
			}
			else
			{
				if(step == 2)
				{
//					if(historyList.Count < 3){
//						return historyList[historyList.Count-2][0];
//					}
					foreach(int i in history[history.Count-2].Length > history[history.Count-3].Length ? history[history.Count-2] : history[history.Count-3])
					{
						bool flagUnipue = true;
						foreach(int j in history[history.Count-2].Length < history[history.Count-3].Length ? history[history.Count-2] : history[history.Count-3])
						{
							if(i == j){
								flagUnipue = false;
								break;
							}
						}
						if(flagUnipue == true){
							return i;
						}
					}
				}
			}
			return buf;
		}
		
		void RadioButtonCtrlCheckedChanged(object sender, EventArgs e)
		{
			
		}
		void RadioButtonShiftCheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		int two = 0;
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
	}
}
