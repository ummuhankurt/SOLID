using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class Square : Shape
    {
        public double ShortEdge { get; set; }
        public double LongEdge { get; set; }
        public Square(double shortEdge , double longEdge)
        {
            ShortEdge = shortEdge;
            LongEdge = longEdge;
        }
        public override double Area()
        {
            return ShortEdge * LongEdge;
        }
    }
}
