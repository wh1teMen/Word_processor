using AutocompleteMenuNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Services.Description;
using Word.Base;

namespace Word.Filters
{
    internal class Filter
    {
        public Filter() { }       
        //Возвращает List слов из базы данных  отсортированы по алфавиту и по количеству вхождений от большего к меньшему
        public List<string> ReadWordsFromBase(List<string> enteredWords_List)
        {
            List<Word> result = new List<Word>();
            var resultTmp = enteredWords_List.GroupBy(x => x).Select(x => new { word = x.Key, count = x.Count() }).OrderBy(x => x.word);
            resultTmp = resultTmp.OrderByDescending(x => x.count);
            foreach (var item in resultTmp)
            {
                result.Add(new Word { _Word = item.word, _Count = item.count });
            }
            return ToListWord(result);
        }        
        //Конвертирует List<Word> to List<string>
        private List<string> ToListWord(List<Word>wordList)
        {
           var list = wordList.Select(x => x._Word).ToList();
           return list;
        }
        //Возвращает отфильтрованный список слов, длина которых больше 2х и количесвто вхождений больше 2х
        public List<string> InsertWordsToBase(List<string> list)
        {
            var result = list.Where(word => word.Length > 2 && list.Count(w => w == word) > 2).ToList();
            return result;
        }    
    }
}
