using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Hippo : Mammal
    {
        public Hippo(string name, int age, double weight) : base(name, age, weight, 2)
        {
            MilkColour = "Pink";
        }




        public override double Weight
        {
            get { return base.Weight; }
            set
            {
                if (value > 3200)
                {
                    throw new ArgumentException("To big");
                }

                base.Weight = value;

            }
        }


        public string MilkColour { get; set; }

        public override void Sleep()
        {
            Console.WriteLine("Sleeping heavily");
        }
    }
}
