using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Ex3REDO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables used 
            string word;           
            int vowel = 0;

            //asking user to input string of text
            Console.WriteLine("Enter a word to count its vowels");
            word = Console.ReadLine();

            //processing and counting the amount of vowels
            foreach (char c in word)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowel++;
                } else if (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    vowel++;
                }
            }
            //prints out final count of vowels
            Console.WriteLine("The number of vowels in the string is: " + vowel);
        }
    }
}
