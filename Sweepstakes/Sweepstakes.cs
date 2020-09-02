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
            this.name = UserInterface.GetUserInput(" What would you like the name of this Sweepstakes to be? ");
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestants.Count, contestant);
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.DisplayContestant(contestant.lastName, contestant.firstName, contestant.emailAddress, contestant.registrationNumber);

        }
        public Contestant PickWinner()
        {
            //Contestant;
            Random random = new Random();
            int winningNumber = random.Next(1, contestants.Count);
            Console.WriteLine(winningNumber);
            Contestant contestant = contestants[winningNumber];
            //UserInterface.DisplayWinner();
            return contestant;

        }

    }
}
