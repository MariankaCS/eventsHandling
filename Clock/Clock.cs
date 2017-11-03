using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clock
{
   public class Clock
    {
        private int second;
        private int minute;
        private int hour;

        // the delegate the subscribers must implement
        public delegate void SecondChangeHandler(
    object clock, TimeInfoEventArgs timeInformation);

        //The event keyword indicates to the compiler that the delegate can be invoked 
        //only by the defining class

        public event SecondChangeHandler SecondChanged;
        
        // set the clock running
        // it will raise an event for each new second
        public void Run()
        {
            // creates an infinite for loop 
            for (;;)
            {
                // sleep 100 milliseconds
                Thread.Sleep(100);

                // get the current time
                System.DateTime dt = System.DateTime.Now;
                // if the second has changed
                // notify the subscribers
                if (dt.Second != second)
                {

                    // create the TimeInfoEventArgs object
                    // to pass to the subscriber
                    TimeInfoEventArgs timeInformation =
                         new TimeInfoEventArgs(dt.Hour, dt.Minute, dt.Second);

                    // if anyone has subscribed, notify them
                    if (SecondChanged != null)
                    {
                        SecondChanged(this, timeInformation);
                    }
                }

                // update the state
                this.second = dt.Second;
                this.minute = dt.Minute;
                this.hour = dt.Hour;
            }
        }
    }
}
