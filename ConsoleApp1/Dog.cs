using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi7
{
    public class Dog: Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} keu Gau gau");
        }
    }
}
