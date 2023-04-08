using System;

namespace Problem3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // დაწერეთ პროგრამა რომელიც მასივში დაბეჭდავს ერთმანეთის მეზობლად მდგარი ტოლი ელემენტების მაქსიმალურ რაოდენობას და ამ ელემენტს.
            // Მაგ 1 1 2 2 2 3 4 2 2  - უნდა დაბეჭდოს 3  და 2. 
            
            int[] array = { 1, 1, 2, 2, 2, 3, 4, 2, 2 };
            int maximalSequenceStart = 0;
            int maximalSequenceEnd = 0;
            
            int currentSequenceStart = 0;
            int currentSequenceEnd = 0;
            
            for (int i = 0; i < array.Length; ++i)
            {
                if (i < array.Length - 1 && array[i] == array[i + 1])
                {
                    currentSequenceEnd = i + 1;
                }
                else
                {
                    if ((maximalSequenceEnd - maximalSequenceStart + 1) < (currentSequenceEnd - currentSequenceStart + 1))
                    {
                        maximalSequenceStart = currentSequenceStart;
                        maximalSequenceEnd = currentSequenceEnd;
                    }
                    currentSequenceStart = i + 1;
                    currentSequenceEnd = i + 1;
                }
            }

            int maximalSequenceLength = maximalSequenceEnd - maximalSequenceStart + 1;
            Console.Write($"{maximalSequenceLength} {array[maximalSequenceEnd]}");
        }
    }
}