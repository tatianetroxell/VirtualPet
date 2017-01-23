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
            Console.WriteLine("      __");
            Console.WriteLine(" (___()'`;");
            Console.WriteLine(" /,    /`");
            Console.WriteLine(" \\\\---\\\\");
            Console.WriteLine("This is your new dog. Please give it a name?");
            string petName = Console.ReadLine(); //Assign the value entered by the user to the variable petName

            //Create an new object of VirtualPet, and assign its values(petName, hunger, thrist, tiredness, boredom
            VirtualPet dog = new VirtualPet(petName, 20, 12, 18, 5);
            Console.WriteLine();
            Console.WriteLine("Do you want to interact with {0} (Y/N)?", petName);
            string userAnswer = Console.ReadLine();
            Console.WriteLine();

            //If the user wants to interact with the dog, the program will ask what the user wants to do
            //If not the program will quit
            do
            {
                //Let the user know the status of the dog if any of the level are more than 15
                //(ex: if the hunger level is more than 15, tell the user the dog is hungry
                dog.PetStatus();
                Console.WriteLine();
                Console.WriteLine("What do you want to do? (Please enter a number)");
                Console.WriteLine("1 - Feed {0}", petName);
                Console.WriteLine("2 - Give water to {0}", petName);
                Console.WriteLine("3 - Put {0} to sleep", petName);
                Console.WriteLine("4 - Play with {0}", petName);
                Console.WriteLine("5 - Do nothing with {0}", petName);
                int userInput = int.Parse(Console.ReadLine());

                //Call methods based on the user's answer and let them know what they did with the dog
                switch (userInput)
                {
                    case 1:
                        dog.FeedPet();
                        break;
                    case 2:
                        dog.GiveWater();
                        break;
                    case 3:
                        dog.PutPetToSleep();
                        break;
                    case 4:
                        dog.PlayWithPet();
                        break;
                    default:
                        Console.WriteLine("You didn't do anything ");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Do you still want to interact with {0} (Y/N)?", petName);
                userAnswer = Console.ReadLine();

                Console.WriteLine();

            } while (userAnswer.ToUpper() == "Y" || userAnswer.ToUpper() == "YES");

            Console.WriteLine("Thank you for playing!!!");
        }
    }
}
