using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly
{
    internal abstract class TwoDimensionalShape:Shape
    {
        public TwoDimensionalShape(double a) : base(a)
        {

        }
        public override abstract double Area 
        { 
            get; 
        }

        public override string ToString()
        {
            return string.Format(" two dimensional shape");
        }
    }
}
