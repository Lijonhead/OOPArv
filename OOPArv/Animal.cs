using OOPArv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPArv
{
    internal class Animal
    {
        
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public string Habitat { get; set; }
        public string Sound { get; set; }

        
        public Animal(string name, int age, string species, string habitat, string sound)
        {
            Name = name;
            Age = age;
            Species = species;
            Habitat = habitat;
            Sound = sound;
        }

        
        public void MakeSound()
        {
            Console.WriteLine($"{Name} makes a {Sound} sound.");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }


    }
}