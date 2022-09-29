using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course4.Polygon
{
    interface IPolygon
    {
        string Name
        {
            get;
            set;
        }
        int NumOfSides
        {
            get;
            //private set; will not work but we will define it in a derived class from the interface
        }
        void calculateArea(params int[] args);
    }

    interface IColor
    {
        void getColor();
    }
}
