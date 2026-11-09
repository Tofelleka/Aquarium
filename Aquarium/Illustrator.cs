using System;
using System.Collections.Generic;

namespace Aquarium
{
    internal class Illustrator
    {
        private static Illustrator _instance;

        private Illustrator() { }

        public static Illustrator Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Illustrator();
                }

                return _instance;
            }
        }

        internal void ShowMainScreen(List<string> fishLines, int capacity)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================================================");
            Console.WriteLine("                             АКВАРИУМ                                 ");
            Console.WriteLine("======================================================================");
            Console.ResetColor();

            Console.WriteLine($"\n  ДЕЙСТВИЯ:                             РЫБЫ В АКВАРИУМЕ (макс. {capacity}):");
            Console.WriteLine("  ---------------------------------     ------------------------------");

            string[] menuLines = {
                "  1 - Пропустить год",
                "  2 - Купить рыбу",
                "  3 - Выход",
                "",
                "  Введите команду:"
            };

            int maxLines = Math.Max(menuLines.Length, fishLines.Count);

            for (int i = 0; i < maxLines; i++)
            {
                string left = i < menuLines.Length ? menuLines[i] : "";
                string right = i < fishLines.Count ? fishLines[i] : "";

                Console.WriteLine($"{left,-40} | {right}");
            }

            Console.WriteLine("======================================================================");
        }

        internal void ShowStoreMenu(IReadOnlyDictionary<FishType, (string name, int currentAge, string description)> fishes)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("======================================================================");
            Console.WriteLine("                          МАГАЗИН РЫБ                                 ");
            Console.WriteLine("======================================================================");
            Console.ResetColor();

            int index = 1;
            foreach (var pair in fishes)
            {
                Console.WriteLine($"  {index} - {pair.Value.name,-10} | Живет {pair.Value.currentAge} лет. {pair.Value.description}");
                index++;
            }
            Console.WriteLine("  0 - Выход");
        }

        internal void ShowErrorInputText()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n  Неверный ввод!");
            Console.ResetColor();
            Console.ReadKey();
        }

        internal void ShowErrorQuantityFish()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n  В аквариуме нет места для новых рыбов!");
            Console.ResetColor();
            Console.ReadKey();
        }

        internal void ShowAddFishMessage(string fishName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n  Новый рыб добавлен в аквариум!");
            Console.ResetColor();
            Console.ReadKey();
        }

        internal void ShowFishDiedMessage(string fishName, int age)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"\n  [ПЕЧАЛЬ] Рыб {fishName} умерла от старости (в возрасте {age} лет)...");
            Console.ResetColor();
            Console.ReadKey();
        }

        internal void ShowWaitYearMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n  Прошел год. Рыбы повзрослели.");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}