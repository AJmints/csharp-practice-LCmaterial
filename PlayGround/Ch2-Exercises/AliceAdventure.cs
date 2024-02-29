using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.Ch2_Exercises
{
    internal class AliceAdventure
    {
        public static string GetStringCount()
        {
            string theStory = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

            Console.WriteLine(theStory);
            string search = Console.ReadLine();
            string input = search.ToLower();
            string storeLower = theStory.ToLower();

            if (storeLower.IndexOf(input, 0) != -1)
            {
                int index = storeLower.IndexOf(input, 0);
                string selectedChar = storeLower.Substring(index, 1);
                Console.WriteLine("Selected character: '" + selectedChar + "', is this many characters in: " + (index + 1) );
            } else
            {
                Console.WriteLine("Letter not present");
            }

            return "";
        }
    }
}
