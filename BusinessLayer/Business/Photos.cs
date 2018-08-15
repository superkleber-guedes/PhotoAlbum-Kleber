using BusinessLayer.Interfaces;
using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Business
{
    public class Photos : JsonFromWeb, IPhotos
    {

        const string url = "http://jsonplaceholder.typicode.com/photos";
        public List<Photo> GetPhotos()
        {
            return base.Get<Photo>(url);
        }
    }
}
