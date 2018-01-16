using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept18_2017AbstractClasses
{
    class Circle : IShape
    {
        public string Name { get; set; } //one property, found in IShape

        public double Radius { get; set; }  //another property, specific to Circle

        public static int circleNumber;

        public Circle(string name, double radius) //the constructor, taking two parameters
        {
            Name = name;
            Radius = radius;
            circleNumber += 1;
        }
        public double Area()  //Area method
        {
            double pi = Math.PI; //that's a built-in class

            return pi * Radius * Radius; //also can be written Math.Pow(Radius, 2) -- number to the power of
        }

        public void GetInfo()  //GetInfoMethod
        {
            Console.WriteLine($"I am a {Name}.");
        }

        public void NumOfCircles()
        {
            Console.WriteLine($"The number of circles is {circleNumber}.");
        }

        //sigh... this bit of instruction was very messy, and so now my code is too
    }
}
