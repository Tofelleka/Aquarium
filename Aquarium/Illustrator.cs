using System;
using System.Collections.Generic;

namespace Aquarium
{
    internal static class Illustrator
    {
        internal static void ShowMainScreen(List<string> fishLines, int capacity, List<string> menuLines)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================================================");
            Console.WriteLine("                             АКВАРИУМ                                 ");
            Console.WriteLine("======================================================================");
            Console.ResetColor();

            Console.WriteLine($"\n  ДЕЙСТВИЯ:                             РЫБЫ В АКВАРИУМЕ (макс. {capacity}):");
            Console.WriteLine("  ---------------------------------     ------------------------------");

            int maxLines = Math.Max(menuLines.Count, fishLines.Count);

            for (int i = 0; i < maxLines; i++)
            {
                string left = i < menuLines.Count ? menuLines[i] : "";
                string right = i < fishLines.Count ? fishLines[i] : "";

                Console.WriteLine($"{left,-40} | {right}");
            }

            Console.WriteLine("======================================================================");
        }

        internal static void ShowStoreMenu(IReadOnlyDictionary<FishType, (string name, int maxAge, string description)> fishes, int exitCommand)
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
                Console.WriteLine($"  {index} - {pair.Value.name,-10} | Живет {pair.Value.maxAge} лет. {pair.Value.description}");
                index++;
            }
            Console.WriteLine($" {exitCommand} - Выход");
        }

        internal static void ShowErrorInputText()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n  Неверный ввод!");
            Console.ResetColor();
            Console.ReadKey();
        }

        internal static void ShowErrorQuantityFish()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n  В аквариуме нет места для новых рыбов!");
            Console.ResetColor();
            Console.ReadKey();
        }

        internal static void ShowAddFishMessage(string fishName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n  Новый рыб добавлен в аквариум!");
            Console.ResetColor();
            Console.ReadKey();
        }

        internal static void ShowFishDiedMessage(string fishName, int age)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"\n  [ПЕЧАЛЬ] Рыб {fishName} умерла от старости (в возрасте {age} лет)...");
            Console.ResetColor();
            Console.ReadKey();
        }

        internal static void ShowWaitYearMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n  Прошел год. Рыбы повзрослели.");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}