using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            String myString;
            myString = "Lets Play Pig Latin! ";


            Console.WriteLine(myString);

            string myWord = Console.ReadLine();

            char firstLetter = myWord[0];
            char secondLetter = myWord[1];

            // If a word starts with a vowel add the word "way" at the end of the word.
            // Example: Awesome = Awesome + way = Awesomeway 
            if (firstLetter == 'A' || firstLetter == 'E' || firstLetter == 'I' || firstLetter == 'O' || firstLetter == 'U')
            {
                Console.WriteLine($"Pig Latin {myWord} is {myWord + "way"} ");
            }
            // Most words in Pig Latin end in "ay." Use the rules below to translate normal English into Pig Latin.
            // Example: Happy = appyh + ay = appyhay
            else if (firstLetter == 'B' || firstLetter == 'C' || firstLetter == 'D' || firstLetter == 'F' || firstLetter == 'G' ||
                    firstLetter == 'H' || firstLetter == 'J' || firstLetter == 'K' || firstLetter == 'L' || firstLetter == 'M' ||
                    firstLetter == 'N' || firstLetter == 'P' || firstLetter == 'Q' || firstLetter == 'R' || firstLetter == 'S' ||
                    firstLetter == 'T' || firstLetter == 'V' || firstLetter == 'W' || firstLetter == 'X' || firstLetter == 'Y' ||
                    firstLetter == 'Z')
            {
                Console.WriteLine($"Pig Latin {myWord} is {myWord.Remove(0, 1) + firstLetter + "ay"}");
            }
            // If a word starts with two consonants move the two consonants to the end of the word and add "ay."
            // Example: Child = Ildch + ay = Ildchay
            else if ((firstLetter == 'B' || firstLetter == 'C' || firstLetter == 'D' || firstLetter == 'F' || firstLetter == 'G' ||
                    firstLetter == 'H' || firstLetter == 'J' || firstLetter == 'K' || firstLetter == 'L' || firstLetter == 'M' ||
                    firstLetter == 'N' || firstLetter == 'P' || firstLetter == 'Q' || firstLetter == 'R' || firstLetter == 'S' ||
                    firstLetter == 'T' || firstLetter == 'V' || firstLetter == 'W' || firstLetter == 'X' || firstLetter == 'Y' ||
                    firstLetter == 'Z') && (secondLetter == 'B' || secondLetter == 'C' || secondLetter == 'D' || secondLetter == 'F' || secondLetter == 'G' ||
                    secondLetter == 'H' || secondLetter == 'J' || secondLetter == 'K' || secondLetter == 'L' || secondLetter == 'M' ||
                    secondLetter == 'N' || secondLetter == 'P' || secondLetter == 'Q' || secondLetter == 'R' || secondLetter == 'S' ||
                    secondLetter == 'T' || secondLetter == 'V' || secondLetter == 'W' || secondLetter == 'X' || secondLetter == 'Y' ||
                    secondLetter == 'Z'))
            {
                Console.WriteLine($"Pig Latin {myWord} is {myWord.Remove(0, 2) + firstLetter + secondLetter + "ay"}");
            }

            // I need to look for two consonants, remove them from front, add them to back.
            //
        }
    }
}
