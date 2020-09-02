using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> queue = new Queue<Sweepstakes>();
        public void InsetSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            //Sweepstakes
            //Console.WriteLine("\nDequeuing '{0}'", queue.Dequeue());
            //Console.WriteLine(" The runner-up is : {0}", queue.Peek());
            //Console.WriteLine("Dequeuing '{0}'", queue.Dequeue());
            return queue.Dequeue();
        }
    }
}
