using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace buoi7
{
    public class Duck :  Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} keu Cap cap");
        }
    }
}
