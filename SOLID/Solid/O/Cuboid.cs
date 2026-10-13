namespace Solid.O
{
    class Cuboid : Shape
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            return 2 * ((Length*Breadth) + (Breadth*Height) + (Height*Length));
        }
    }
}