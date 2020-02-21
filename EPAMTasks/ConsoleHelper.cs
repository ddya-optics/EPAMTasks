using System;

namespace EPAMTasks
{
    static class ConsoleHelper
    {

        public static string[] EnterStringArrayFromConsole(string message) 
        {
            Console.WriteLine(message);
            string arrayString = Console.ReadLine();
            return arrayString.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static int[] EnterIntArrayFromConsole(string message) 
        {
            bool arrayIsFilled = false;
            int[] values = null;
            while (!arrayIsFilled)
            {
                string[] stringValues = EnterStringArrayFromConsole(message);
                values = new int[stringValues.Length];
                arrayIsFilled = true;
                for (int i = 0; i < stringValues.Length; i++)
                {
                    string stringValue = stringValues[i];
                    int value = 0;
                    if (int.TryParse(stringValue, out value))
                    {
                        values[i] = value;
                    }
                    else
                    {
                        ReportInvalidIntegerString(stringValue);
                        arrayIsFilled = false;
                    }
                }
            }
            return values;
        }

        public static void ReportInvalidIntegerString(string integerString)
        {
            Console.WriteLine(string.Format("{0} is not an integer, please try again", integerString));
        }

        public static void RequestPressingEnterToFinishTask()
        {
            Console.WriteLine("Press enter to choose other task");
            Console.ReadLine();
        }
    }

}
