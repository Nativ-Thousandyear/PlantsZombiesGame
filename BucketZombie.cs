// BucketZombie.cs

namespace PlantsZombiesGame
{
    public class BucketZombie : Zombie
    {
        public BucketZombie()
        {
            Type = "BucketZombie";
            Health = 100; // Set the initial health for BucketZombie
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
