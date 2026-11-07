using System;

namespace Aquarium
{
    internal class FishStore
    {
        internal Fish SelectFishToBuy(int userInput)
        {
            if (Enum.IsDefined(typeof(FishType), userInput))
            {
                FishType type = (FishType)userInput;

                switch (type)
                {
                    case FishType.Pike:
                        return new Fish("Щука", 25);

                    case FishType.Perch:
                        return new Fish("Окунь", 17);

                    case FishType.Carp:
                        return new Fish("Карп", 34);

                    case FishType.Trout:
                        return new Fish("Форель", 11);

                    case FishType.Catfish:
                        return new Fish("Сом", 40);

                    case FishType.Boot:
                        return new Fish("Ботинок", 60);
                }
            }

            return null;
        }
    }
}
