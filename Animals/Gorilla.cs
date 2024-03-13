using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Gorilla : Mammal
    {
        public Gorilla(string name, int age, double weight) : base(name, age, weight, 2)
        {
           
        }


        public override void Eat()
        {
         
            Console.WriteLine("I am a Gorilla and I eat bananas");
        }
    }
}
