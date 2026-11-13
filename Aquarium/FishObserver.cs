using System.Collections.Generic;

namespace Aquarium
{
    internal class FishObserver
    {
        private const int CommandWait = 1;
        private const int CommandBuy = 2;
        private const int CommandExit = 3;

        private FishStore _fishStore;
        private Aquarium _aquarium;

        internal FishObserver(Aquarium aquarium, FishStore fishStore)
        {
            _fishStore = fishStore;
            _aquarium = aquarium;
        }

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

                List<string> menuLines = new List<string>
                {
            $"  {CommandWait} - Пропустить год",
            $"  {CommandBuy} - Купить рыбу",
            $"  {CommandExit} - Выход",
            "",
            "  Введите команду:"
                };

                Illustrator.ShowMainScreen(fishLines, Aquarium.Capacity, menuLines);

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
                        Illustrator.ShowErrorInputText();
                        break;
                }
            }
        }

        private void WaitYear()
        {
            _aquarium.UpdateLifecycle();

            Illustrator.ShowWaitYearMessage();
        }

        private void BuyFish()
        {
            Illustrator.ShowStoreMenu(FishCatalog.GetTemplates(), 0);

            int userInput = Utils.ReadNumber() - 1;

            if (userInput < 0) return;


            Fish fish = _fishStore.SelectFishToBuy(userInput);

            if (fish != null)
            {
                if (_aquarium.AddFish(fish))
                {
                    Illustrator.ShowAddFishMessage(fish.Name);
                }
                else
                {
                    Illustrator.ShowErrorQuantityFish();
                }
            }
            else
            {
                Illustrator.ShowErrorInputText();
            }
        }
    }
}