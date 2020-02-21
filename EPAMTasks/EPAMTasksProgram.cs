using System;

namespace EPAMTasks
{
    class EPAMTasksProgram
    {
        static void Main(string[] args) {

            string selectionString = null;
            while (selectionString != "Q")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter task number (1-5) to choose task or enter Q to quit");
                selectionString = Console.ReadLine();
                switch (selectionString)
                {
                    case "1":
                        Task1.Start();
                        break;
                    case "2":
                        Task2.Start();
                        break;
                    case "3":
                        Task3.Start();
                        break;
                    case "4":
                        Task4.Start();
                        break;
                    case "5":
                        Task5.Start();
                        break;
                    case "Q":
                        Console.WriteLine("Quitting the program");
                        break;
                    default:
                        Console.WriteLine("Wrong command");
                        break;
                }
            }
        }
    }
}
