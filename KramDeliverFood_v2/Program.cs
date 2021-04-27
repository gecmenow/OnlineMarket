using KramDeliverFood_v2.Logs;
using System;

namespace KramDeliverFood_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.WelcomeMessage();

            Buyer buyer = new Buyer();

            var flag = true;

            while (flag)
            {
                var choice = InputReader.UserChoice();

                switch(choice)
                {
                    case 1:
                        buyer.Order();
                        //buyer.Checkout();
                        break;
                    case 2:
                        break;
                    case 3:
                        flag = false;
                        break;
                }                
            }

            Logger.ByeMessage();

            Console.ReadKey();
        }
    }
}
