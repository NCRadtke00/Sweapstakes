using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Sweepstakes
{
    class Contestant
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;
        public Contestant()
        {
            firstName = UserInterface.GetUserInput("Please enter your first name: ");
            lastName = UserInterface.GetUserInput("Please enter your first name: ");
            emailAddress = UserInterface.GetUserInput("Please enter your E-mail address: ");
            //registrationNumber = List<> count++;
        }
    }
}
