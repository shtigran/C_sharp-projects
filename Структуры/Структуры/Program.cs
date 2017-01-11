using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Структуры
{
    class Program
    {
        static void Main(string[] args)
        {

            names name1 = new names ();
            names name2 = new names ();
            name2.Name = "Shakhbekyan";
            name1.Name = "Tigran";

            point p1 = new point (8,9, name2);
            point p2 = new point (5, 6, name1);
           
            
            p1.display();
            p2.display();
            Console.WriteLine();
            Console.WriteLine();
            p2 = p1;
            p1.display();
            p2.display();
            p1.x = 20;
            p1.pname.name = "New name";
            Console.WriteLine();
            Console.WriteLine();
            p1.display();
            p2.display();


            Console.ReadKey();
        }


        class names
        {
        

       public string Name 
       {
        set {name = value;}
        get {return name;}
        
       }

       public string name;
        }


        struct point
        {
          public  int x;
          public  int y;
          public names pname;

          public point(int a, int b, names _name)
          {

              x = a;
              y = b;
              pname = _name;
          }

            


            public void display ()
            {
            Console.WriteLine("===> Information about point:");
            Console.WriteLine("X is: {0}\n Y is: {1}\n Name is: {2}", x , y, pname.Name);
            }

        
        }
    }
}
