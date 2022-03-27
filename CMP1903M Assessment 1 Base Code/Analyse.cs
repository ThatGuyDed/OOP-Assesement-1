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
        public static List<int> analyseText(string input,ref List<int> letters)
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
            // Initialise list of letters for letter freq.
            for(int i = 0; i<26; i++)
            {
                letters.Add(0);
            }

            //loop through every character in the string supplied
            for(int i = 0; i<input.Length; i++)
            {
                // Is it a space?
                if (characterChecker.IsSpace(input[i]))
                {
                    // Happy We don't like space noises
                }
                // Is it a full stop, exclamation mark or question mark?
                else if (characterChecker.IsSentenceEnder(input[i]))
                {
                    try
                    {
                        // Is it followed by a space (Generally end of sentence followed by space) prevents "Help!!!" being classed as 3 sentences
                        if (characterChecker.IsSpace(input[i + 1]))
                        {
                            values[0]++;
                        }
                    }
                    // if we get an index out of range exception it is end of file.
                    catch (IndexOutOfRangeException)
                    {
                        values[0]++;
                    }
                }
                // Is it a vowel?
                else if (characterChecker.IsVowel(input[i]))
                {
                    values[1]++;
                    // Since Letter list is 26 elements long we can convert char to lowercase and subtract 97 from their ascii value to get a value from 0-25
                    letters[Char.ToLower(input[i]) - 97]++;
                }
                // Is it a consonant?
                else if (characterChecker.IsConsonant(input[i]))
                {
                    values[2]++;
                    letters[Char.ToLower(input[i]) - 97]++;
                }
                // Is it uppercase?
                if (Char.IsUpper(input[i]))
                {
                    values[3]++;
                    values[5]++;
                }
                // Is it lowercase?
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
