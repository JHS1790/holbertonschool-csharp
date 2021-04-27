using System;

namespace Enemies
{
    ///<summary>Zombo wombo</summary>
    public class Zombie
    {
        ///<summary>Zombo mombo</summary>
        public int health;

        ///<summary>Zombo combo A</summary>
        public Zombie()
        {
            this.health = 0;
        }
        
        ///<summary>Zombo combo B</summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            this.health = value;
        }
    }
}
