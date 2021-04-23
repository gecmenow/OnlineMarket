using System;

namespace KramDeliverFood_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome in \" Kram Delivery Food\" \n" +
                "Tell us, who you are 1 - The Buyer, 2 - The Provider of the food. \n");
            Console.Write("Make your choise: ");

            var choice = Convert.ToInt32(Console.ReadLine());

            var result = choice switch
            {
                1 => "buyer method",
                2 => "provider method",
                _ => ""
            };

            if (result == "buyer method")
            {
                var temp = Console.ReadLine();

                var buyer = new Buyer();

                buyer.Order(temp);
            }
            Console.ReadKey();
        }
    }
}
