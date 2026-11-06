namespace Aquarium
{
    internal class Fish
    {
        private int _maxAge;

        internal Fish (string name, int maxAge)
        {
            Name = name;
            _maxAge = maxAge;
            CurrentAge = 1;
        }

        public string Name { get; private set; }
        public int CurrentAge {  get; private set; }

        internal bool GrowOld()
        {
            CurrentAge++;

            if (CurrentAge == _maxAge)
            {
                return true;
            }

            return false;
        }
    }
}
