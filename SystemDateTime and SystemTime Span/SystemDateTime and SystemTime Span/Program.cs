using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SystemDateTime_and_SystemTime_Span
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime (1988,05,11);
            DateTime dt1 = dt.AddDays(10);
            Console.WriteLine(dt.ToUniversalTime());
            Console.WriteLine(dt1);


            TimeSpan sp = new TimeSpan(5, 6,4);
            Console.WriteLine(sp);

            Console.WriteLine(dt.Subtract(sp));

            BigInteger bigy = BigInteger.Parse("10888888888888888888888888888888888888888");
            Console.WriteLine(bigy);
            Console.WriteLine(bigy.IsEven);
            Console.WriteLine(BigInteger.Abs(bigy));
            BigInteger reallyBig = BigInteger.Multiply (bigy, BigInteger.Parse("8888888888888888888888888888888888888888888"));
            Console.WriteLine(reallyBig);




            Console.ReadKey();
        }
    }
}
