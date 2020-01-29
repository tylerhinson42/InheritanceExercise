using System;

namespace Inheritance
{
    class Program
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

            var Cardinal = new Birds();
            Cardinal.CantFly = false;
            Cardinal.Migratory = false;
            Cardinal.IsEdible = true;
            Cardinal.Passerene = true;

            Console.WriteLine(Cardinal.Legs);

            string chordata = null;
            Cardinal.Phylum = chordata; 

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var Copperhead = new Reptiles();
            
            Copperhead.LaysEggs = true;

            Animal Rattlesnake = new Reptiles();
            Rattlesnake.IsPoisonous = true;

            Console.WriteLine(Copperhead.Legs);

            Console.WriteLine($"A bird has {Cardinal.Legs} legs." + $"And it is {Copperhead.IsPoisonous} that is poisonous");
        }
    }
}
