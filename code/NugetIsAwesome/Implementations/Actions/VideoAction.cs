using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication1.Entities;
using WindowsFormsApplication1.Interfaces;
using YoutubeExtractor;

namespace WindowsFormsApplication1.Implementations.Actions
{
    public class VideoAction :IRuleAction
    {
        public RuleAction Action { get { return RuleAction.Video;} }
        public void ExecuteAction(string value)
        {
            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(value);
            var video = videoInfos.First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);
            var videoDownloader = new VideoDownloader(video, Path.Combine("C:/Temp", video.Title + video.VideoExtension));
            videoDownloader.Execute();

            MessageBox.Show("Done downloading video", "Done!", MessageBoxButtons.OK);
        }
    }
}