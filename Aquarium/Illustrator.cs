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

        internal void ShowStoreMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("======================================================================");
            Console.WriteLine("                          МАГАЗИН РЫБ                                 ");
            Console.WriteLine("======================================================================");
            Console.ResetColor();

            Console.WriteLine("  1 - Щука       | Живет 25 лет. Быстрый хищник с острыми зубами.");
            Console.WriteLine("  2 - Окунь      | Живет 17 лет. Полосатый, любит прятаться в камнях.");
            Console.WriteLine("  3 - Карп       | Живет 34 года. Медлительный, но очень выносливый.");
            Console.WriteLine("  4 - Форель     | Живет 11 лет. Быстрая, пугливая, любит холодную воду.");
            Console.WriteLine("  5 - Сом        | Живет 40 лет. Гигантский усатый донный житель.");
            Console.WriteLine("  6 - Ботинок    | Живет 60 лет. Никто не знает, откуда он тут взялся.");
            Console.WriteLine("======================================================================");
            Console.Write("  Выберите рыбу (1-6) или 0 для выхода: ");
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