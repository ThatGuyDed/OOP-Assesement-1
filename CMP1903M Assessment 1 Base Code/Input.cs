using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public static string manualTextInput()
        {
            string text = "";
            string input = " ";
            while (input[input.Length - 1] != '*'){
                input = Console.ReadLine();
                if (input.Length == 0)
                {
                    input = ".";
                    text += input;
                }
                else
                {
                    text += " " + input;
                }
                
            }
            return text.Replace("\n"," ").Replace("*","");
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public static string fileTextInput(string fileName)
        {
            string text = "";
            fileName = fileName.Trim('"');
            try
            {
                text = System.IO.File.ReadAllText(fileName);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("That File cannot be found, make sure that is the correct file name.");
                text = "";
            }
            catch (IOException)
            {
                Console.WriteLine("There was something wrong with the path supplied, make sure the path was correct and try again.");
                text = "";
            }
            catch
            {
                Console.WriteLine("Unexepected error has occurred, make sure the input value was correct and try again.");
                text = "";
            }
            return text.Replace("\n", " ");
        }

    }
}
