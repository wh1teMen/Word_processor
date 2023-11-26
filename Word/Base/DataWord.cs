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
       
        public void CreateTable()
        {
            try
            {
                using (SQLiteConnection connect = new SQLiteConnection($"Data Source=MyDictionaty.db;"))
                {
                    string SQL_command_create = $"CREATE TABLE  IF NOT EXISTS Dictionary" +
                  $" (id INTEGER PRIMARY KEY   UNIQUE," +
                  $" Word VARCHAR(1,200));";
                    connect.Open();
                    SQLiteCommand command_create = new SQLiteCommand(SQL_command_create, connect);
                    command_create.ExecuteNonQuery();
                };               
              

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        public void DeleteBD()
        {
            try
            {
                using (SQLiteConnection connect = new SQLiteConnection($"Data Source=MyDictionaty.db;"))
                {
                    string SQL_command_delete = $"DELETE FROM Dictionary";
                    connect.Open();
                    SQLiteCommand command = new SQLiteCommand(SQL_command_delete, connect);
                    command.ExecuteNonQuery();
                };
               
              
               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }        
        public void InsertBD(List<string> other)
        {
            try
            {
                using (SQLiteConnection connect = new SQLiteConnection($"Data Source=MyDictionaty.db;"))
                {
                    string SQL_command_delete = $"DELETE FROM Dictionary";
                    connect.Open();
                   

                    foreach (var item in other)
                    {
                        var SQL_command_insert = $"insert into Dictionary(Word)values(\"{item}\");";
                        SQLiteCommand command = new SQLiteCommand(SQL_command_insert, connect);
                        command.ExecuteNonQuery();

                    }
                };
                         
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
                            result.Add(rider[0].ToString());
                        }
                    }
                    connect.Close();
                }
            catch(Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                
            };          
            return result;
        }

    }
}
