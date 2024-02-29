// ZombieFactory.cs (interface)


// ConcreteZombieFactory.cs

namespace PlantsZombiesGame
{
    public class ConcreteZombieFactory : ZombieFactory
    {
        public RegularZombie CreateRegularZombie()
        {
            return new RegularZombie();
        }

        public ConeZombie CreateConeZombie()
        {
            return new ConeZombie();
        }

        public BucketZombie CreateBucketZombie()
        {
            return new BucketZombie();
        }

        public ScreenDoorZombie CreateScreenDoorZombie()
        {
            return new ScreenDoorZombie();
        }
    }
}
