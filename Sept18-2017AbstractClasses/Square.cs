using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept18_2017AbstractClasses
{
    class Square : Shape
    {
        //property:

        public double Length { get; set; }

        //constructor -- must reference abstract base class too.

        public Square(string name, double length) : base(name) //constructor in base class references name, so it does here too
        {
            Length = length;
        }

        //method:
        //overrides base method (the one that doesn't do anything)

        public override double Area() //return type must be same as in abstract (ie, double)
        {
            return Length * Length;
        }
    }
}
