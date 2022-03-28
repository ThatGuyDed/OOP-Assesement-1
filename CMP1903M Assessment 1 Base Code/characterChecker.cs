using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    // Class made for methods involving checking characters
    class characterChecker
    {
        // Declare private char strings for each thing we are checking for
        static char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        static char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
        static char[] enders = { '!', '?', '.' };

        public static bool IsVowel(char a)
        {
            return vowels.Contains(Char.ToLower(a));
        }
        public static bool IsConsonant(char a)
        {
            return consonants.Contains(Char.ToLower(a));
        }

        public static bool IsSentenceEnder(char a)
        {
            return enders.Contains(a);
        }

        public static bool IsSpace(char a)
        {
            return a == ' ';
        }

        // The dog ate a bone. The cat fell off a tree? A bird flew into the window!

    }
}
