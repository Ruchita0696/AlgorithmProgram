using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class Anagram
    {
        public void CheckAnagram(string str1, string str2)
        {
            char[] ch1, ch2;
            string val1, val2;
            ch1 = str1.ToLower().ToCharArray();
            ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            val1 = new string(ch1);
            val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("Both the words are Anagrams");

            }
            else
            {
                Console.WriteLine("Both the Words are not Anagrams");
            }
        }
    }
}
