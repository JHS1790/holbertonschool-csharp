using System;

namespace Enemies
{
    public class Zombie
    {
        int health;
        string name = "(No name)";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int GetHealth()
        {
            return this.health;
        }

        public override string ToString()
        {
            return $"Zombie Name: {this.name} / Total Health: {this.health}";
        }

        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            this.health = value;
        }
    }
}
