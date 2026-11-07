
using System;

namespace Aquarium
{
    internal class FishObserver
    {
        private const int CommandWait = 1;
        private const int CommandBuy = 2;
        private const int CommandExit = 3;

        private FishStore _fishStore = new FishStore();
        private Aquarium _aquarium = new Aquarium();

        internal void Run()
        {
            bool isWork = true;

            while (isWork)
            {
                _aquarium.ShowAllFish();

                switch (Utils.ReadNumber())
                {
                    case CommandWait:
                        WaitYear();
                        break;

                    case CommandBuy:
                        BuyFish();
                        break;

                    case CommandExit:
                        isWork = false;
                        break;

                    default:
                        Illustrator.Instance.ShowErrorInputText();
                        break;
                }
            }
        }

        private void WaitYear()
        {
            _aquarium.UpdateLifecycle();
        }

        private void BuyFish()
        {
            Fish fish = _fishStore.SelectFishToBuy();

            if (fish != null)
            {
                if (_aquarium.AddFish(fish))
                {
                    Illustrator.Instance.ShowAddFishMessage();
                }
                else
                {
                    Illustrator.Instance.ShowErrorQuantityFish();
                }
            }
        }
    }
}
