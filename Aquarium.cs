using System;
using System.Collections.Generic;

namespace Aquarium
{
    internal class Aquarium
    {
        private const string CommandAddFish = "1";
        private const string CommandRemoveFish = "2";
        private const string CommandExit = "3";

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
                    case CommandAddFish:
                        AddFish();
                        break;

                    case CommandRemoveFish:
                        GetFish();
                        break;

                    case CommandExit:
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
            int index = GetUserNumber();

            _fishs.RemoveAt(index - 1);
        }

        private int GetUserNumber()
        {
            int number = 0;

            bool isNumber = false;


            while (isNumber == false)
            {
                Console.WriteLine("Вы ввели не целое число.");

                Console.WriteLine("Введите порядковый номер рыбки : ");

                string input = Console.ReadLine();

                isNumber = int.TryParse(input, out number);
            }

            return number;
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
            $"Чтобы добавить рыбку нажмите {CommandAddFish}\n" +
            $"Чтобы достать рыбку введите {CommandRemoveFish}\n" +
            $"Выход из программы {CommandExit}");

            _userCommand = Console.ReadLine();
        }
    }
}