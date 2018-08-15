using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IPhotos
    {
        List<Photo> GetPhotos();
    }
}
