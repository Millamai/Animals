using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Mammal : Animal
    {
        public Mammal(string name, int age, double weight, int nibbleCount) : base(name, 2, age, weight)
        {
            TitsCount = nibbleCount;

           
        }

        public int TitsCount { get; set; }

        public void BreastFeed() {

            Console.WriteLine("I am an Mammal and I am currently breastfeeding");
        }
    }
}
