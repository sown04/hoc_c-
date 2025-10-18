using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace buoi7
{
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} keu Meow moew");
        }
    }
}
