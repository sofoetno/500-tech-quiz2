using System;
using System.Collections.Generic;

namespace Problem1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოიტანს n-ს და მასივს შეავსებს n-ცალი რიცხვით. დაითვალეთ:
            // a) კენტი რიცხვების ჯამი
            // b) ლუწი რიცხვების ნამრავლი
            // c) დაითვლის მასივში თითოეული ელემენტი რამდენჯერ გვხვდება
            
            int n;
            Console.Write("array length: ");
            int.TryParse(Console.ReadLine(), out n);
            int[] array = new int[n];
            Console.WriteLine("array elements: ");
            for (int i = 0; i < array.Length; ++i)
            {
                int.TryParse(Console.ReadLine(), out array[i]);
            }

            int sum = 0;
            int product = 1;
            Dictionary<int, int> counts = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] % 2 == 0)
                {
                    product = array[i] * product;
                }
                else
                {
                    sum = array[i] + sum;
                }

                if (!counts.ContainsKey(array[i]))
                {
                    counts.Add(array[i],1);
                }
                else
                {
                    counts[array[i]]++;
                }
            }
            
            Console.WriteLine($"Product of even numbers: {product}");
            Console.WriteLine($"Sum of odd numbers: {sum}");
            Console.WriteLine("Frequency of elements: ");
            foreach (var count in counts)
            {
                Console.WriteLine($"{count.Key}: {count.Value}");
            }
        }
    }
}