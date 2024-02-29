// ScreenDoorZombie.cs
using System;

namespace PlantsZombiesGame
{
    // Concrete class for Screen Door Zombie
    public class ScreenDoorZombie : Zombie
    {
        private string accessory = "ScreenDoor";
        private int accessoryHealth = 30; // Adjust the accessory health as needed

        public ScreenDoorZombie()
        {
            Type = "ScreenDoorZombie";
            Health = 75;
        }

        public override void TakeDamage(int damage)
        {
            // Check if the accessory is still intact
            if (accessoryHealth > 0)
            {
                Console.WriteLine($"{Type}'s {accessory} absorbs {damage} damage.");
                accessoryHealth -= damage;

                // Check if the accessory has been destroyed
                if (accessoryHealth <= 0)
                {
                    Console.WriteLine($"{Type}'s {accessory} has been destroyed!");
                }
            }
            else
            {
                // After the accessory health is depleted, apply damage to the zombie
                Health -= damage;
                if (Health <= 0)
                {
                    Defeat();
                }
            }
        }

        public override void Defeat()
        {
            Console.WriteLine($"{Type} has been defeated!");
        }
    }
}
