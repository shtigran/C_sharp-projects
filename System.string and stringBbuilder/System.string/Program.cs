using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.@string
{
    class Program
    {
        static void Main(string[] args)
        {



            Systemstringmethods();

            SystemstringBuildermethods();


            string a = "Tigran Shakh";
            Console.WriteLine(a);
            func(a);
            Console.WriteLine(a);


            Console.ReadKey();
        }


        

         public static void func (string a)
        { a = "Tigran";
         Console.WriteLine(a); }

        private static void SystemstringBuildermethods()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("StringBuilder");
            StringBuilder st1 = new StringBuilder("Tigran Shakhbekyan");
            Console.WriteLine(st1);
            Console.WriteLine(st1.Capacity);
            st1.Replace("Shakhbekyan", "Shatyan");
            Console.WriteLine(st1);
        }

        public static void Systemstringmethods()
        {
            string str1 = new string('*', 30);
            Console.WriteLine(str1);
            string str2 = "Tigran Shakhbekyan";
            Console.WriteLine(str2);
            string str3 = "Tigran Shakhbekyan Hakob";
            Console.WriteLine(str3);
            Console.WriteLine(str1);

            Console.WriteLine("Str1 length is: {0}", str1.Length);
            Console.WriteLine("Str2 length is: {0}", str2.Length);
            Console.WriteLine("Str3 length is: {0}", str3.Length);
            Console.WriteLine(str1);

            Console.WriteLine(string.Compare(str2, str3));
            Console.WriteLine(string.Compare(str3, str3));
            Console.WriteLine(string.Compare(str1, str3));
            Console.WriteLine(str1);


            if (str2.Contains("Tigran") == true)
                Console.WriteLine("Str 2 contains \"Tigran\"");
            Console.WriteLine(str1);

            Console.WriteLine(str2.Equals("Tigran Shakhbekyan"));
            Console.WriteLine(str1);


            Console.WriteLine(str2.Insert(4, str1));
            Console.WriteLine(str1);

            Console.WriteLine(str2.PadLeft(50));
            Console.WriteLine(str1);


            Console.WriteLine(str2.Remove(0, 5));
            Console.WriteLine(str1);


            Console.WriteLine(str2.Replace('T', 't'));
            Console.WriteLine(str1);

            Console.WriteLine(str2.ToUpper());

            Console.WriteLine(str2);

            Console.WriteLine(str2 + str1);

            Console.WriteLine(string.Concat(str2, str3));

            // Дословноы строки
            Console.WriteLine(@"C:\Users\Tigran\Desktop");
            string mystr = @"This is а very
                                very
                            very
                                    long string";
            Console.WriteLine(mystr);

            str2 = "Hello";
            Console.WriteLine(str2);
        }
    }
}
