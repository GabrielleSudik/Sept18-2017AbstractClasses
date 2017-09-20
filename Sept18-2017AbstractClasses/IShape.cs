using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept18_2017AbstractClasses
{
    interface IShape //created same way as class, just select different thing from drop down
    {
        string Name { get; set; } //the property

        void GetInfo(); //you can't add a body to interface methods

        double Area(); //ditto. the bodies are in the derived classes.


    }
}
