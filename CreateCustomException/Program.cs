using System;

namespace CreateCustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Temperature aTemperature = new Temperature();
                aTemperature.AddTemperater = 0;

                aTemperature.ShowTemperature();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}