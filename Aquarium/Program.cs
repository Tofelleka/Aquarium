namespace Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FishObserver fishObserver = new FishObserver(new Aquarium(), new FishStore());

            fishObserver.Run();
        }
    }
}
