using System;

namespace Aquarium
{
    internal class FishStore
    {
        internal Fish SelectFishToBuy()
        {
            int userInput = Utils.ReadNumber() - 1;

            if (Enum.IsDefined(typeof(FishType), userInput))
            {
                FishType type = (FishType)userInput;

                switch (type)
                {
                    case FishType.Pike:
                        return CreatePike();

                    case FishType.Perch:
                        return CreatePerch();

                    case FishType.Carp:
                        return CreateCarp();

                    case FishType.Trout:
                        return CreateTrout();

                    case FishType.Catfish:
                        return CreateCatFish();

                    case FishType.Boot:
                        return CreateBoot();
                }
            }
            else
            {
                Illustrator.Instance.ShowErrorInputText();
            }

            return null;
        }

        private Fish CreatePike()
        {
            return new Fish("Щука", 25);
        }

        private Fish CreatePerch()
        {
            return new Fish("Окунь", 17);
        }

        private Fish CreateCarp()
        {
            return new Fish("Карп", 34);
        }

        private Fish CreateTrout()
        {
            return new Fish("Форель", 11);
        }

        private Fish CreateCatFish()
        {
            return new Fish("Сом", 40);
        }

        private Fish CreateBoot()
        {
            return new Fish("Ботинок", 60);
        }
    }
}
