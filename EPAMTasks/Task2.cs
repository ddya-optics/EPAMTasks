using System;

namespace EPAMTasks
{
    class Task2
    {
        public static void Start()
        {
            int[] array = ConsoleHelper.EnterIntArrayFromConsole("Enter ordered array of integers separated by white spaces");
            bool quitTaskRequested = false;
            while (!quitTaskRequested)
            {
                Console.WriteLine("Enter number to find in array or q to quit task");
                int number;
                string numberString = Console.ReadLine();
                if (numberString != "q")
                {
                    if (int.TryParse(numberString, out number))
                    {
                        string answer = Contains(array, number) ? "Array contains this value" : "Array doesn't contain this value";
                        Console.WriteLine(answer);
                    }
                    else
                    {
                        ConsoleHelper.ReportInvalidIntegerString(numberString);
                    }
                }
                else
                {
                    quitTaskRequested = true;
                }
            }
            ConsoleHelper.RequestPressingEnterToFinishTask();
        }

        public static bool Contains(int[] values, int value)
        {
            // return Array.BinarySearch(values, value)) >=0
            int p = 0;
            int q = values.Length - 1;
            while (p <= q)
            {
                int s = (p + q) / 2;
                int probableIndex = s;
                double probableValue = values[s];
                if (value == probableValue)
                {
                    return true;
                }
                else if (value < probableValue)
                {
                    q = s - 1;
                }
                else
                {
                    p = s + 1;
                }
            }
            return false;
        }
    }
}
