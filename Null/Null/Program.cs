using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null. Nullable

{
    class Program
    {
        static void Main(string[] args)
        {

            string a = "Tigran Shakhbekyan";
            Console.WriteLine(a.ToString());
            
            string b = null;
            Console.WriteLine(b);


            int c = 5;
            Console.WriteLine(c);

            int d = 0;
            Console.WriteLine(d);

            int? e = null;
            Console.WriteLine(e);

            double? f;
            f = 20;
            Console.WriteLine(f.GetType().Name);

            Console.WriteLine(f.HasValue);
            Console.WriteLine(f.Value);
            Console.WriteLine(f);

            f = null;
            Console.WriteLine(f.HasValue);
            if (f.HasValue != true)
                Console.WriteLine("asdasdas");


            Nullable<int> aa = 5;
            Console.WriteLine(aa);
            aa = 0;
            Console.WriteLine(aa);
           


            

            
            Console.Read();
        }
    }
}
