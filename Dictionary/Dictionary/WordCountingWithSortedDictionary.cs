using System;
using System.Collections.Generic;

namespace Dictionary
{
    class WordCountingWithSortedDictionary
    {
        private static readonly string Text =
        "Mary had a little lamb " +
        "little Lamb, little Lamb, " +
        "Mary had a Little lamb, " +
        "whose fleece were white as snow.";


        static void Main(string[] args)
        {
            IDictionary<string, int> wordOccurenceMap = GetWordOccurenceMap(Text);
            PrintWordOccurenceCount(wordOccurenceMap);
            //IDictionary<string, int> words =
            //    new SortedDictionary<string, int>(
            //        new CaseInsensitiveComparer());
            //words = GetWordOccurenceMap(Text);
            //PrintWordOccurenceCount(wordOccurenceMap);

            Console.ReadLine();
        }

        private static IDictionary<string, int> GetWordOccurenceMap(string text)
        {
            string[] tokens =
                Text.Split(' ', '.', ',', '-', '?', '!');
            IDictionary<string, int> words = new SortedDictionary<string, int>();
            foreach ( string word in tokens)
            {
                if (!string.IsNullOrEmpty(word.Trim()))
                {
                    int count;
                    if(!words.TryGetValue(word, out count))//gets the value of the associated key
                    {
                        count = 0;
                    }
                    words[word] = ++count;
                }
            }
            return words;
        }

        private static void PrintWordOccurenceCount(
            IDictionary<string, int> wordOccurenceMap)
        {
            foreach (var wordEntry in wordOccurenceMap)
            {
                Console.WriteLine(
                    "Word '{0}' occurs {1} time(s) in the text",
                    wordEntry.Key, wordEntry.Value);
            }
        }

        //public int Compare(string s1, string s2)
        //{
        //    return string.Compare(s1, s2, true);
        //}
    }

    //class CaseInsensitiveComparer : IComparer<string>
    //{
    //    public int Compare(string s1, string s2)
    //    {
    //        return string.Compare(s1, s2, true);
    //    }
    //}
}
