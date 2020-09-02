using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        ISweepstakesManager _manager;
        public MarketingFirm(ISweepstakesManager manager)
        {
            this._manager = manager;
        }
        public void PickManager()
        {
            UserInterface.GetUserInput("Which manager would you like to use? : \n" + " ( 1 ) Stack \n" + " ( 2 ) Queue \n");
            ConsoleKeyInfo thing = Console.ReadKey();
            if (thing.Key == ConsoleKey.D1)
            {
                _manager = new SweepstakesStackManager();
                Console.WriteLine("Stack was selected.");
            }
            if (thing.Key == ConsoleKey.D2)
            {
                _manager = new SweepstakesQueueManager();
                Console.WriteLine("Queue was selected.");
            }
            else
            {
                Console.WriteLine("Please pick ( 1 ) for the manager stack option or ( 2 ) for the manager queue option");
            }
        }
        public void CreateSweepstakes()
        {
            _manager.InsertSweepstakes(new Sweepstakes(UserInterface.GetUserInput("What would you like the name of this Sweepstakes to be? ")));
        }
    }
}
