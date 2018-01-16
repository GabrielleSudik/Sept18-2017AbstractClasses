using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept18_2017AbstractClasses
{
    abstract class Shape //that's it! "abstract" makes it abstract
    {
        //property:

        public string Name { get; set; }
        //note we didn't create the field/variable.
        //VS creates one for us
        //but Jordan is glossing over why.
        //not unique to abstract classes
        //the shorthand get set thing will create it in the background

        //constructor:

        public Shape(string name)
        {
            Name = name;
        }

        //note you don't NEED a default constructor in the abstract class
        //you can make the derived classes do it instead
        //think of it this way:
        //you'll never create an instance of the abstract class,
        //so you don't need to know how to build it!

        //method:

        abstract public double Area(); //we made this abstract
                                       //why?
                                       //because the concept of area doesn't apply to an imaginary shape
                                       //note lack of {}
                                       //abstract methods can't do anything, so no body

        public void GetInfo()
        {
            //you CAN create methods that do things in abstract classes
            //because this method isn't dependent on specifics of the thing you create
            //ie, everything has a name. not all shapes have the same formula to calculate area.
            //I feel like I'm back in philosophy class

            Console.WriteLine($"I am a {Name}.");
        }
    }
}
