using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly
{
    internal class Sphere : ThreeDimensionalShape
    {
        public Sphere(double a) : base(a) { }
        public override double Area
        {
            get { return Math.PI * 4 * Math.Pow(base.Side, 2); }
                
        }
        public override double Volume
        {
            get { return(4*Math.PI*Math.Pow(base.Side, 3)); }
        }
        public override string ToString()
        {
            return string.Format("Sphere")+base.ToString();
        }
    }
}
