using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly
{
    internal class Square: TwoDimensionalShape
    {
        public Square(double a ): base(a)
        {

        }
        public override double Area
        {
            get { return Math.Pow( base.Side, 2); }
        }
        public override string ToString()
        {
            return string.Format("square,")+base.ToString();
        }
    }
}
