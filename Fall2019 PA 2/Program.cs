using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2019_PA_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //PA2 Starter Code
            //test
            //1 - Currency Exchange
            //2 - Restaraunt POS
            //3 - Exit

            createMenu();

            Console.ReadKey();
        }

        static void createMenu() 
        {
            string menuChoice = getMenuChoice();

            if(menuChoice =="3")
            {
                Console.WriteLine("Goodbye");
            }

            while (menuChoice != "3")
            {
                if (menuChoice == "1")
                {
                    Console.Write("Starting Currency Exchange: ");
                    currencyExchange();
                }
                else
                {
                    Console.Write("Starting Restaraunt Point of Sale: ");
                    foodAmount();
                }

                menuChoice = getMenuChoice();

                if (menuChoice == "3")
                {
                    Console.WriteLine("Goodbye");
                }
            }
        }

        static string getMenuChoice()
        {
            Console.Write("Please enter 1 for Currency Exchange, 2 for Menu Point of Sale, or 3 to Exit: ");
            string choice = Console.ReadLine();

            while(!(choice =="1" || choice =="2" || choice == "3"))
            {
                Console.WriteLine("Please enter a valid choice.");
                choice = Console.ReadLine();
            }
            return choice;
        }

        static void currencyExchange()
        {
            string supportedCurrency;
            supportedCurrency = new string {"C", "E", "I", "J", "M", "B"};

            double exchangeRates;
            exchangeRates = new double {0.9813,0.757,52.53,80.92,13.1544,0.6178};

            string fromCurrency,toCurrency;

            Console.WriteLine("Enter current currency: ");
            fromCurrency = Console.ReadLine();
            Console.WriteLine("Enter desired currency: ");
            toCurrency = Console.ReadLine();

            int f=0,exchangeRate = 0;

            for (int i=0; i < exchangeRates; i++);
            {
                if (supportedCurrency == fromCurrency)
                {
                    f = f+1;
                }
                if (supportedCurrency == toCurrency)
                {
                    f = f+1;
                    exchangeRate = i;
                }
            }

        }
    }
}
