﻿namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to animal kingdom");

            /*  Animal a = new Animal("Hippo",2,2,300);


              Mammal m = new Mammal("Hippo", 2, 300, 2);

              Console.WriteLine("Hippo weigth " + m.Weight);
              m.BreastFeed();
              m.Eat();*/

            Hippo hippo = new Hippo("Knud", 2, 300);

            hippo.Eat();


            Gorilla g = new Gorilla("Bent", 4, 150);
            g.Eat();




            Animal jens = new Hippo("Jens", 8, 456);

            Fish f = new Fish("Mogens", 2, 1, 0.100);
            List<Animal> list = new List<Animal>();

            list.Add(hippo);
            list.Add(jens);
            list.Add(g);
            list.Add(f);

            foreach (Animal a in list)
            {

                Console.WriteLine($"{a.Name}");
                if (a is Mammal)
                {
                    ((Mammal)a).BreastFeed();
                }

            }



        }


    }
}
