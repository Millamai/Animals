using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Wolf : Mammal,IPredator
    {
        public Wolf(string name, int age, double weight, int nibbleCount) : base(name, age, weight, nibbleCount)
        {
        }

        public void Hunts()
        {
            Console.WriteLine("Ligger på lur");
        }

        public override void Sleep()
        {
            Console.WriteLine("Sleeping with one eye open");
        }
    }
}
