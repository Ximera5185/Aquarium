using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class Aquarium
    {
        private List<Fish> _fishs = new List<Fish>();

        private CreatorFish _creatorFish = new CreatorFish();

        public string _userCommand = "";

        public void RunAquarium()
        {
            bool isProgrammWorck = true;

            while (isProgrammWorck)
            {
                ShowStatusAqvarium();

                switch (_userCommand)
                {
                    case "1":
                        AddFish(_creatorFish.CreateFish());
                        break;
                    case "2":
                        break;
                    case "3":
                        isProgrammWorck = false;
                        break;
                }

                // void отнимать жизни у рыб
            }
        }

        private void AddFish(Fish fish)
        {
            _fishs.Add(fish);
        }

        private void RemoveFish(int index) 
        {
            _fishs.RemoveAt(index);
        }
        private void ShowInfo()
        {
            foreach (Fish fish in _fishs)
            {
                fish.ShowInfo();
            }
        }

        private void ShowStatusAqvarium()
        {
            Console.Clear();

            ShowInfo();

            Console.WriteLine($"В аквариуме {_fishs.Count} рыб\n" +
            $"Чтобы добавить рыбку нажмите 1\n" + 
            $"Чтобы достать рыбку введите 2\n" +
            $"Выход из программы 3");

            _userCommand = Console.ReadLine();
        }
    }
}
