using Solid.L;
using Solid.O;
using Solid.S;
using Solid.src.D;

namespace Solid
{
    public class Program
    {
        static void Main(string[] args)
        {

        /* 1. Single Responsibility */
            // var S = new UserService();
            // S.Register(new User { Username = "parthdp", Email = "parthdp@example.com" });

        /* 2. Open/Close Principle */
            // var circle = new Circle();
            // circle.Radius = 3.2;
            // var c_area = circle.CalculateArea();
            // System.Console.WriteLine($"Circle Area: {c_area}");

            // var rectable = new Rectangle();
            // rectable.Length = 5;
            // rectable.Width = 4;

            // var r_area = rectable.CalculateArea();
            // System.Console.WriteLine($"Rectangle Area: {r_area}");

            // var cuboid = new Cuboid();
            // cuboid.Length = 5;
            // cuboid.Breadth = 4;
            // cuboid.Height = 3;

            // var cb_area = cuboid.CalculateArea();
            // System.Console.WriteLine($"Cuboid Area: {cb_area}");

        /* 3. Liskov Substitution Principle */
            // var shape = new Area();

            // var r_area = shape.GetArea(
            //     new L.Rectangle
            //     {
            //         Height = 5,
            //         Width = 4
            //     }
            // );

            // var s_area = shape.GetArea(
            //     new L.Square
            //     {
            //         SideLength = 5
            //     }
            // );

            // System.Console.WriteLine($"Rectangle Area : {r_area}");
            // System.Console.WriteLine($"Square Area : {s_area}");


            var c = new Car(new Engine());
            c.StartCar();
            

        }
    }
}
