using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Virtual Pet:");
            Console.WriteLine("This is your new Dog. Please give it a name?");
            string petName = Console.ReadLine();

            VirtualPet dog = new VirtualPet(petName, 20, 12, 8);

            Console.WriteLine("Dog Name: " + petName);
            Console.WriteLine("Hunger: " + dog.Hunger);
            Console.WriteLine("Thirst: " + dog.Thirst);
            Console.WriteLine("Tiredness: " + dog.Tiredness);
            Console.WriteLine();

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - Feed the dog");
            Console.WriteLine("2 - Give water to the dog");
            Console.WriteLine("3 - Put dog to sleep");
            Console.WriteLine("4 - Nothing");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    dog.FeedPet();
                    Console.WriteLine("You feed " + petName);
                    break;
                case 2:
                    dog.GiveWater();
                    Console.WriteLine("You gave water to " + petName);
                    break;
                case 3:
                    dog.PutPetToSleep();
                    Console.WriteLine("You put " + petName + " to sleep");
                    break;
                default:
                    Console.WriteLine("You didn't do anything ");
                    break;
            }

        }
    }
}
