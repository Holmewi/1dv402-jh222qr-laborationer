using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3_geometric_figures
{
    public class Ellipse : Shape
    {
        // Implemented properties that overrides the value in the base class Shape
        public override double Area
        {
            get { return 1.5; }     // Temporary return values
        }

        public override double Perimeter
        {
            get { return 1.5; }    // Temporary return values
        }

        // Constructor that gets the values from the base class Shape
        public Ellipse (double lenght, double width) : base(lenght, width)
        {
            
        }
    }
}
