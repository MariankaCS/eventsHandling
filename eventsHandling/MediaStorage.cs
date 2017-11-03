using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventsHandling
{
    public class MediaStorage
    {
        public delegate int PlayMedia();

        public void ReportResult(PlayMedia playerDelegate)
        {
            if (playerDelegate() == 0)
            {
                Console.WriteLine("Media played successfully.");
            }
            else
            {
                Console.WriteLine("Media did not play successfully.");
            }
        }

    }
}
