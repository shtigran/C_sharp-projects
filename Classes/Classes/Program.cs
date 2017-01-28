using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Классы
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars car1 = new Cars ();
            car1.display();
            Cars car2 = new Cars ("Audi", "TT", "Red", 50000, "Germany", 280);
            car2.display();
            Cars car3 = new Cars (_Model: "Z4", _Price: 50000);
            car3.display();

            car1.SetSpeed(320);
            car1.showSpeed();
            car3.SetSpeed(270);
            car2.showSpeed();
            car3.showSpeed();

            Console.ReadKey();
        }
    }
}
