using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        ISweepstakesManager _manager;
        public MarketingFirm(ISweepstakesManager manager)
        {
            this._manager = manager;
        }
        public void PickManager()
        {
            ISweepstakesManager._manager = UserInterface.GetUserInput("Which manager would you like to use ( 1 ) stack  ( 2 ) queue ?");
            if (_manager == "stack")
            {
                _manager = new SweepstakesStackManager();
            }
            else (_manager = "")
        }
        public void CreateSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes();
            _manager.InsertSweepstakes(sweepstakes);

        }
    }
}
