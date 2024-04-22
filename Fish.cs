using System;

namespace Aquarium
{
    internal class Fish
    {
        public Fish(string name, int health) 
        {
            Name = name;

            Heath = health;
        }

        public string Name { get; private set;}
        public int Heath { get; private set;}

        public void TakeDamage() 
        {
            Heath--;
        }
        public void ShowInfo() 
        {
            Console.WriteLine($"Рыба {Name} Колличество жизней {Heath}");
        }
    }
}