using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_with_common_types
{
    class Program
    {
        static void Main(string[] args)
        {

            // из int  в String
            int a = 1;
            Console.WriteLine(a);
            string str = a.ToString();
            Console.WriteLine(str);
            Console.WriteLine();
                        
            double b = double.Parse("123,456");
            Console.WriteLine(b);
            Console.WriteLine();

            ValueOfTypes();
            Console.WriteLine();


            int [] masiv = new int [4];
            foreach (int ch in masiv)
                Console.WriteLine(ch);
            for (int i = 0; i < masiv.Length; i++)
                masiv[i] = (i + 1) * 2;
            foreach (int ch in masiv)
                Console.WriteLine(ch);


            









                Console.ReadKey();
        }

        private static void ValueOfTypes()
        {
            // Максималные и минимальные значения типов
            Console.WriteLine("sbyte maxValue: {0}", sbyte.MaxValue);
            Console.WriteLine("sbyte minValis: {0}", sbyte.MinValue);
            Console.WriteLine("byte maxValue: {0}", byte.MaxValue);
            Console.WriteLine("byte minValis: {0}", byte.MinValue);
            Console.WriteLine("Int maxValue: {0}", int.MaxValue);
            Console.WriteLine("Int minValis: {0}", int.MinValue);
            Console.WriteLine("uInt maxValue: {0}", uint.MaxValue);
            Console.WriteLine("uInt minValis: {0}", uint.MinValue);
            Console.WriteLine("long maxValue: {0}", long.MaxValue);
            Console.WriteLine("long minValis: {0}", long.MinValue);
            Console.WriteLine("ulong maxValue: {0}", ulong.MaxValue);
            Console.WriteLine("ulong minValis: {0}", ulong.MinValue);
            Console.WriteLine("float maxValue: {0}", float.MaxValue);
            Console.WriteLine("float minValis: {0}", float.MinValue);
            Console.WriteLine("decimal maxValue: {0}", decimal.MaxValue);
            Console.WriteLine("decimal minValis: {0}", decimal.MinValue);
        }
    }
}
