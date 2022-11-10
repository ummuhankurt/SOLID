using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 5);
            Circle circle = new Circle(3);
            Square square = new Square(2, 8);
            Rectangle[] rectangles =
            {
                new Rectangle(2,2),
                new Rectangle(4,4),
            };
            Circle[] circles =
            {
                new Circle(3),
                new Circle(5)
            };
            AreaCalculator areaCalculator = new AreaCalculator();
            Console.WriteLine(areaCalculator.Area(rectangles));
            Console.WriteLine(rectangle.Area());
            Console.WriteLine(circle.Area());
            Console.WriteLine(square.Area());
            Console.ReadKey();
        }
    }
}
