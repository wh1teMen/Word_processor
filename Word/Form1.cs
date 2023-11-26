using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Entity;
using Microsoft.SqlServer.Server;
using Word.Base;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ScintillaNET;
using Word.Filters;

namespace Word
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();           
        }
        DataWord dataWord = new DataWord();      
        Filter filter = new Filter();
        string KeyPresValue;
        List<string> tmpListWords = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {

           
        }
        //Добавление данных в  Меню автозаполнения
        private void BuildAutoCompleateMenu()
        {          
            autocompleteMenu.Items=null;           
            var readWords_List = ((filter.ReadWordsFromBase(dataWord.GetWords()))).ToList();            
            readWords_List.ForEach(x => autocompleteMenu.AddItem(x + " "));           
        }
        //Поиск в автозаполнении совпадения начинающиеся с pattern
        private void search(string pattern)
        {
            autocompleteMenu.Items = null;           
            var readWords_List = ((filter.ReadWordsFromBase(dataWord.GetWords()))).ToList();
                    
            Regex regex = new Regex($@"^[{pattern}].*");
            var result = readWords_List.Where(el => regex.IsMatch(el));          
            foreach (string word in result)
            {
                tmpListWords.Add(word);
            }
            var sortlist = tmpListWords.Take(5).ToList();
            sortlist.ForEach(x => autocompleteMenu.AddItem(x + " "));           
            tmpListWords.Clear();
        }
        private bool flagCreate = false;
        private void созданиеСловаряToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Для создания словаря\nвведите текст","Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            if (textBox1.Text != "")
            {
                dataWord.CreateTable();
                var enteredWords_List = textBox1.Text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToList();               
                MessageBox.Show("Словарь создан");
                dataWord.InsertBD(filter.InsertWordsToBase(enteredWords_List));
                flagCreate = true;
            }

        }
        private void очиститьСловарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataWord.DeleteBD();
            MessageBox.Show("Словарь  отчищен","Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void обновлениеСловаряToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Для обновления словаря\nвведите текст"); return;
            }
            if (textBox1.Text != "")
            {
                var enteredWords_List = textBox1.Text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',','\n','\r' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                dataWord.InsertBD(filter.InsertWordsToBase(enteredWords_List));              
                BuildAutoCompleateMenu();
                MessageBox.Show("Словарь обновлен","Сообщение",MessageBoxButtons.OK,MessageBoxIcon.Information);
               
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                KeyPresValue += e.KeyChar.ToString();
                if (flagCreate == true) { search(KeyPresValue); }                             
                if (textBox1.TextLength != 0 && CountSpace() == 1)
                {
                    if (e.KeyChar == '.')
                    {
                        textBox1.Text = textBox1.Text.TrimEnd();
                        textBox1.Select(textBox1.TextLength, textBox1.TextLength);
                        BuildAutoCompleateMenu();
                    }
                    if (e.KeyChar == ',')
                    {
                        textBox1.Text = textBox1.Text.TrimEnd();
                        textBox1.Select(textBox1.TextLength, textBox1.TextLength);
                        BuildAutoCompleateMenu();
                    }
                }

            }
            catch (Exception) { dataWord.CreateTable();return;  }
           
        }
         private void autocompleteMenu_Selected(object sender, AutocompleteMenuNS.SelectedEventArgs e)
        {
            KeyPresValue =null;              
        }
        //количесвто пробелов в конце текста
        private int CountSpace()
        {
            int count = 0;
            string text = textBox1.Text;
            int index = text.Length;
            while (index > 0 && text[index - 1] == ' ')
            {
                count++;
                index--;
            }           
            return count;
        }        
        
    }
}
