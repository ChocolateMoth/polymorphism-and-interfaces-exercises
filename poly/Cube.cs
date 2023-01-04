using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly
{
    internal class Cube:ThreeDimensionalShape
    {
        public Cube(double a) : base(a) { }
        public override double Area
        {
            get { return 6 * Math.Pow(base.Side, 2); }

        }
        public override double Volume
        {
            get { return Math.Pow(base.Side, 3); }
        }
        public override string ToString()
        {
            return string.Format("Cube") + base.ToString();
        }
    }
}
