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
                        SkipTime();
                        break;

                    case CommandExit:
                        isProgrammWorck = false;
                        break;
                }
            }
        }

        private void ToAgeFish()
        {
            for (int i = _fishs.Count - 1; i >= 0; i--)
            {
                _fishs [i].SpendLife();
            }
        }

        private void RemoveDeadFish()
        {
            for (int i = _fishs.Count - 1; i >= 0; i--)
            {
                if (_fishs [i].Heath == 0)
                {
                    _fishs.Remove(_fishs [i]);
                }
            }
        }

        private void SkipTime()
        {
            ToAgeFish();

            RemoveDeadFish();
        }

        private void PullOutFish()
        {
            if (_fishs.Count < 0)
            {
                Console.WriteLine("В аквариуме нет рыбок, нажмите любую клавишу для продолжения");
                Console.ReadKey();

                return;
            }

            int index = GetUserNumber("Введите порядковый номер рыбки : ") - 1;

            if (index < _fishs.Count && index >= 0)
            {
                _fishs.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Нет такого порядкового номера, нажмите любую клавишу для продолжения");
                Console.ReadKey();
            }
        }

        private int GetUserNumber(string message)
        {
            int number = 0;

            string input = "";

            while (int.TryParse(input, out number) == false)
            {
                Console.WriteLine(message);

                input = Console.ReadLine();

                Console.WriteLine("Вы ввели не целое число.");
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