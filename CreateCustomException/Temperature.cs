using System;

namespace CreateCustomException
{
    class Temperature
    {
        public int AddTemperater { get; set; }

        public void ShowTemperature()
        {
            if (AddTemperater == 0)
            {
                throw new TempIsZeroException("Zero Temperature is found");
            }
            Console.WriteLine("Temperature: {0}", AddTemperater);
        }
    }
}