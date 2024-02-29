
namespace PlantsZombiesGame
{
    public interface ZombieFactory
    {
        RegularZombie CreateRegularZombie();
        ConeZombie CreateConeZombie();
        BucketZombie CreateBucketZombie();
        ScreenDoorZombie CreateScreenDoorZombie();
    }
}