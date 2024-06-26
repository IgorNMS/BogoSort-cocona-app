﻿namespace BogoSort.Services
{
    public interface ISortService
    {
        public void BogoSort(int dalay, string announce, List<int> numbers);
    }
    public class BogoService : ISortService
    {
        public void BogoSort(int dalay, string announce, List<int> numbers)
        {
            Console.WriteLine("Sorting...");
            Bogo_sort(numbers, announce, dalay);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static void Bogo_sort(List<int> list, string announce, int delay)
        {
            int iteration = 0;
            while (!IsSorted(list))
            {
                if (announce == "Y" || announce == "y")
                {
                    Print_Iteration(list, iteration);
                }
                if (delay != 0)
                {
                    Thread.Sleep(Math.Abs(delay));
                }
                list = Remap(list);
                iteration++;
            }

            Print_Iteration(list, iteration);
            Console.WriteLine();
            Console.WriteLine("Bogo_sort completed after {0} iterations.", iteration);
        }

        private static void Print_Iteration(List<int> list, int iteration)
        {
            Console.Write("Bogo_sort iteration {0}: ", iteration);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
                if (i < list.Count)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        private static bool IsSorted(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        private static List<int> Remap(List<int> list)
        {
            int temp;
            List<int> newList = new List<int>();
            Random r = new Random();

            while (list.Count > 0)
            {
                temp = (int)r.Next(list.Count);
                newList.Add(list[temp]);
                list.RemoveAt(temp);
            }
            return newList;
        }
    }
}
