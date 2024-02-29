// Zombie.cs
using System;

namespace PlantsZombiesGame
{
    // Abstract base class for Zombies
    public abstract class Zombie
    {
        public string Type { get; protected set; }
        public int Health { get; protected set; }

        public abstract void TakeDamage(int damage);
        public abstract void Defeat();
    }
}
