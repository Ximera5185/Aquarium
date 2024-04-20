using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
