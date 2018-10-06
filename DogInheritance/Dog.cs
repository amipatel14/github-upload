using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogInheritance
{
    public class Dog : Pet
    {

        public string BarkSound;
        

        //Constructor
        public Dog() : this("Fido") {}
        public Dog(string DogName) : this(DogName, 1) {}

        public Dog(string DogName, int DogAge)
        {
            this.Name = DogName;
            this.Age = DogAge;
            this.Weight = 2;
            this.BarkSound = "Woof!";
        }

        //Methods
        /// <summary>
        /// The Dog barks and says it's barksound
        /// </summary>
        public virtual string Bark()
        {
            return this.BarkSound;
        }
        public virtual string Bark(int HowManyTimes)
        {
            string bark = "";
            for (int i = 0; i < HowManyTimes; i++)
            {
                bark += this.Bark() + " ";
            }
            return bark;
        }

       
    }
}