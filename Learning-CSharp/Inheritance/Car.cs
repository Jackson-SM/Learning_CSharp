using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning_CSharp.Classes;

namespace Learning_CSharp
{
    internal class Car : Automobile
    {

        public Car(string brand, string model, int manufacturingDate) 
        {
            Brand = brand;
            Model = model;
            ManufacturingDate = manufacturingDate;
        }

        public void ShowInformations()
        {
            Console.WriteLine($"Brand: {Brand}\nModel: {Model}\nManufacturingDate: {ManufacturingDate}");
        }
    }
}
