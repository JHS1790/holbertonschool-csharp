﻿using System;

namespace Enemies
{
    ///<summary>Zombo wombo</summary>
    public class Zombie
    {
        int health;

        public int GetHealth()
        {
            return this.health;
        }
        public Zombie()
        {
            this.health = 0;
        }
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            this.health = value;
        }
    }
}
