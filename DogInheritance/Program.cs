using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog fido = new Dog();
            Dog milo = new Dog() {Name = "Milo", Weight = 2, BarkSound = "Arf!" };
            Dog terry = new Dog("Terry", 5);
            Dog roover = new Dog("Roover", 3);
            Hamster Cotton = new Hamster() { Name = "Cotton" };
            Cat Bella = new Cat() { Name = "Bella", Weight = 5 };
            Besenji Cheddar = new Besenji() { Name = "Cheddar" };
            Bella.HappyBrithday();
            Cotton.HappyBrithday();


            List<Pet> pets = new List<Pet>();
            pets.Add(fido);
            pets.Add(milo);
            pets.Add(terry);
            pets.Add(roover);
            pets.Add(Cotton);
            pets.Add(Bella);
            pets.Add(Cheddar);

            foreach (Pet p in pets)
            {
                Console.WriteLine(p.About());
                if (p is Dog)
                {
                    ((Dog)p).Bark();
                }
                if (p is Hamster)
                {
                    Console.WriteLine(((Hamster)p).IsStinky);
                }
            }

            Console.ReadLine();

            
        }
    }
}
