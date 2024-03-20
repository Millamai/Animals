using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract  class Animal
    {
        public string Name { get; set; }

        public int EyeCount { get; protected set; }

        public int Age { get; set; }

        public virtual double Weight { get;  set; }

        public Animal(string name, int eyeCount, int age, double weight)
        {
            Name = name;
            EyeCount = eyeCount;
            Age = age;
            Weight = weight;
        }

        public virtual void Eat() 
        {
            Console.WriteLine("I am an animal and I eat");
        }

        public abstract void Sleep();
    }
}
