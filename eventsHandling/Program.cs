using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static eventsHandling.MediaStorage;

namespace eventsHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioPlayer audioPlayer1 = new AudioPlayer();
            VideoPlayer videoPlayer1 = new VideoPlayer();

            PlayMedia one = new PlayMedia(audioPlayer1.PlayAudioFile);
            PlayMedia two = new PlayMedia(videoPlayer1.PlayVideoFile);

            MediaStorage myMediaStorage = new MediaStorage();
            myMediaStorage.ReportResult(one);
            myMediaStorage.ReportResult(two);
            

            Console.ReadLine();

        }
    }
}
