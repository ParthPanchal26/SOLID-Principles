namespace Solid.I
{
    // class Circle : IShape
    // {

    //     public double Radius { get; set; }

    //     public double Area()
    //     {
    //         return Math.PI * Math.Pow(Radius, 2);
    //     }

    //     public double Volume()
    //     {
    //         throw new Exception("A 2D shape can not have volume");
    //     }
    // }

    class Circle : IShape2D
    {
        public double Radius { get; set; }
        
        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}