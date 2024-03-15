using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Fish : Animal
    {
        public Fish(string name, int eyeCount, int age, double weight) : base(name, eyeCount, age, weight)
        {
        }

        public override void Sleep()
        {
            Console.WriteLine("De-attach brain");
        }
    }
}
