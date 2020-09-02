using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> stack = new Stack<Sweepstakes>();

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            // Displays the properties and values of the Stack.
            //Console.WriteLine("myStack");
            //Console.WriteLine("\tCount:    {0}", stack.Count;
            //Console.Write("\tValues:");
            return stack.Pop();
            // or would i want return stack.Peek();

           
        }
    }
}
