using System.ComponentModel.DataAnnotations;

namespace Solid.O
{
    class Rectangle : Shape
    {

        public double Length { get; set; }
        public double Width { get; set; }

        public override double CalculateArea()
        {
            return Length * Width;
        }

    }
}