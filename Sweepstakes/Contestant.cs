﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Sweepstakes
{
    class Contestant
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public int registrationNumber { get; set; }

        //public string firstName {get; set;}
        public Contestant()
        {
            firstName = UserInterface.GetUserInput("Please enter your first name: ");
            lastName = UserInterface.GetUserInput("Please enter your first name: ");
            emailAddress = UserInterface.GetUserInput("Please enter your E-mail address: ");
            this.registrationNumber = registrationNumber +1;
            //going back to putting GetUserInput here, should fix the issue im having trying to add contestant to list in sweepstakes class 
            //Contestant.Dictonary.count + 1; //registrationNumber = List<> count++;???
        }
    }
}
