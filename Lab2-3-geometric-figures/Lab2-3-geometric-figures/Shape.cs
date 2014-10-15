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
        public double Width
        {
            get { return _width ; }     // Temporary return values

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _width = value; 
            }
        }

        public double Length
        {
            get { return _length; }     // Temporary return values

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _length = value;               
            }
        }

        public abstract double Perimeter
        {
            get; // Tar värdet från Ellipse och Rectangle
        }

        public abstract double Area
        {
            get; // Tar värdet från Ellipse och Rectangle
        }  

        // Constructor
        protected Shape (double lenght, double width)
        {

        }

        // Method
        public string ToString()
        {
            return "Temp";      
        }
    }
}
