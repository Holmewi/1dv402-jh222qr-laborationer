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
            get { return _width ; }

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
            get { return _length; }

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

        // Constructor responsible that the fields, through the properties, gets the value to it's parameters
        protected Shape (double lenght, double width)
        {
            _length = Length;
            _width = Width;
        }

        // Method that override the same method in the base class Object
        public override string ToString()
        {
            return "Temp";      // Temporary string value
        }
    }
}
