using System;

namespace EPAMTasks
{
    class Task1
    {
        public static void Start()
        {
            int[] array = ConsoleHelper.EnterIntArrayFromConsole("Enter disordered array of integers separated by white spaces");
            Sort(array);
            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(" ",array));
            ConsoleHelper.RequestPressingEnterToFinishTask();
        }

        static void Sort(int[] array)
        {
            //Array.Sort(array);
            if (array == null)
            {
                throw new ArgumentNullException("Cannot perform sorting: array is null");
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
