// Program.cs (Main Program)

using System;
using System.Collections.Generic;
using PlantsZombiesGame;

class Program
{
    static void Main(string[] args)
    {
        List<Zombie> zombies = new List<Zombie>();
        ZombieFactory zombieFactory = new ConcreteZombieFactory();

        while (true)
        {
            Console.WriteLine("1. Create zombie");
            Console.WriteLine("2. Demo game play");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateZombie(zombies, zombieFactory);
                    DisplayZombies(zombies);
                    break;

                case "2":
                    DemoGamePlay(zombies);
                    break;

                case "3":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CreateZombie(List<Zombie> zombies, ZombieFactory zombieFactory)
    {
        Console.WriteLine("Which kind?");
        Console.WriteLine("1. Regular");
        Console.WriteLine("2. Cone");
        Console.WriteLine("3. Bucket");
        Console.WriteLine("4. ScreenDoor");

        Console.Write("Enter zombie type: ");
        string zombieType = Console.ReadLine();

        Zombie zombie = null;

        switch (zombieType)
        {
            case "1":
                zombie = zombieFactory.CreateRegularZombie();
                break;

            case "2":
                zombie = zombieFactory.CreateConeZombie();
                break;

            case "3":
                zombie = zombieFactory.CreateBucketZombie();
                break;

            case "4":
                zombie = zombieFactory.CreateScreenDoorZombie();
                break;

            default:
                Console.WriteLine("Invalid zombie type.");
                break;
        }

        if (zombie != null)
        {
            zombies.Add(zombie);
            Console.WriteLine($"Zombie created: {zombie.Type} with {zombie.Health} health");
        }
    }

    static void DemoGamePlay(List<Zombie> zombies)
    {
        if (zombies.Count == 0)
        {
            Console.WriteLine("First Create a zombies.");
            return;
        }

        Console.Write("Please enter a damage value. Default is 25: ");
        int damageValue;
        if (!int.TryParse(Console.ReadLine(), out damageValue))
        {
            damageValue = 25; // Default damage value
        }

        int round = 0;

        do
        {
            Console.WriteLine($"Round {round}:");
            DisplayZombies(zombies);

            foreach (var zombie in zombies)
            {
                zombie.TakeDamage(damageValue);
                TransformZombie(zombies, zombie);
            }

            zombies.RemoveAll(zombie => zombie.Health <= 0);

            round++;
        } while (zombies.Count > 0);

        Console.WriteLine("Game Over!");
    }

    static void TransformZombie(List<Zombie> zombies, Zombie zombie)
    {
        if (zombie != null && zombie.Health <= 0)
        {
            // Transform logic here for each zombie type
            if (zombie is RegularZombie)
            {
                Console.WriteLine($"{zombie.Type} transformed to another type with dwindling health: {zombie.Health}");
                zombies.Add(new ConeZombie());
            }
            else if (zombie is ConeZombie)
            {
                Console.WriteLine($"{zombie.Type} transformed to another type with dwindling health: {zombie.Health}");
                zombies.Add(new RegularZombie());
            }
            else if (zombie is BucketZombie)
            {
                Console.WriteLine($"{zombie.Type} transformed to another type with dwindling health: {zombie.Health}");
                zombies.Add(new ConeZombie());
            }
            else if (zombie is ScreenDoorZombie)
            {
                Console.WriteLine($"{zombie.Type} transformed to another type with dwindling health: {zombie.Health}");
                zombies.Add(new RegularZombie());
            }
        }
    }

    static void DisplayZombies(List<Zombie> zombies)
    {
        Console.Write("Round: ");
        foreach (var zombie in zombies)
        {
            Console.Write($"[{zombie.Type}/{zombie.Health},] ");
        }
        Console.WriteLine();
    }
}
