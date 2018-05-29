using System;

namespace OOPv2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog wooffie = new Dog(15, 120, 900, 0);
            wooffie.Run();
            Dog spot = new Dog();
            spot.RunningSpeed = 25;
            spot.Run();
        }
    }
}
