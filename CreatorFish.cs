﻿using System;

namespace Aquarium
{
    internal class CreatorFish
    {
        public Fish CreateFish() 
        {
            string nameFish;

            int minValue = 10;
            int maxValue = 20;

            Console.WriteLine("Введите имя новой рыбки");

            nameFish = Console.ReadLine();

            return new Fish(nameFish, UserUtils.GetRandomNumber(minValue,maxValue));
        }
    }
}