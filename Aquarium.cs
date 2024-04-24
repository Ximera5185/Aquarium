using System;
using System.Collections.Generic;

namespace Aquarium
{
    internal class Aquarium
    {
        private List<Fish> _fishs = new List<Fish>();

        public void Run()
        {
            const string CommandAddFish = "1";
            const string CommandRemoveFish = "2";
            const string CommandNextMove = "3";
            const string CommandExit = "4";

            string userCommand;

            bool isProgrammWorck = true;

            while (isProgrammWorck)
            {
                Console.Clear();

                ShowInfo();

                Console.WriteLine($"В аквариуме {_fishs.Count} рыб\n" +
                $"\n" +
                $"Чтобы добавить рыбку нажмите {CommandAddFish}\n" +
                $"Чтобы достать рыбку введите {CommandRemoveFish}\n" +
                $"Сделать следующий ход {CommandNextMove}\n" +
                $"Выход из программы {CommandExit}");

                userCommand = Console.ReadLine();

                switch (userCommand)
                {
                    case CommandAddFish:
                        AddFish();
                        break;

                    case CommandRemoveFish:
                        PullOutFish();
                        break;

                    case CommandNextMove:
                        AgeFish();
                        break;

                    case CommandExit:
                        isProgrammWorck = false;
                        break;
                }

            }
        }

        private void AgeFish()
        {
            for (int i = 0; i < _fishs.Count; i++)
            {
                _fishs [i].SpendLife();

                if (_fishs [i].Heath == 0)
                {
                    _fishs.Remove(_fishs [i]);
                }
            }
        }

        private void PullOutFish()
        {
            if (_fishs.Count > 0)
            {
                int index = GetUserNumber();

                if (index <= _fishs.Count && index != 0)
                {
                    _fishs.RemoveAt(index - 1);
                }
                else
                {
                    Console.WriteLine("Нет такого порядкового номера, нажмите любую клавишу для продолжения");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("В аквариуме нет рыбок, нажмите любую клавишу для продолжения");
                Console.ReadKey();
            }
        }

        private int GetUserNumber()
        {
            int number = 0;

            bool isNumber = false;

            while (isNumber == false)
            {
                Console.WriteLine("Введите порядковый номер рыбки : ");

                string input = Console.ReadLine();

                isNumber = int.TryParse(input, out number);

                if (isNumber == false)
                {
                    Console.WriteLine("Вы ввели не целое число.");
                }
                else
                {
                    isNumber = true;
                }
            }

            return number;
        }

        private void AddFish()
        {
            CreatorFish _creatorFish = new CreatorFish();

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
    }
}