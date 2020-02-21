using System;
using System.Collections.Generic;
using System.Text;

namespace EPAMTasks
{
    class Task3
    {
        public static void Start()
        {
            string[] array = ConsoleHelper.EnterStringArrayFromConsole("Enter string");
            Dictionary<string,int> wordCount = new Dictionary<string,int>();
            Dictionary<string, string> wordsUsed = new Dictionary<string, string>();
            foreach (string word in array)
            {
                string wordWithoutPunctuation = word;
                char[] charArray = word.ToCharArray();
                foreach (char character in charArray)
                {
                    if (char.IsPunctuation(character))
                    {
                        int index = wordWithoutPunctuation.IndexOf(character);
                        if (index > 0)
                        {
                            wordWithoutPunctuation = wordWithoutPunctuation.Remove(index, 1);
                        }
                    }
                }
                string lowercaseWord = wordWithoutPunctuation.ToLower();
                if (wordCount.ContainsKey(lowercaseWord))
                {
                    wordCount[lowercaseWord] = wordCount[lowercaseWord] + 1;
                }
                else
                {
                    wordCount.Add(lowercaseWord, 1);
                    wordsUsed.Add(lowercaseWord, wordWithoutPunctuation);
                }
            }
            StringBuilder sb = new StringBuilder();
            foreach (var key in wordCount.Keys)
            {
                if (wordCount[key] == 1)
                {
                    sb.Append(wordsUsed[key]);
                    sb.Append(" ");
                }
            }
            Console.WriteLine("Words that were used only once: ");
            Console.WriteLine(sb.ToString());
            ConsoleHelper.RequestPressingEnterToFinishTask();
        }
    }
}
