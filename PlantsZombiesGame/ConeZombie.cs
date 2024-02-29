// ConeZombie.cs

namespace PlantsZombiesGame
{
    public class ConeZombie : Zombie
    {
        public ConeZombie()
        {
            Type = "ConeZombie";
            Health = 75; // Set the initial health for ConeZombie
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
