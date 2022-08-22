using System;

namespace Clock
{
    public class Program
    {
        static void Main(string[] args)
        {
            Clock myClock = new Clock();


            for (int i = 0; i < 9050; i++) //2hours30minutes50seconds
            {
                myClock.Tick();
            }


            Console.WriteLine(myClock.Time);


            myClock.Reset(); //back to 00:00:00
            Console.WriteLine(myClock.Time);


            myClock.Tick(); // ticks once to 00:00:01
            Console.WriteLine(myClock.Time);

        }
    }
}
