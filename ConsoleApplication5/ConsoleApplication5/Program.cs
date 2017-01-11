using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 100;
            byte b = 12;

            Console.WriteLine(a);
            Console.WriteLine(b);

            b = (byte)a;
            Console.WriteLine(b);

            try
            {
                checked
                {
                    b = (byte)(a * a);
                    Console.WriteLine(b);

                }
            }


            catch (OverflowException ex)
            { Console.WriteLine(ex.Message); }



              Console.ReadKey();
          }

      
        }
    }

