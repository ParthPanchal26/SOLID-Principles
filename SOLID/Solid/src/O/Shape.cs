namespace Solid.O
{
    // class Shape
    // {
    //     public ShapeType Type { get; set; }
    //     public double Radius { get; set; }
    //     public double Length { get; set; }
    //     public double Width { get; set; }

    //     public double CalculateArea()
    //     {
    //         switch (Type)
    //         {
    //             case ShapeType.Circle:
    //                 return Math.PI * (Radius * Radius);
    //             case ShapeType.Rectangle:
    //                 return Length * Width;
    //             default:
    //                 throw new Exception("Unsupported shape type");
    //         }
    //     }
    // }

    /* This Shape class consist of fixed properties and a CalculateArea method with a switch based calculation approach.
        
        If we add other types to ShapeType enum then we need to update this class
        Then we also need to upadte the swith case written inside the CalculateArea to return shape based area 
    
        This introduced problems violates Open/Close principal.
        
        The Open/Close pricipal says that a class should be open to be extended but should be closed for the modifications.
        
        Therefore we create an abstract class which enforce overriding CalculateArea method with properies belonging to shape only.
    */

    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    /* Now we can create different shape classes which will extend this class or in simple terms inherit this Shape class and they will 
        required to override CalculateArea method to return shape's area.

        Look at Circle, Rectangle and Cuboid classes.
    */

}