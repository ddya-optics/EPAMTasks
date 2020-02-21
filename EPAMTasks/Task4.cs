using System;

namespace EPAMTasks
{
    class Task4
    {
        public static void Start()
        {
            Console.WriteLine("Enter non-negative integer number");
            int number = 0;
            bool integerIsValid = false;
            while (!integerIsValid)
            {
                string valueEntered = Console.ReadLine();
                if (int.TryParse(valueEntered, out number))
                {
                    if (number < 0)
                    {
                        Console.WriteLine("Number is negative");
                    }
                    else
                    {
                        try
                        {
                            Console.WriteLine("Factorial of the number is " + Factorial(number));
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Overflow");
                        }
                        integerIsValid = true;
                    }
                }
                else
                {
                    ConsoleHelper.ReportInvalidIntegerString(valueEntered);
                }
            }
            ConsoleHelper.RequestPressingEnterToFinishTask();
        }

        public static long Factorial(long number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            return checked(number * Factorial(number - 1));
        }
    }
}
