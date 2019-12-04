using System;

namespace Trening
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter logisitics name");
                var userText = Console.ReadLine().ToLower();
                if (userText == "q" || userText == "quit")
                    break;
                    
                LogisticsManager.PlanDelivery(userText);
            }
        }
    }
}
