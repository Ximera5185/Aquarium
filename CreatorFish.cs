using System;

namespace Aquarium
{
    internal class CreatorFish
    {
        public Fish CreateFish() 
        {
            string nameFish = "";

            Console.WriteLine("Введите имя новой рыбки");

            nameFish = Console.ReadLine();

            return new Fish(nameFish, UserUtils.GetRandomNumber());
        }
    }
}