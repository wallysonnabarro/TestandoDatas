using System;

namespace TestesData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data");

            DateTime dateForButton = DateTime.Now;
            dateForButton = dateForButton.AddDays(-30);

            Console.WriteLine($"{dateForButton}");

            Console.WriteLine(DateTime.Now.AddSeconds(1));
        }
    }
}
