using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Eagle : Animal, IPredator
    {
        public Eagle(string name, int eyeCount, int age, double weight) : base(name, eyeCount, age, weight)
        {
        }

        public void Hunts()
        {
            Console.WriteLine("Watching from tree top");
        }

        public override void Sleep()
        {
            Console.WriteLine("Nesting");
        }
    }
}
