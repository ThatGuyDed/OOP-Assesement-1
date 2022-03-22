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
            string choice = "";
            string input = "";
            string output = "";

            //Create 'Input' object
            //Get either manually entered text, or text from a file

            do
            {
                Console.Write("Would you like to:\n1. Manually Enter text\n2. Take text from file\n");
                choice = Console.ReadLine();
            } while (choice != "1" && choice != "2");


            if(choice == "1")
            {
                output = Input.manualTextInput();
            }

            else if (choice == "2")
            {
                do
                {
                    Console.Write("Please enter the path to the text file: ");
                    input = Console.ReadLine();
                    output = Input.fileTextInput(input);

                } while (output == "");
            }


            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method


            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?


        }
        
        
    
    }
}
