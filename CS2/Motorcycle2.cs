using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2
{
    partial class Motorcycle
    {
        public void Print()
        {
            Console.WriteLine($"Modelname: {modelName}\n Speed: {speed}\nEngine Volume: {engineVolume}\n Color: {color}\nYear of Creation: {yearOfCreation}\n ");
        }
    }
}
