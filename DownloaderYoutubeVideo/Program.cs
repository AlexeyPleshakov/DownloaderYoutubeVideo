using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace DownloaderYoutubeVideo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Укажите ссылку на интересующее видео: ");
            string videoURL = Console.ReadLine();

            YoutubeClient client = new YoutubeClient();
            YoutubeReceiver receiver = new YoutubeReceiver(videoURL);
            User user = new User();

            Commands.ShowCommand showCommand = new Commands.ShowCommand(receiver, client);
            user.SetCommand(showCommand);
            user.Run();
            Console.ReadLine();
            Commands.DownloadCommand downloadCommand = new Commands.DownloadCommand(receiver,client);
            user.SetCommand(downloadCommand);
            user.Run();
            Console.ReadLine();
        }
    }
}
