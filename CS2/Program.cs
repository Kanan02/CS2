using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle motorcycle1 = new Motorcycle(120, "Red");
            Motorcycle motorcycle2 = new Motorcycle(150, "Black","RedBull");
            Motorcycle motorcycle3 = new Motorcycle(140, "Green","RedBull",2005,5.6);
            Motorcycle motorcycle4 = new Motorcycle(170, "Yellow","Bentle",2013,6.7);
            Motorcycle motorcycle5 = new Motorcycle(220, "Gray","Porshe",2017,5.6);
            List<Motorcycle> motorcycles = new List<Motorcycle>() {
                motorcycle1,motorcycle2,motorcycle3,motorcycle4,motorcycle5
            };
            motorcycle1.CopySpeedTo(ref motorcycle2);
            
            Console.WriteLine("\t"+ Motorcycle.CountryOfCreation);
            Console.WriteLine();
            foreach (var item in motorcycles)
            {
                item.Print();
            }

        }
    }
}
