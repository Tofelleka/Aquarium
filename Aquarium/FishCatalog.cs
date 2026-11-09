using System.Collections.Generic;

namespace Aquarium
{
    internal static class FishCatalog
    {
        private static Dictionary<FishType, (string name, int maxAge, string description)> _data = new Dictionary<FishType, (string name, int maxAge, string description)>
        {
            { FishType.Pike, ("Щука", 25, "Быстрый хищник с острыми зубами.") },
            { FishType.Perch, ("Окунь", 17, "Полосатый, любит прятаться в камнях.") },
            { FishType.Carp, ("Карп", 34, "Медлительный, но очень выносливый.") },
            { FishType.Trout, ("Форель", 11, "Быстрая, пугливая, любит холодную воду.") },
            { FishType.Catfish, ("Сом", 40, "Гигантский усатый донный житель.") },
            { FishType.Boot, ("Ботинок", 60, "Никто не знает, откуда он тут взялся.") }
        };

        public static Fish CreateFish(FishType type)
        {
            var data = _data[type];

            return new Fish(data.name, data.maxAge, data.description);
        }

        public static IReadOnlyDictionary<FishType, (string name, int maxAge, string description)> GetTemplates()
        {
            return _data;
        }
    }
}
