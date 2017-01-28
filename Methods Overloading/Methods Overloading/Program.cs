using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перегрузка_функций
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(add(25, 55));
            Console.WriteLine(add (20.5, 45.2));
            Console.WriteLine(add (2344444444444444, 4333333333333));


            

            Console.ReadKey();
        }

        static public int add(int a, int b)
        { return a + b; }

        static public double add(double a, double b)
        { return a + b; }

        static public long add(long a, long b)
        { return a + b; }



    }
}
