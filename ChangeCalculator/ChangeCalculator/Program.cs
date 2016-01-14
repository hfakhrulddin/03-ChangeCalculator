using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ChangeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            GetTheUserInput("How much does the item cost in Dollars ?", "How much has the customer given you in Dollars?");
        }
        static void GetTheUserInput(string Message1, string Message2)
        {
            double totalRemining = 0;
            double quart_Result = 0;
            double dim_Result = 0;
            double nick_Result = 0;
            double penn_Result = 0;
            //////////////////////////////////////////////////////////////////////////////////////////
            while (true)
            {
                try
                {
                    Console.WriteLine(Message1);
                    string itemCostStr = Console.ReadLine();
                    double itemCost = double.Parse(itemCostStr);
                    Console.WriteLine(Message2);
                    string costumerPaymentStr = Console.ReadLine();
                    double costumerPayment = double.Parse(costumerPaymentStr);
                    ///////////////////////////////////////////////////////////////////////////////////
                    totalRemining = costumerPayment - itemCost;
                    if (totalRemining < 0)
                    {
                        Console.WriteLine("The item cost is more than the costumer payment!!!");
                    }
                    else
                    {
                        double totalRemininginPnns = totalRemining * 100;
                        /////////////////////////////////////////////////////////////////////////////////
                        double reminingPnnsfromQuart = totalRemininginPnns % 25;
                        quart_Result = Math.Floor(totalRemininginPnns / 25);

                        double reminingPnnsfromDims = reminingPnnsfromQuart % 10;
                        dim_Result = Math.Floor(reminingPnnsfromQuart / 10);

                        double reminingPnnsfromNick = reminingPnnsfromDims % 5;
                        nick_Result = Math.Floor(reminingPnnsfromDims / 5);
                        ///////////////////////////////////////////////////////////////////////////////////
                        penn_Result = Math.Floor(reminingPnnsfromNick);
                        totalRemining = totalRemining * 100;
                        totalRemining = Math.Floor(totalRemining);
                        totalRemining = totalRemining / 100;
                        /////////////////////////////////////////////////////////////////////////////////
                        Console.WriteLine("customer's change is: $" + totalRemining);
                        Console.WriteLine("Quarters: " + quart_Result);
                        Console.WriteLine("Dimes: " + dim_Result);
                        Console.WriteLine("Nickels: " + nick_Result);
                        Console.WriteLine("Pennies: " + penn_Result);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("You ntered a non intger value " + e.Message);
                }
            }

        }
    }
}

