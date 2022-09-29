using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course4
{
    internal class varClass
    {
        /*public static void Main(string[] args)
        {
            #region Var Use
            //var age = 25;
            //Console.WriteLine("var holds TYPE: {0} | VAL: {1}", age.GetType(), age);
            //var name = "Pramit";
            //Console.WriteLine("var holds TYPE: {0} | VAL: {1}", name.GetType(), name);

            //int[] odds = new[] { 1, 3, 5, 7, 9 };
            //Console.WriteLine("var holds an array of numbers");
            ////Use the foreach methods to get more marks when accessing an array instead of using a for loop
            //foreach(var num in odds) //the "var" keyword is useful here because everytime it access the array and take the value of a variable
            //                         //after it printed the value here, it destroy the variable saving memory (even though there is a trade off
            //                         //in compilation time)
            //{
            //    Console.WriteLine("TYPE:{0}|VAL:{1}", num.GetType(), num);
            //}
            #endregion

            #region Validation -> if <condition> -> throw <exception>
            var p1 = new Person();
            p1.FirstName = "";
            #endregion

        }*/

        public class Person
        {
            private string _firstName;
            public string FirstName
            {
                get => _firstName;
                set => _firstName = (!string.IsNullOrWhiteSpace(value)) ? value : throw new ArgumentException("First name must not be blank");
                //If we use those kind of throw exception during the midterm exam, we will get more marks.
            }
        }
    }
}
