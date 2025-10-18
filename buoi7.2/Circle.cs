using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi7._2
{
    class Circle : IShape
    {
        public string Name { get; set; }
        public double Radius { get; set; }
        public double GetArea()
        {
            var res = Math.PI * Radius * Radius;
            return res;
        }

        public double GetPerimeter()
        {
            var res = 2 * Math.PI * Radius;
            return res;
        }
    }
}
