using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly
{
    class Circle: TwoDimensionalShape
    {
        public Circle(double a): base(a) { }
        public override double Area
        {
            get { return Math.PI * base.Side; }
        }
        public override string ToString()
        {
            return string.Format("Circle")+base.ToString();
        }
    }
}
