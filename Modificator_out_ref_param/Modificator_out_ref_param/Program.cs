using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Методымодификаторыпараметров_out_ref_para
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 6, b = 7;
            Console.WriteLine("before function ___a is: {0} b is: {1}", a, b);
            Console.WriteLine(Add(out a, out b));
            Console.WriteLine("After function ___a is: {0} b is: {1}", a,b);




            Console.ReadKey();
        }

        static public int Add (out int a, out int b)
        {
            
            a = 4;
            b = 3;
            return a + b;
            
       
        }

        static public void rep(ref int a, ref int b)
        {
            int f = a;
            a = b;
            b = f;
        }

        static public void par(params int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            { Console.WriteLine("{0} meber: {1}", i +1, mas[i]); }
        
        }

        static public void neobImen(int a = 0, int b = 0, int c = 0)
        { Console.WriteLine("Number one is: {0}", a);
          Console.WriteLine("Number two is: {0}", b);
          Console.WriteLine("Number three is: {0}", c); 

        }

       

    }

}
