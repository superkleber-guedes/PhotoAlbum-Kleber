using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BusinessLayer.Models
{
    public class Photo
    {
        [JsonProperty(PropertyName = "albumId")]
        public int AlbumId { get; set; }
        [JsonProperty(PropertyName = "id")]
        public int PhotoId { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string PhotoTitle { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        [JsonProperty(PropertyName = "thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

    }
}
