using System.Collections.Generic;

namespace Aquarium
{
    internal class Aquarium
    {
        internal const int Capacity = 8;

        private List<Fish> _fishInAquarium = new List<Fish>();

        internal List<Fish> GetFish()
        {
            return new List<Fish>(_fishInAquarium);
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
                    Illustrator.Instance.ShowFishDiedMessage(_fishInAquarium[i].Name, _fishInAquarium[i].CurrentAge);

                    _fishInAquarium.RemoveAt(i);
                }
            }
        }
    }
}
