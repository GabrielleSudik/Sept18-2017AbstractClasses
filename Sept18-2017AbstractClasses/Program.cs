using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept18_2017AbstractClasses
{
    class Program

        //nothing can actually be part of an abstract class
        //it needs an interface with some other class

    //er shoot -- you got those two concepts all messed up lol
    //fix when we do class exercises

        //what are they for?
        //multilevel inheritance

        //think about the employee project...
        //the employee class could have been abstract
        //because no one was ONLY an employee. they were also doctor or nurse, etc.

    //APIE : abstraction, ploymorphism, inheritance, encapsulation
    //the 4 pillars of something... classes or whatever


    {
        static void Main(string[] args)
        {
            Square square1 = new Square("square", 3); //constructor needs name and length
                                                    //so you put them here

            square1.GetInfo();
            Console.WriteLine($"Area = {square1.Area()}.");

            Circle circle1 = new Circle("circle", 3);

            circle1.GetInfo();
            Console.WriteLine($"Area = {circle1.Area()}.");
            circle1.NumOfCircles();

            Circle circle2 = new Circle("circle", 3);

            circle2.GetInfo();
            Console.WriteLine($"Area = {circle2.Area()}.");
            circle2.NumOfCircles();


            Console.ReadLine();

            //an advantage to abstract classes: they will give you buildtime errors
            //these are better than runtime errors, because you can see them.
            //they kind of force all the derived classes to have the necessary pieces.
        }

        //INTERFACE
        //cannot have code in body (of methods only??)
        //must use all members (of what lol)
        //all members are public
        //cannot have constructors
        //you can create an instance of, but with no body code, there's no reason to

        //ABSTRACT
        //does not require body code (but can have it)
        //only required to use all abstract members
        //can have constructors
        //cannot create an instance of
        //cannot be sealed
        //can only be base class

        //Jordan recommends focus on abstract classes more than interface classes

    }
}
