using System;

namespace test
{
    class Bot : IRun
    {
        public int speed { get; set; } = 60;

        public void CarRun()
        {
            Console.WriteLine("Masina albastra merge cu viteza " + speed);
        }
    }
}