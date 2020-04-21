using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationBudgetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Console.WriteLine("Welcome to the Vacation Budget Planner");

            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine($"Welcome {userName}!");

            string tryAgain = "y";

            while (tryAgain.ToLower() == "y")
            {

                Console.WriteLine("Where would you like to travel. Choose: (1)Mexico (2)Jamaica");
                int locationChoice = Convert.ToInt16(Console.ReadLine());

                switch (locationChoice)
                {
                    case 1:
                        Console.WriteLine("Great! Mexico sounds like an amazing trip!");
                        Console.WriteLine("**********");

                        Console.WriteLine("How many days do you plan on spending in Mexico?");
                        int tripDuration = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("How much money in US dollars do you plan on spending during your trip?");
                        double money = Convert.ToDouble(Console.ReadLine());

                        double hoursCalculated = tripDuration * 24;
                        double minutesCalculated = tripDuration * 1440;


                        Console.WriteLine($"You will be in Mexico for {hoursCalculated} total hours and {minutesCalculated} in total minutes.");


                        double budgetInDollars = money / tripDuration;
                        double pesoConversion = money * 19.23;
                        double budgetInPesos = pesoConversion / tripDuration;


                        Console.WriteLine($"During your trip you will have {budgetInDollars:##} USD to spend each day.");

                        Console.WriteLine($"This equates to {budgetInPesos:##} in Pesos");

                        Console.WriteLine("Thanks for using the Vacation Budget App. Enjoy your vacation!");

                        Console.WriteLine("Would you like to try again? Enter y or n");
                        tryAgain = Console.ReadLine();



                        break;
                    case 2:
                        Console.WriteLine("Great! Jamaica sounds like an amazing trip!");
                        Console.WriteLine("**********");

                        Console.WriteLine("How many days do you plan on spending in Jamaica?");
                        int jamaicaTripDuration = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("How much money in US dollars do you plan on spending during your trip?");
                        double jamaicanMoney = Convert.ToDouble(Console.ReadLine());

                        double jamaicaHoursCalculated = jamaicaTripDuration * 24;
                        double jamaicaMinutesCalculated = jamaicaTripDuration * 1440;

                        Console.WriteLine($"You will be in Jamaica for {jamaicaMinutesCalculated} total hours and {jamaicaMinutesCalculated} in total minutes.");

                        double jamaicaBudgetInDollars = jamaicanMoney / jamaicaTripDuration;
                        double jamaicanDollarConversion = jamaicanMoney * 139.71;
                        double budgetInJamaicanDollars = jamaicanDollarConversion / jamaicaTripDuration;

                        Console.WriteLine($"During your trip you will have {jamaicaBudgetInDollars:##} USD to spend each day.");

                        Console.WriteLine($"This equates to {budgetInJamaicanDollars:##} in Jamaican Dollars");

                        Console.WriteLine("Thanks for using the Vacation Budget App. Enjoy your vacation!");

                        Console.WriteLine("Would you like to try again? Enter y or n");
                        tryAgain = Console.ReadLine();

                        break;
                    default:
                        Console.WriteLine("Please select a valid option.");

                        Console.WriteLine("Would you like to try again? Enter y or n");
                        tryAgain = Console.ReadLine();

                        break;

                } 
            }


            Console.WriteLine("Press ENTER to exit app");
            Console.ReadLine();
        }
    }
}
