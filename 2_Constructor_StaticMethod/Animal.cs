using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStarttoFinish._2_
{
    internal class Animal
    {
        public string name;
        public string sound;

        static int numOfAnimals = 0;

        // A constructor sets default values for
        // fields when an object is created
        // This is the default constructor if no
        // parameters are sent
        public Animal()
        {
            name = "No Name";
            sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(string name = "No Name")
        {
            // This refers to this objects name
            // instead of the name passed into
            // the constructor
            this.name = name;
            this.sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(string name = "No Name",
            string sound = "No Sound")
        {
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}",
                name, sound);
        }

        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }
    }
}
