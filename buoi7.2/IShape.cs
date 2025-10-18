using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi7._2
{
    public interface IShape
    {
        public string Name { get; set; } 
        double GetArea();
        double GetPerimeter();

    }
    
    

}
