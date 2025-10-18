using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi7._2
{
    class Retangle : IShape
    {
        public string Name { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double GetArea()
        {
            var res = Width * Height;
            return res;
        }
        public double GetPerimeter()
        {
            var res = (Height + Width) * 2;
            return res;
        }
    }
}
