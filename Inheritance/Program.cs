﻿using System;

namespace Inheritance
{
    class Program(Animal animal)
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *
             * Creatively display the class member values
             */
            var bird = new Bird();
            bird.LayEggs = true;
            bird.CanFly = true;
            bird.HaveLegs = true;
            bird.FeatherColor = "Red";



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */
            var snake = new Reptile()
            {
                IsColdBlooded = true,
                LayEggs = true,
                HaveLungs = true,
                Habitat = "Forest",
                IsSkaly = true,
            };

            var animals = new Animal [] { bird, snake };
            foreach (var animal in animals) 

            {  
                Console.WriteLine($"animal: {animal.Name}");
                
                Console.WriteLine($"Alive:{animal.IsAlive}");
                
                Console.WriteLine($"Breath:{ animal.BreathOxygen}");
                
                Console.WriteLine($"Can Move:{animal.CanMove}");
                
                Console.WriteLine($"Age :{animal.Age} Years old"); 
                
                Console.WriteLine($" IsColdBlooded:{animal.IsColdBlooded}");
                
                Console.WriteLine("---------------------");
            }

        }
    }

}  

    
    