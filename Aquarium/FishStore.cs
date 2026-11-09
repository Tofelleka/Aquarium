using System;

namespace Aquarium
{
    internal class FishStore
    {
        internal Fish SelectFishToBuy(int userInput)
        {
            if (Enum.IsDefined(typeof(FishType), userInput))
            {
                return FishCatalog.CreateFish((FishType)userInput);
            }

            return null;
        }
    }
}