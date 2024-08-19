using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CircleObjects
{
    //Circle class
    public class Circle
    {
        //Properties
        private double Radius;
        
        //Constructor
        public Circle (double _radius)
        {
            Radius = _radius;
        }
        //Calculate Diameter method
        public double CalculateDiameter()
        {
            return 2 * Radius;
        }

        //Calculate circumference method
        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }

        //Calculate area method
        public double CalculateArea()
        {
            return Math.PI * (Radius * Radius);
        }

        //Grow the circle method
        public void Grow()
        {
            System.Console.WriteLine("The circle is growing!");
            System.Console.WriteLine();
            Radius = Radius * 2;
        }

        //Get radius method
        public double GetRadius()
        {
            return Radius;
        }
    }
}