using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Print_Frist_Letter_Of_Each_Word
{
    internal class Program
    {
        // Prompts the user for input and returns the entered string
        public string ReadString()
        {
            
            Console.WriteLine("Please Enter Your String ? ");
            return Console.ReadLine() ?? "";
        }

        // Iterates through the string to identify and print the first letter of each word
        public void PrintFirstLetterOfEachWord(string TextS1)
        {
            // Boolean flag to track the start of a new word
            bool IsFirstLetter = true;

            Console.WriteLine("First Letters Of This String ");

            for (int i = 0; i < TextS1.Length; i++)
            {
                // Check if the current character is not a space and marks the beginning of a word
                if (TextS1[i] != ' ' && IsFirstLetter)
                {
                    Console.WriteLine(char.ToUpper(TextS1[i]));
                }

                // Update the flag: set to true if current character is a space, otherwise set to false
                IsFirstLetter = (TextS1[i] == ' ' ? true : false);
            }
        }

        static void Main(string[] args)
        {
            // Initialize the class and execute the methods
            Program e = new Program();
            string ReadString = e.ReadString();
            e.PrintFirstLetterOfEachWord(ReadString);
            Console.ReadKey();
        }
    }
}
