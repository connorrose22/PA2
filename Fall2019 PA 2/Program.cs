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
                Console.WriteLine("Goodbye"); //Menu closes when 3 is selected
            }

            while (menuChoice != "3")
            {
                if (menuChoice == "1")
                {
                    currencyExchange(); //Currency Exchange Method when 1 is selected
                }
                else
                {
                    foodAmount(); //Restaraunt Point of Sale when 2 is selected
                }

                menuChoice = getMenuChoice();

                if (menuChoice == "3")
                {
                    Console.WriteLine("Goodbye"); //Menu closes when 3 is selected
                }
            }
        }

        static string getMenuChoice()
        {
            //Asking user to input choice
            Console.Write("Please enter 1 for Currency Exchange, 2 for Menu Point of Sale, or 3 to Exit: ");
            string choice = Console.ReadLine();

            while(!(choice =="1" || choice =="2" || choice == "3"))
            {
                //Reminding to put valid choice
                Console.WriteLine("Please enter a valid choice.");
                choice = Console.ReadLine();
            }
            return choice;
        }

        //Currency Exchange Method
       static void currencyExchange()
        {
            //[] allows the ability to attach data to separate classes
            string[] supportedCurrency;
            supportedCurrency = new string[] {"US", "C", "E", "I", "J", "M", "B" };

            double[] exchangeRates;
            exchangeRates = new double[] {1, 0.9813, 0.757, 52.53, 80.92, 13.1544, 0.6178 };

            string fromCurrency, toCurrency;

            Console.WriteLine("Enter Current Currency: ");
            fromCurrency = Console.ReadLine();
            Console.WriteLine("Enter Desired Currency: ");
            toCurrency = Console.ReadLine();

            int f = 0, exRate = 0;

            for (int i = 0; i < exchangeRates.Length; i++)
            {
                if (supportedCurrency[i] == fromCurrency)
                {
                    f = f + 1;
                }
                if (supportedCurrency[i] == toCurrency)
                {
                    f = f + 1;
                    exRate = i;
                }
            }
            if (f == 2)
            {
                if (toCurrency == "US")
                {
                    double Amount;

                    Console.WriteLine("Enter amount of Current Currency");
                    Amount = Convert.ToDouble(Console.ReadLine());
                    double exchangeAmount = Amount / exchangeRates[exRate];

                    Console.WriteLine("The Exchange Amount is " + exchangeAmount);
                }
                else
                {

                double Amount;

                Console.WriteLine("Enter amount of Current Currency");
                Amount = Convert.ToDouble(Console.ReadLine());
                double exchangeAmount = Amount * exchangeRates[exRate];


                Console.WriteLine("The Exchange Amount is " + exchangeAmount);
                }
                
            }
            else
            {
                Console.WriteLine("Currency conversion is not possible.");
            }
        }

        static void foodAmount()
        {
            Console.WriteLine("Enter Food Total: ");
            double food = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Alcohol Total: ");
            double alcohol = Convert.ToDouble(Console.ReadLine());

            double total = (food + alcohol)*1.09 + food*.18;

            Console.WriteLine("The Total Amount due is :" + total);

            Console.WriteLine("Enter the Amount to Pay.");
            double amount = Convert.ToDouble(Console.ReadLine());

            if(amount < total)
            {
                Console.WriteLine("Please pay the full Amount.");
            }
            else
            {
                Console.WriteLine("Change due = " + (amount - total));
            }
        }
    }
}