using System;
using System.Collections.Generic;

namespace Problem4
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            // დაწერეთ პროგრამა რომელიც მასივში იპოვნის ყველაზე ხშირად
            // გამეორებული ელემენტის რაოდენობას და დაბეჭდავს ამ ელემენტს.    
            
            int n;
            Console.Write("array length: ");
            int.TryParse(Console.ReadLine(), out n);
            int[] array = new int[n];
            Console.WriteLine("array elements: ");
            for (int i = 0; i < array.Length; ++i)
            {
                int.TryParse(Console.ReadLine(), out array[i]);
            }
            
            Dictionary<int, int> counts = new Dictionary<int, int>();
            int mostFrequentElement = array[0];
            int mostFrequentElementCount = 1;

            for (int i = 0; i < array.Length; ++i)
            {
                if (!counts.ContainsKey(array[i]))
                {
                    counts.Add(array[i],1);
                }
                else
                {
                    counts[array[i]]++;
                }

                if (counts[array[i]] > mostFrequentElementCount)
                {
                    mostFrequentElementCount = counts[array[i]];
                    mostFrequentElement = array[i];
                }
            }

            Console.WriteLine("Most frequent element:" + mostFrequentElement);
            Console.WriteLine("Most frequent element count:" + mostFrequentElementCount);
        }
    }
}