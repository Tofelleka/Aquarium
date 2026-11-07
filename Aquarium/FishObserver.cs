using System.Collections.Generic;

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
                List<string> fishLines = new List<string>();

                foreach (Fish fish in _aquarium.GetFish())
                {
                    fishLines.Add($"{fish.Name,-12} | Возраст: {fish.CurrentAge}");
                }

                Illustrator.Instance.ShowMainScreen(fishLines);

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

            Illustrator.Instance.ShowWaitYearMessage();
        }

        private void BuyFish()
        {
            Illustrator.Instance.ShowStoreMenu();

            int userInput = Utils.ReadNumber() - 1;

            if (userInput < 0) return;


            Fish fish = _fishStore.SelectFishToBuy(userInput);

            if (fish != null)
            {
                if (_aquarium.AddFish(fish))
                {
                    Illustrator.Instance.ShowAddFishMessage(fish.Name);
                }
                else
                {
                    Illustrator.Instance.ShowErrorQuantityFish();
                }
            }
            else
            {
                Illustrator.Instance.ShowErrorInputText();
            }
        }
    }
}