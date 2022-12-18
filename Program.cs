using System;

namespace Beer_And_Chips
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int numBottles = int.Parse(Console.ReadLine());
            int numChips = int.Parse(Console.ReadLine());

            double beerPrice = numBottles * 1.20;
            double chipPrice = Math.Ceiling((beerPrice * 0.45) * numChips);
            //Console.WriteLine(chipPrice);
            double totalPrice = beerPrice + chipPrice;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"{name} bought a snack and has {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {totalPrice - budget:f2} more leva!");
            }

        }
    }
}
