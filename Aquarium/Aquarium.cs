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

        internal bool AddFish(Fish fish)
        {
            if (_fishInAquarium.Count < Capacity)
            {
                _fishInAquarium.Add(fish);

                return true;
            }
            else
            {
                return false;
            }
        }

        internal void UpdateLifecycle()
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
