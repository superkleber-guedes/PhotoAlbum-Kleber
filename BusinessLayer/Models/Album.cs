using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BusinessLayer.Models
{
    public class Album
    {
        [JsonProperty(PropertyName = "id")]
        public int AlbumId { get; set; }
        [JsonProperty(PropertyName = "userId")]
        public int UserId { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string AlbumTitle { get; set; }
    }
}
