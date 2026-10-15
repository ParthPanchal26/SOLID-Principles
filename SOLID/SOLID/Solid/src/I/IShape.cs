namespace Solid.I
{
    interface IShape
    {
        double Area();
        double Volume();

        /* This interface need to be segregated into two separate interfaces.
            Because a 2D shape can not have volume but area.
            
            This segregation enforces Interface Segregation Principle.
            
            Look at these files:
            1. IShape2D
            2. IShape3D

            both circle and Sphere is not implementing separate interfaces
        */

    }
}