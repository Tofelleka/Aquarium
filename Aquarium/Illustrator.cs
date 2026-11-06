
namespace Aquarium
{
    internal class Illustrator
    {
        private static Illustrator _instance;

        private Illustrator() { }

        public static Illustrator Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Illustrator();
                }

                return _instance;
            }
        }

        internal void ShowFishInfo(Fish fish)
        {

        }
    }
}
