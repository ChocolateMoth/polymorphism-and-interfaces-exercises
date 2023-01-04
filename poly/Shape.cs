using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly
{
    abstract class Shape
    {
        
        public Shape (double sideSize)
        {
            Side= sideSize;
        }
        public double Side
        { get; set; }
        public abstract double Area
        {
            get;
        }
        public abstract override string ToString();


    }
}
