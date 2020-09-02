using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        public Dictionary<int, Contestant> contestants;
        public string name;
        public string Name;
        public int registrationNumber = 0;
        public int winningNumber;

        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestant.firstName = UserInterface.GetUserInput("Please enter your first name: ");
            contestant.lastName = UserInterface.GetUserInput("Please enter your first name: ");
            contestant.emailAddress = UserInterface.GetUserInput("Please enter your E-mail address: ");
            contestant.registrationNumber = +1;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.firstName + contestant.lastName);
            Console.WriteLine(contestant.emailAddress);
            Console.WriteLine(contestant.registrationNumber);
        }
        public void PickWinner()
        {
            //Contestant;
            Random random = new Random();
            winningNumber = random.Next(1, contestants.Count);
            Console.WriteLine(winningNumber);
        }

    }
}
