using System.Collections.Generic;

namespace Aquarium
{
    internal class Aquarium
    {
        internal const int Capacity = 8;

        private List<Fish> _fishInAquarium = new List<Fish>();

        internal void ShowAllFish()
        {
            foreach(Fish fish in _fishInAquarium)
            {
                Illustrator.Instance.ShowFishInfo(fish);
            }
        }

        internal void AddFish(Fish fish)
        {
            _fishInAquarium.Add(fish);
        }

        internal void UbdateLifecycle()
        {
            for (int i = _fishInAquarium.Count - 1; i >= 0; i--)
            {
                if (_fishInAquarium[i].GrowOld())
                {
                    _fishInAquarium.RemoveAt(i);
                }
            }
        }
    }
}
