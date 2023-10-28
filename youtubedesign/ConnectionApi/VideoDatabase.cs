using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace youtubedesign.ConnectionApi
{
    public class VideoInforms
    {
        public string VideoId { get; set; }
        public string Title { get; set; }
        public string ThumbnailUrl { get; set; }
    }
    public static class VideoDatabase
    {
        static public List<VideoInforms> videos = new List<VideoInforms>();


        static public List<VideoInforms> Serachvideo(string queryy)
        {
            string apiKey = "AIzaSyANn6qzj4apKWvSvwK6OP4MJGuLyy7a_NE";
            string query = queryy;

            VideoSearch videoSearch = new VideoSearch();
            return videoSearch.SearchVideos(apiKey, query);

        }
    }
}
