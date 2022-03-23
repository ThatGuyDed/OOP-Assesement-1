using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public static List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            //6. Number of letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for(int i = 0; i<6; i++)
            {
                values.Add(0);
            }

            for(int i = 0; i<input.Length; i++)
            {
                if (characterChecker.IsSpace(input[i]))
                {
                    // Happy We don't like space noises
                }
                else if (characterChecker.IsSentenceEnder(input[i]))
                {
                    try
                    {
                        if (characterChecker.IsSpace(input[i + 1]))
                        {
                            values[0]++;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        values[0]++;
                    }
                }
                else if (characterChecker.IsVowel(input[i]))
                {
                    values[1]++;
                }
                else if (characterChecker.IsConsonant(input[i]))
                {
                    values[2]++;
                }
                if (Char.IsUpper(input[i]))
                {
                    values[3]++;
                    values[5]++;
                }
                else if (Char.IsLower(input[i]))
                {
                    values[4]++;
                    values[5]++;
                }
                
            }

            return values;
        }
    }
}
