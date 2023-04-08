using System;

namespace Problem2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           // დაწერეთ პროგრამა რომელიც შეადარებს ორ მასივს და იტყვის არის თუ არა ეს ორი მასივი ტოლი.
           // Ორი მასივი ტოლია თუ მასში ყველა ელემენტის რაოდენობა ერთმანეთს უდის.  
           
           int x;
           Console.Write("array1 length: ");
           int.TryParse(Console.ReadLine(), out x);
           int[] array1 = new int[x];
           Console.WriteLine("array1 elements: ");
           for (int i = 0; i < array1.Length; ++i)
           {
               int.TryParse(Console.ReadLine(), out array1[i]);
           }
            
           int y;
           Console.Write("array2 length: ");
           int.TryParse(Console.ReadLine(), out y);
           int[] array2 = new int[y];
           Console.WriteLine("array2 elements: ");
           for (int i = 0; i < array2.Length; ++i)
           {
               int.TryParse(Console.ReadLine(), out array2[i]);
           }

           bool equal = true;

           if (array1.Length != array2.Length)
           {
               equal = false;
           }
           else
           {
               for (int i = 0; i < array1.Length; ++i)
               {
                   if (array1[i] != array2[i])
                   {
                       equal = false;
                       break;
                   }
               }
           }

           Console.WriteLine("Equal? " + equal);
        }
    }
}