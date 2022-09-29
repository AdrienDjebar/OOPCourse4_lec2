using OOP_Course4.Polygon;
using System;
using System.Runtime.CompilerServices;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.Name = "rectangle_1";
            r1.calculateArea(new int[] {100, 200});
            r1.getColor();

            Triangle t1 = new Triangle();
            t1.Name = "triangle_1";
            t1.calculateArea(new int[] { 100, 200, 300 });
            t1.getColor();
        }
    }
    abstract class Motorcycle
    {
        double miles = 10;
        double speed = 100;
        //When defining abstract methods you have to define it like this : <access_modifier (public, private, protected...)> abstract <type (void, int, bool..)> name(); (withtout the {})
        //Anyone can call this.
        public void StartEngine() { /* Methods statement here */ }

        //Only derived classes can call this.
        protected void AddGas(int gallons) { /* Methods statement here */ }

        //Derived classes can override the base class implementation
        //if the derived classes (the childrens) does not override it
        //it will carry on the base definition of the methods to the derived class.
        //that's why we have to define it clearly (here by saying return 1;)
        public virtual int Drive(int miles, int speed)
        {
            return (int)Math.Round(((double)miles) / speed, 0);
        }

        //Derived classes can override the base class implementation.
        public virtual int Drive(TimeSpan time, int speed) { /* Method statements here */ return 0; }

        //Derived classes must implement this.
        public abstract double GetTopSpeed();
    }
    class SportsMotorCycle : Motorcycle
    {
        double _weightRatio = 1.2;
        public override int Drive(int miles, int speed)
        {
            return base.Drive(miles, speed) * (int)_weightRatio; //"base." is used to call the previously defined method
        }
        //Since we created a class which is a child of Motorcycle, we HAVE to define EVERY abstract methods from MotorCycle class.
        //We define those by using the override keyword.
        public override double GetTopSpeed() { return 70.05; }

    }
    class SportsMotorCycleWithSideCar : Motorcycle
    {
        float _weightRatio = 0.8f;
        public override int Drive(int miles, int speed)
        {
            return base.Drive(miles, speed) * (int)_weightRatio;
        }

        //Still defining the abstract method "GetTopSpeed"
        public override double GetTopSpeed()
        {
            return 0;
        }
    }

    /*
    The internal keyword make the method accessible within it's own assembly, but not from another assembly.
    but, an assembly is defined by the "Namespace", which means if one my program assembly is "NameSpace1"
    and another one called "NameSpace2". The methods marked as internal is the "NameSpace1" cannot be used
    in the "NameSpace2" assembly. Btw, the namespace is defined by the name of the program, like "Program.cs"
    "Program is the namespace"
    */

}
