using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word.Base
{
    internal class DataWord
    {
        public DataWord() { }          
        private void Command(string pattern)
        {
            using (SQLiteConnection connect = new SQLiteConnection($"Data Source=MyDictionaty.db;"))
            {
                connect.Open();               
                SQLiteCommand command_create = new SQLiteCommand(pattern, connect);
                command_create.ExecuteNonQuery();
            };
        }     
        public void CreateTable()
        {
            try
            {                
                string SQL_command_create = $"CREATE TABLE  IF NOT EXISTS Dictionary" +
                  $" (id INTEGER PRIMARY KEY   UNIQUE," +
                  $" Word VARCHAR(1,200));";
                Command(SQL_command_create);
                MessageBox.Show("Словарь создан");

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        public void DeleteBD()
        {
            try
            {
                string SQL_command_delete = $"DELETE FROM Dictionary";
                Command(SQL_command_delete);
               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }        
        public void InsertBD(List<string> other)
        {
            try
            {              
               
                foreach (var item in other)
                {
                    var SQL_command_insert = $"insert into Dictionary(Word)values(\"{item}\");";
                    Command(SQL_command_insert);                
                   
                }            
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }
        public List<string> GetWords()
        {
            List<string> result = new List<string>();
            using (SQLiteConnection connect = new SQLiteConnection($"Data Source=MyDictionaty.db;"))
            {
                try
                {
                    var SQL_command_read = $"select Word from Dictionary";
                    connect.Open();
                    SQLiteCommand command_read = new SQLiteCommand(SQL_command_read, connect);
                    var rider = command_read.ExecuteReader();
                    if (rider.HasRows)
                    {
                        while (rider.Read())
                        {
                            result.Add(rider.GetString(0));
                        }
                    }

                }
            catch(Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                
            };          
            return result;
        }

    }
}
