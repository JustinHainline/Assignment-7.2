using Microsoft.VisualBasic;

namespace Assignment_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("Enter the values: ");

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            ShellSort(array, n);
            Console.WriteLine("Sorted array:");
             
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
        }

        static void ShellSort(int[] array, int size)
        {
            for (int gap = size / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < size; i++)
                {
                    int temp = array[i];
                    int j = i;

                    while (j >= gap && array[j - gap] > temp)
                    {
                        array[j] = array[j - gap];
                        j -= gap;
                    }
                    array[j] = temp;
                }
            }
        }
    }
}
