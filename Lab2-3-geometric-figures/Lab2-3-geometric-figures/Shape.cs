using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3_geometric_figures
{
    public abstract class Shape
    {
        // Fields
        private double _length;
        private double _width;

        // Properties
        public abstract double Area
        {
            get { return 1.5; }     // Temporary return values
        }

        public double Length
        {
            get { return 2.5; }     // Temporary return values

            set { }
        }

        public abstract double Perimeter
        {
            get { return 1.5; }    // Temporary return values
        }

        public double Width
        {
            get { return 2.5; }     // Temporary return values

            set { }
        }

        // Constructor
        protected Shape (double lenght, double width)
        {

        }

        // Method
        public string ToString()
        {
            return "Temp";          // Temporary return values
        }
    }
}
