using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3_geometric_figures
{
    public class Rectangle : Shape
    {
        // Implemented properties that overrides the value in the base class Shape
        public override double Area
        {
            get { return Length * Width; }
        }

        public override double Perimeter
        {
            get { return 2 * Length + 2 * Width; }
        }

        // Constructor that gets the values from the base class Shape
        public Rectangle (double lenght, double width) : base(lenght, width)
        {
            
        }
    }
}
