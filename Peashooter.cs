// Peashooter.cs
//this class is not needed according to assignment sheet

using System;

namespace PlantsZombiesGame
{
    // Peashooter class
    public class Peashooter
    {
        public void Attack(Zombie zombie)
        {
            int damage = 25; // Assuming Peashooter damage is 25
            zombie.TakeDamage(damage);
            Console.WriteLine($"Peashooter attacks! {damage} damage dealt.");
        }
    }
}
