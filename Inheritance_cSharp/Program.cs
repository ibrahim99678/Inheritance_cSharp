using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_cSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Interitance : one or more child classes receiving fields, methods, etc. from a common parents. 


            Car car = new Car();
            Bicle bicle = new Bicle();
            Boat boat = new Boat();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);                              //here we use the parents mathod value to every child.
            car.go();

            Console.WriteLine(bicle.speed);
            Console.WriteLine(bicle.wheels);
            bicle.go();

            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            boat.go();

            Console.ReadKey ();
        }
        class vehicle                                                 //declar a class 
        {           
            public int speed = 0;                                    //declar a variable
            
            public void go()                                         // declar a method 
            {
                Console.WriteLine("This vechicle is moving !!");
            }
            
        }
        
        class Car : vehicle                                          //here car is child and vehicle is parent
        {
            public int wheels = 4;

        }
        class Bicle : vehicle
        {
            public int wheels = 2;

        }
        class Boat : vehicle
        {
            public int wheels = 0;
        }
    }
    

}
