using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Array;

namespace System.Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] masiv = { 1, 2, 3, 4, 5, 6, 7 };

            PrintArray(masiv);
            int [] masiv1 = new int [7] ;
            PrintArray(masiv1);

            masiv.CopyTo(masiv1, 0);
            PrintArray(masiv1);

            Console.WriteLine(masiv.Length);


            Console.ReadKey();
        }

        private static void PrintArray(int[] masiv)
        {
            foreach (int i in masiv)
                Console.WriteLine(i);
        }
    }
}
