
using System;

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

        internal void ShowFishInfo(Fish fish)
        {

        }

        internal void ShowErrorInputText()
        {
            Console.WriteLine("\nНеверный ввод!\n");
        }

        internal void ShowErrorQuantityFish()
        {
            Console.WriteLine("В аквариуме нет места для новых рыбов!");
        }

        internal void ShowAddFishMessage()
        {
            Console.WriteLine("Новый рыб добавлен в аквариум!");
        }
    }
}
