using System;

namespace Enemies
{
    /// <summary>
    /// Represents a zombie enemy
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Health of the zombie
        /// </summary>
        public int health;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class
        /// Sets health to 0
        /// </summary>
        public Zombie()
        {
            health = 0;
        }
    }
}