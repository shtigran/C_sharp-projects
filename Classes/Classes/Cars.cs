using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы
{
    class Cars
    {


        private string brand;
        private string model;
        private string color;
        private double price;
        private string country;
        private static string quality = "Supercar";
        private static int count = 0;
        private int speed;

        public Cars(string _Brand = "BMW", string _Model = "M5", string _Color = "Metalic", double _Price = 85000, string _Country = "Germany", int _speed = 0)
        {
            count++;

            Console.WriteLine("We already have {0} cars", count);
            Console.WriteLine(new string('*', 30));
            brand = _Brand;
            model = _Model;
            color = _Color;
            price = _Price;
            country = _Country;
            speed = _speed;
        }
        


        public string Brand
        {
            set {brand = value;}
            get { return brand ; }
        }

        public string Model
        {
            set {model = value;}
            get { return model; }
        }

        public string Color
        {
            set {color = value;}
            get { return color; }
        }

        public double Price
        {
            set
            {
                if (value < 0)
                    price = 0;
                else price = value;
                                      }

            get { return price;} }

        public string Country
        {
        set { if (value.Length > 15) 
               country = value.Substring(0, 15);
        }
        
        get {return country;}


        }

      
        public void display()
        {
            Console.WriteLine("\n");
            Console.WriteLine("=====> Information about car: {0}", this.GetType().Name);
            Console.WriteLine("The brand: {0}\nThe model: {1}\nThe color: {2}\nThe price: {3}$\nThe country: {4}\nThe quality: {5}\n", 
            brand, Model, Color, Price, Country, quality);       
        }

        public void SetSpeed(int a)
        {
            if (a < 50)
                speed = 100;
            else speed = a;
        }

        public void showSpeed()
        { Console.WriteLine("The speed for {0} {1} is: {2}\n", Brand, Model, speed ); }


        }

    }

