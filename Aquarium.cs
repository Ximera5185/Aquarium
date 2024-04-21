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

        private string _userCommand = "";

        public void RunAquarium()
        {
            bool isProgrammWorck = true;

            while (isProgrammWorck)
            {
                ShowStatusAqvarium();

                switch (_userCommand)
                {
                    case "1":
                        AddFish();
                        break;
                    case "2":
                        GetFish();
                        break;
                    case "3":
                        isProgrammWorck = false;
                        break;

                }

                TakeLife();
            }
        }

        private void TakeLife()
        {
            for (int i = 0; i < _fishs.Count; i++)
            {
                _fishs [i].TakeDamage();

                if (_fishs [i].Heath == 0)
                {
                    _fishs.Remove(_fishs [i]);
                }
            }
        }

        private void GetFish()
        {
            Console.WriteLine("Введите порядковый номер рыбки");

            int index = Convert.ToInt32(Console.ReadLine());

            _fishs.RemoveAt(index - 1);
        }

        private void AddFish()
        {
            _fishs.Add(_creatorFish.CreateFish());
        }

        private void ShowInfo()
        {
            for (int i = 0; i < _fishs.Count; i++)
            {
                Console.Write($"{i + 1} ");

                _fishs [i].ShowInfo();
            }
        }

        private void ShowStatusAqvarium()
        {
            Console.Clear();

            ShowInfo();

            Console.WriteLine($"В аквариуме {_fishs.Count} рыб\n" +
            $"\n" +
            $"Чтобы добавить рыбку нажмите 1\n" +
            $"Чтобы достать рыбку введите 2\n" +
            $"Выход из программы 3");

            _userCommand = Console.ReadLine();
        }
    }
}