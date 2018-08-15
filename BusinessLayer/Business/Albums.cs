using BusinessLayer.Interfaces;
using BusinessLayer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace BusinessLayer.Business
{
    public class Albums : JsonFromWeb, IAlbums
    {
        const string url = "http://jsonplaceholder.typicode.com/albums";
        public List<Album> GetAlbums()
        {
            return base.Get<Album>(url);
        }
    }
}
