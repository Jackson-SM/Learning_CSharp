using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp
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
