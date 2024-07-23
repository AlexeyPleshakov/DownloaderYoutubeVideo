using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloaderYoutubeVideo
{
    class YoutubeReceiver
    {
        public string videoURL;
        public YoutubeReceiver(string videoURL)
        {
            this.videoURL = videoURL;
        }

        public void Operation()
        {
            Console.WriteLine("Процесс запущен");
        }
    }
}
