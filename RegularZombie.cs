// RegularZombie.cs

namespace PlantsZombiesGame
{
    public class RegularZombie : Zombie
    {
        public RegularZombie()
        {
            Type = "RegularZombie";
            Health = 50; // Set the initial health for RegularZombie
        }

        public override void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                Defeat();
            }
        }

        public override void Defeat()
        {
            Console.WriteLine($"{Type} has been defeated!");
        }
    }
}
