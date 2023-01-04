using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly
{
    abstract class ThreeDimensionalShape:Shape
    {
        public ThreeDimensionalShape(double a) : base(a)
        {

        }
        public override abstract double Area
        {
            get;
        }
        public abstract double Volume
        {
            get;
        }
        public override string ToString()
        {
            return String.Format("is a three dimensional shape");
        }
    }
}
