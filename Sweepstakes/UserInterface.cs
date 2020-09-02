using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class UserInterface
    {

        public static string GetUserInput(string output)
        {
            Console.WriteLine(output);
            string result = Console.ReadLine();
            return result;
        }
        public static void DisplayContestant(string firstName, string lastName, string email, int registrationNumber)
        {
            Console.WriteLine($"Contestant number {registrationNumber} Information: \n" + $" {lastName} , {firstName} \n" + $" {email}");

        }
        //public static void DisplayWinner()
        //{
        //    if (Sweepstakes.winningNumber == re)
        //}
        //public static void PickManager()
        //{
        //    UserInterface.GetUserInput("Which manager would you like to use? : \n" + " ( 1 ) Stack \n" + " ( 2 ) Queue \n");
        //    ConsoleKeyInfo thing = Console.ReadKey();
        //    if (thing.Key == ConsoleKey.D1)
        //    {
        //        _manager = new SweepstakesStackManager();
        //        Console.WriteLine("Stack was selected.");
        //    }
        //    if (thing.Key == ConsoleKey.D2)
        //    {
        //        _manager = new SweepstakesQueueManager();
        //        Console.WriteLine("Queue was selected.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please pick ( 1 ) for the manager stack option or ( 2 ) for the manager queue option");
        //    }
        //}
    }
}
