using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace DownloaderYoutubeVideo.Commands
{
    class DownloadCommand : ICommand
    {
        readonly YoutubeReceiver receiver;
        readonly YoutubeClient client;
        public DownloadCommand(YoutubeReceiver receiver, YoutubeClient client)
        {
            this.receiver = receiver;
            this.client = client;
        }

        public async Task Run()
        {
            Console.WriteLine("Загружаем видео...");
            var streamMainfest = await client.Videos.Streams.GetManifestAsync(receiver.videoURL);
            var streamsInfo = streamMainfest.GetMuxedStreams().GetWithHighestVideoQuality();
            await client.Videos.Streams.DownloadAsync(streamsInfo, $"video.{streamsInfo.Container}");
        }
    }
}
