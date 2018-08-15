using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ViewModels
{
    public class PhotoAlbum
    {
        public int PhotoId { get; set; }
        public string PhotoTitle{ get; set; }
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public string ThumbnailUrl { get; set; }
        public string Url { get; set; }
    }
}
