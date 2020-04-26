using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Filling(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(10, 99);
                Console.WriteLine(arr[i]);
            }
        }

        static void Sort(int [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool isSorted = true;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        isSorted = false;
                    }
                }
                if (isSorted) break;
            }
        }

        static void Prnt(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static void Swap (ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
            


        static void Main(string[] args)
        {
            int [] arr = new int[17];
            Filling(arr);
            Sort(arr);
            Console.WriteLine("********RESULT********");
            Prnt(arr);
            
        }
    }
}
