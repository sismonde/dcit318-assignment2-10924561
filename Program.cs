using System;
using Assignment2;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Animal genericAnimal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            Console.WriteLine("Animal Sounds:");
            genericAnimal.MakeSound();  
            dog.MakeSound();            
            cat.MakeSound();            

            Console.WriteLine();

            
            Shape circle = new Circle(6);
            Shape rectangle = new Rectangle(7, 8);

            Console.WriteLine("Shape Areas:");
            Console.WriteLine($"Area of Circle: {circle.GetArea()}");      
            Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}"); 

            Console.WriteLine();

            // Display output for Movable classes
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            Console.WriteLine("Movable Objects:");
            car.Move();        
            bicycle.Move();    
        }
    }
}