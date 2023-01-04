using System.Linq.Expressions;

namespace poly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[4];
            shapes[0] = new Circle(5);
            shapes[1] = new Square(5);
            shapes[2] = new Sphere(5);
            shapes[3] = new Cube(5);

            foreach(Shape ele in shapes)
            {
                Console.WriteLine(ele);
                Console.WriteLine("area is {0:N}", ele.Area);
                if(ele is ThreeDimensionalShape)
                {
                    ThreeDimensionalShape three = (ThreeDimensionalShape)ele;
                    Console.WriteLine("the volume is {0:N}", three.Volume);
                }
                else
                {

                }
            }


            
        }
    }
}