using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp
{
    internal class Automobile
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ManufacturingDate {get; set;}

        public void Acelerar()
        {
            Console.WriteLine("O Automóvel está acelerando!");
        }
        public void Frear()
        {
            Console.WriteLine("O Automóvel está freando!");
        }
    }
}
