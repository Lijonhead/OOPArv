using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    class Cat : Animal
    {
        public string Color { get; set; }

        public Cat(string name, int age, string color) : base(name, age, "Cat", "Indoor", "Meow")
        {
            Color = color;
        }

        public void Climb()
        {
            Console.WriteLine($"{Name} is climbing a tree.");
        }
    }
}
