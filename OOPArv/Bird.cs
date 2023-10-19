using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    class Bird : Animal
    {
        public double Wingspan { get; set; }

        public Bird(string name, int age, double wingspan) : base(name, age, "Bird", "Sky", "Chirp")
        {
            Wingspan = wingspan;
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} is flying in the sky.");
        }
    }
}
