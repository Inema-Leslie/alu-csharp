using System;

namespace Enemies
{
    /// <summary>
    /// Represents a zombie enemy
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Health of the zombie (private field)
        /// </summary>
        private int health;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// Sets health to 0
        /// </summary>
        public Zombie()
        {
            health = 0;
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// </summary>
        /// <param name="value">Health value (must be >= 0)</param>
        /// <exception cref="ArgumentException">Thrown when value is less than 0</exception>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }
        
        /// <summary>
        /// Returns the health value of the zombie
        /// </summary>
        /// <returns>The current health value</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}