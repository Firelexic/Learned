using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Dictionary
{
    public class StartUp
    {
        private static Dictionary<string, int> CountWord(string text)
        {
            {
                Dictionary<string, int> frequencies;
                frequencies = new Dictionary<string, int>();
                string[] words = Regex.Split(text, @"\W+");
                foreach (string word in words)
                {
                    if (frequencies.ContainsKey(word))
                    {
                        frequencies[word]++;
                    }
                    else
                    {
                        frequencies[word] = 1;
                    }
                }
                return frequencies;
            }

        }


        public static void Main()
        {
            string text = @"Do you like green eggs and ham?
                          I do not like them,Sam-I-am.
                          I do not like green eggs and ham.";

            Dictionary<string, int> frequencies = CountWord(text);
            foreach (KeyValuePair<string, int> entry in frequencies)
            {
                string word = entry.Key;
                int frequency = entry.Value;
                Console.WriteLine("{0} : {1}", word, frequency);
            }
        }

        
    }
}
