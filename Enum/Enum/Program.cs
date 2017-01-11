using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Perecheslenie

{
    class Program
    {
        static void Main(string[] args)
        {

            soccers soccer1 = soccers.Mkitaryan;
            DayOfWeek day = DayOfWeek.Friday;
            ConsoleColor col = ConsoleColor.Black;
            ConsoleKey ke = ConsoleKey.Backspace;

            Console.WriteLine(soccer1.GetType().Name);
            Console.WriteLine(Enum.GetUnderlyingType(soccer1.GetType()));

            func(soccer1);
            Console.WriteLine(new string ('#', 30));
            func(day);
            Console.WriteLine(new string('#', 30));
            func(col);
            Console.WriteLine(new string('#', 30));
            func(ke);



                Console.ReadKey();
        }

        enum soccers
        { 
         Messi, Ronaldo, Movsisyan, Beckham, Roney, Mkitaryan    
        }

        static void func(System.Enum ex)
        {
            Console.WriteLine( "====> Inforamtion about enum: {0}", ex.GetType().Name );
            Console.WriteLine("Current name: {0}", Enum.GetUnderlyingType(ex.GetType()));
            Array enumArray = Enum.GetValues(ex.GetType());
            Console.WriteLine("Enum consists of {0} numbers!", enumArray.Length);
            Console.WriteLine("There are the numbers");
            for (int i = 0; i < enumArray.Length; i++)
                Console.WriteLine(enumArray.GetValue(i));     
        
        }



    }
}
