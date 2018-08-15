using BusinessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IPhotoAlbums
    {
        List<PhotoAlbum> BuildPhotoAlbumsList();
    }
}
