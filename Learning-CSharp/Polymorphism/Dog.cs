using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning_CSharp.Classes;

namespace Learning_CSharp.Inheritance
{
    internal class Dog : Animal
    {
        public Dog(string nome)
        {
            Nome = nome;
        }

        public override void EmitSound()
        {
            Console.WriteLine("O Cachorro está latindo");
        }
    }
}
