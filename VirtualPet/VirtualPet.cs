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

        //Constructors
        public VirtualPet(string petName, int hunger, int thirst, int tiredness)
        {
            this.petName = petName;
            this.hunger = hunger;
            this.thirst = thirst;
            this.tiredness = tiredness;
        }

        //Methods
        public void FeedPet()
        {
            hunger -= 5;
        }

        public void GiveWater()
        {
            thirst -= 5;
        }

        public void PutPetToSleep()
        {
            tiredness -= 5;
        }


    }
}
