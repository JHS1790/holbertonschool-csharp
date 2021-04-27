using System;

namespace Enemies
{
    ///<summary>Zombo wombo</summary>
    public class Zombie
    {
        ///kill me
        int health;
        ///no seriously
        string name = "(No name)";
        ///<summary>it's not worth it</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        ///<summary>I would rater die with honor</summary>
        public int GetHealth()
        {
            return this.health;
        }

        ///<summary>than with a docstring on my lips</summary>
        public override string ToString()
        {
            return $"Zombie Name: {this.name} / Total Health: {this.health}";
        }

        ///<summary>death to the docstrings</summary>
        public Zombie()
        {
            this.health = 0;
        }
        ///<summary>long live spaghetti code!</summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            this.health = value;
        }
    }
}
