//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();
            List<int> letters = new List<int>();
            string choice = "";
            string input = "";
            string output = "";
            // Check what choice user wants
            do
            {
                Console.Write("Would you like to:\n1. Manually Enter text\n2. Take text from file\n");
                choice = Console.ReadLine();
            } while (choice != "1" && choice != "2");

            // Manual Input
            if(choice == "1")
            {
                output = Input.manualTextInput();
            }

            // Text file input
            else if (choice == "2")
            {
                do
                {
                    Console.Write("Please enter the path to the text file: ");
                    input = Console.ReadLine();
                    output = Input.fileTextInput(input);

                } while (output == "");
            }
            // Analyse string
            parameters = Analyse.analyseText(output, ref letters);
            // Report results
            Report.reportValues(parameters,letters);
            // Make list of long words
            WordLengthChecker.checkWords(output);

        }
        
        
    
    }
}
