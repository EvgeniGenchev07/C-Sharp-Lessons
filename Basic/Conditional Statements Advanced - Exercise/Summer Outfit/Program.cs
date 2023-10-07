using System;

namespace Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());
            string a = Console.ReadLine();
            string outfit = "";
            string shoes = "";

            if (c >= 10 && c <= 18)
            {
                if (a == "Morning")
                {
                    shoes = "Sneakers";
                    outfit = "Sweatshirt";

                }
                else if (a == "Afternoon")
                {
                    shoes = "Moccasins";
                    outfit = "Shirt";

                }
                else if (a == "Evening")
                {
                    shoes = "Moccasins";
                    outfit = "Shirt";

                }
            }
            else if (c <= 24)
            {
                if (a == "Morning")
                {
                    shoes = "Moccasins";
                    outfit = "Shirt";

                }
                else if (a == "Afternoon")
                {
                    shoes = "Sandals";
                    outfit = "T-Shirt";

                }
                else if (a == "Evening")
                {
                    shoes = "Moccasins";
                    outfit = "Shirt";

                }
            }
            else if (c >= 25)
            {
                if (a == "Morning")
                {
                    shoes = "Sandals";
                    outfit = "T-shirt";

                }
                else if (a == "Afternoon")
                {
                    shoes = "Barefoot";
                    outfit = "Swim Suit";

                }
                else if (a == "Evening")
                {
                    shoes = "Moccasins";
                    outfit = "Shirt";

                }
            }
            Console.WriteLine($"It's {c} degrees, get your {outfit} and {shoes}.");
        }
    }
}
