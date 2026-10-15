using System;

namespace Solid.L
{

    // class Square : Rectangle
    class Square : Shape
    {
        // public override double Width { get => base.Width; set => base.Width = base.Height = value; }
        // public override double Height { get => base.Height; set => base.Height = base.Width = value; }

        // public override double Area => Width * Height;

        /* Inheriting square from rectangle is correct because square is special type of rectangle which as same side length
            But adding separate properties and setting them to be same is unnecessary

            Also the Area class contains a method which takes Shape as parameter.
            We extended shape -> rectangle -> square to just get the area of shape

            Here in Area class method we can pass any parameter which is extended from shape
            so instead of extending shape -> rectangle -> square
            we directly extend shape -> square and set properties related to square only and avoid overriding rectangle properies

            With this approach at time of invoking Area method we can pass any shape which can contain any properties but will 
            have Area property because it extends shape class

            With this approach we can substitute different child class in Area class method without affecting behavior
            of the method.
         */

        public double SideLength { get; set; }
        public override double Area => SideLength * SideLength;

    }

}