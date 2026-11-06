using System;

namespace Aquarium
{
    internal class Utils
    {
        public static int ReadNumber()
        {
            bool isWork = true;

            int numberForReturn = 0;

            while (isWork)
            {
                if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
                {
                    isWork = false;
                    numberForReturn = number;
                }
                else
                {
                    Console.WriteLine("\n\nНеверный ввод, это должно быть положительное число.");
                }
            }

            return numberForReturn;
        }
    }
}
