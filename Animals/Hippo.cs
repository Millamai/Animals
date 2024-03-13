using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Hippo:Mammal
    {
        public Hippo(string name, int age, double weight) : base(name, age, weight, 2)
        {
            MilkColour = "Pink";
        }

        public string MilkColour { get; set; }

     
    }
}
