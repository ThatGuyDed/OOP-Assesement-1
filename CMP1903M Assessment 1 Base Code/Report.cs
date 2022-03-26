using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        public static void reportValues(List<int> values, List<int> letters)
        {
            char letter = 'a';
            Console.WriteLine("\n\nStats about text inputted:");
            Console.WriteLine($"- There were {values[0]} sentences");
            Console.WriteLine($"- Containing {values[5]} total letters");
            Console.WriteLine($"    - Of which {values[3]} were upper case letters");
            Console.WriteLine($"    - and {values[4]} were lower case letters");
            Console.WriteLine($"    - With {values[1]} vowels");
            Console.WriteLine($"    - and {values[2]} consonants");
            Console.WriteLine("\n\n Letter frequencies: ");
            for (int i = 0; i < letters.Count; i++)
            {
                letter = (char)(i+97);
                Console.WriteLine($"-{letter} had frequency: {letters[i]}");
            }
        }
    }
}
