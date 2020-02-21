using System;
using System.Collections.Generic;

namespace EPAMTasks
{
    class Task5
    {
        static Dictionary<char, char> bracketChars;

        static Task5()
        {
            bracketChars = new Dictionary<char, char>() { { '[', ']' }, { '(', ')' }, { '{', '}' } };
        }
        
        public static void Start()
        {
            Console.WriteLine("Enter a string with a sequence of brackets (round brackets (), curly brackets {}, square brackets []) " +
                "and the program will check whether the sequence is correct");
            string bracketString = Console.ReadLine();
            char[] chars = bracketString.ToCharArray();
            bool bracketSequenceIsCorrect = true;
            int i = 0;
            Stack<char> stack = new Stack<char>();
            while (bracketSequenceIsCorrect && i < chars.Length)
            {
                char currentChar = chars[i]; 
                if (bracketChars.ContainsValue(currentChar))
                {
                    if (!(stack.Count > 0 && bracketChars[stack.Pop()] == currentChar))
                    {
                        bracketSequenceIsCorrect = false;
                    }
                }
                if (bracketChars.ContainsKey(currentChar))
                {
                    stack.Push(currentChar);
                }
                i++;
            }
            if (stack.Count > 0)
            {
                bracketSequenceIsCorrect = false;
            }
            string answer = bracketSequenceIsCorrect ? "Bracket sequence is correct" : "Bracket sequence is incorrect";
            Console.WriteLine(answer);
            ConsoleHelper.RequestPressingEnterToFinishTask();
        }
    }
}
