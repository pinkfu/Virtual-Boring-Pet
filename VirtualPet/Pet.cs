using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
     class Pet
    {
        string name;
        int health;
        const int MAX_HEALTH = 5;
        int hunger;
        int food;

     public Pet()
        {
            name = " ";
            health = 10;
            hunger = 10;
            food = 10;
    
        }
        public void setName(string petName)
        {
            petName = name;

        }
        public string getName()
        {
            return name;
        }
        public int getHealth()
        {
            return health;
        }
        public int getHunger()
        {
            return hunger;
        }
        public int getFood()
        {
            return food;
        }
    }
    
}
