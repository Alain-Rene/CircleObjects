using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CircleObjects
{
    public class Circle
    {
        //Properties
        private double Radius;
        
        //Constructor
        public Circle (double _radius)
        {
            Radius = _radius;
        }

        public double CalculateDiameter()
        {
            return 2 * Radius;
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }

        public double CalculateArea()
        {
            return Math.PI * (Radius * Radius);
        }

        public void Grow()
        {
            System.Console.WriteLine("The circle is growing!");
            System.Console.WriteLine();
            Radius = Radius * 2;
        }

        public double GetRadius()
        {
            return Radius;
        }
    }
}