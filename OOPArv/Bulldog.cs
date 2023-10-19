using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    class Bulldog : Dog
    {
        public string WrinkleType { get; set; }

        public Bulldog(string name, int age, string breed, string wrinkleType) : base(name, age, breed)
        {
            WrinkleType = wrinkleType;
        }

        public void GuardHouse()
        {
            Console.WriteLine($"{Name} is guarding the house.");
        }
    }
}
