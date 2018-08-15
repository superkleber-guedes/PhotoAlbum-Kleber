using BusinessLayer.Interfaces;
using BusinessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Business
{
    public class PhotoAlbums : IPhotoAlbums
    {
        private IAlbums _albums;
        private IPhotos _photos;

        public PhotoAlbums(IAlbums albums, IPhotos photos)
        {
            _albums = albums;
            _photos = photos;
        }

        public List<PhotoAlbum> BuildPhotoAlbumsList()
        {
            return null; //not implemented
        }
    }
}
