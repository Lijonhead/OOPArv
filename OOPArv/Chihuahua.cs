using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    class Chihuahua : Dog
    {
        public string Size { get; set; }

        public Chihuahua(string name, int age, string breed, string size) : base(name, age, breed)
        {
            Size = size;
        }

        public void ShakePaws()
        {
            Console.WriteLine($"{Name} is shaking paws.");
        }
    }
}
