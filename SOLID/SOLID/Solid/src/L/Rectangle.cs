namespace Solid.L
{
    class Rectangle : Shape
    {

        public virtual double Height { get; set; }
        public virtual double Width { get; set; }

        public override double Area => Width * Height;
    }
}