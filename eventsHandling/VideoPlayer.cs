using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventsHandling
{
    class VideoPlayer
    {
        private int videoPlayerStatus;

        public int PlayVideoFile()
        {
            Console.WriteLine("Simulating playing an audio file here.");
            videoPlayerStatus = -1;
            return videoPlayerStatus;
        }
    }
}
