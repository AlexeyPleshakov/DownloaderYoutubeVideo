using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace DownloaderYoutubeVideo.Commands
{
    class ShowCommand : ICommand
    {
        readonly YoutubeReceiver receiver;
        readonly YoutubeClient client;
        public ShowCommand(YoutubeReceiver receiver, YoutubeClient youtubeClient)
        {
            this.receiver = receiver;
            client = youtubeClient;
        }

        public async Task Run()
        {
            YoutubeExplode.Videos.Video videoInfo = await client.Videos.GetAsync(receiver.videoURL);
            Console.WriteLine("Название видео: {0}", videoInfo.Title);
            Console.WriteLine($"Описание видео: {videoInfo.Description}");
            Console.WriteLine($"Продолжительность: {videoInfo.Duration}");
            Console.WriteLine($"Автор: {videoInfo.Author}");
        }
    }
}
