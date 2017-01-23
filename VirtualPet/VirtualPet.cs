using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        private string petName;
        private int hunger;
        private int thirst;
        private int tiredness;
        private int boredom;

        //Properties
        public string PetName
        {
            get { return this.petName; }
            set { this.petName = value; }
        }

        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }

        public int Tiredness
        {
            get { return this.tiredness; }
            set { this.tiredness = value; }
        }

        public int Boredom
        {
            get { return this.boredom; }
            set { this.boredom = value; }
        }

        //Constructors
        public VirtualPet(string petName, int hunger, int thirst, int tiredness, int boredom)
        {
            this.petName = petName;
            this.hunger = hunger;
            this.thirst = thirst;
            this.tiredness = tiredness;
            this.boredom = boredom;
        }

        //Methods
        public void FeedPet()
        {
            hunger -= 5;
            thirst += 5;
            Console.WriteLine("You fed {0}.", petName);
        }

        public void GiveWater()
        {
            thirst -= 5;
            Console.WriteLine("You gave water to {0}.", petName);
        }

        public void PutPetToSleep()
        {
            tiredness -= 5;
            Console.WriteLine("You put {0} to sleep.", petName);
        }

        public void PlayWithPet()
        {
            boredom -= 5;
            tiredness += 5;
            thirst += 5;
            Console.WriteLine("You played with {0}.", petName);
        }

        //Let the user know if the dog is hungry, thirsty, tired or bored when method is called
        public void PetStatus()
        {
            if (hunger > 15)
            {
                Console.WriteLine("{0} is hungry", petName);
            }

            if (thirst > 15)
            {
                Console.WriteLine("{0} is thirsty", petName);
            }

            if (tiredness > 15)
            {
                Console.WriteLine("{0} is tired", petName);
            }

            if (boredom > 15)
            {
                Console.WriteLine("{0} is bored", petName);
            }
        }
    }
}
