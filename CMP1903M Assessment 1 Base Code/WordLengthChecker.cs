using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class WordLengthChecker
    {
        // Takes a string and then finds all words of length 7 or higher
        // Input: String input of sentences
        // Output: Text file containing long words
        public static async void checkWords(string text)
        {
            // First we split the sentence up by spaces and initialise some private vars
            string[] words = text.Split(' ');
            string toCheck = "";
            List<string> longWords = new List<string>();
            // Loop through word list and if longer than 7 letters add to list of strings
            foreach(string word in words)
            {
                toCheck = String.Concat(word.Where(char.IsLetter));
                if(toCheck.Length > 6)
                {
                    longWords.Add(toCheck);
                }
            }
            // Write strings to file
            await File.WriteAllLinesAsync("LongWords.txt", longWords);
        }
    }
}
