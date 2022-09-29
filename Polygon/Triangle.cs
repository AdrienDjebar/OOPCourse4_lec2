using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course4.Polygon
{
    internal class Triangle : IPolygon, IColor //Now we can make the class Rectangle inherit from multiples interface
    {
        //implementation of IPolygon interface
        private string _name;
        public string Name // reead-write instance proprety
        {
            get => _name;
            set => _name = value;
        }
        private int _numOfSides;
        public int NumOfSides //read-only instance property
        {
            get => _numOfSides;
            private set => _numOfSides = value;
        }
        public void calculateArea(int[] sides)
        {
            var s = (sides[0] + sides[1] + sides[2]) / 2;
            double area = Math.Sqrt(s * (s - sides[0]) * (s - sides[1]) * (s - sides[2]));
            Console.WriteLine($"Area of {Name} is {area}");
        }
        //implementation of IColor interface
        public void getColor()
        {
            Console.WriteLine("Green Triangle");
        }
        public Triangle() => _numOfSides = 3;
    }
}
