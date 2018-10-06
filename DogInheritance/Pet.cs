using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogInheritance
{

    public class Pet
    {
    protected int Age;
    public string Name;
    public int Weight;

        public Pet() : this("Fido") { }
        public Pet(string DogName) : this(DogName, 1) { }

        public Pet(string DogName, int DogAge)
        {
            this.Name = DogName;
            this.Age = DogAge;
            this.Weight = 2;
            
        }
        public void HappyBrithday()
        {
            this.Age++;
        }
        public string About()
        {
            string strAbout = $"\nHello my name is {this.Name}. " +
                $"I'm {this.Age} and weigh {this.Weight}. "; 
                //$"\nMy bark sounds like {this.Bark()}";
            return strAbout;
        }
    }
}