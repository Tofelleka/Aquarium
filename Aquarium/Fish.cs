namespace Aquarium
{
    internal class Fish
    {
        internal Fish (string name, int maxAge)
        {
            Name = name;
            MaxAge = maxAge;
            CurrentAge = 1;
        }

        public string Name { get; private set; }
        public int CurrentAge {  get; private set; }
        public int MaxAge { get; private set; }

        internal bool GrowOld()
        {
            CurrentAge++;

            if (CurrentAge >= MaxAge)
            {
                return true;
            }

            return false;
        }
    }
}
