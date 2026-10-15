using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.src.D
{
    //internal class Car
    //{
    //    private Engine engine;

    //    public Car()
    //    {
    //        this.engine = new Engine();
    //    }

    //    public void StartCar()
    //    {
    //        engine.Start();
    //        Console.WriteLine("Car Started");
    //    }

    //}

    /* This class is heavily dependent on the Engine class
       If we might decide to have electric engine than we need to change Engine class it self
    
        Therefor we create one interface which implemented by the different engine class which contains common start method

        This way we can implement any engine class while having same contract

        This is the also one way on implementing dependency injection

     */

    internal class Car
    {
        private IEngine engine;

        public Car(IEngine engine)
        {
            this.engine = engine;
        }

        public void StartCar()
        {
            this.engine.StartEngine();
            Console.WriteLine("Car Started");
        }

    }

}
