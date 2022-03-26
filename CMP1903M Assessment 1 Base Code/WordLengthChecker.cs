using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class WordLengthChecker
    {
        public static async void checkWords(string text)
        {
            string[] words = text.Split(' ');
            string toCheck = "";
            List<string> longWords = new List<string>();
            foreach(string word in words)
            {
                toCheck = String.Concat(word.Where(char.IsLetter));
                if(toCheck.Length > 6)
                {
                    longWords.Add(toCheck);
                }
            }
            await File.WriteAllLinesAsync("LongWords.txt", longWords);
        }
    }
}
