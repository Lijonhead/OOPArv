using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, int age, string breed) : base(name, age, "Dog", "Various", "Bark")
        {
            Breed = breed;
        }

        public void Fetch()
        {
            Console.WriteLine($"{Name} is fetching a ball.");
        }
    }
}
