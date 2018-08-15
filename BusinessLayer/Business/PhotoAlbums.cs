using BusinessLayer.Interfaces;
using BusinessLayer.Models;
using BusinessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
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
            //I did not use Automapper here to keep it simple, but I could download the NuGet Package, and create Mapper.CreateMap(), and use Mapper.Map<Source, Destiny>

            var allAlbums = _albums.GetAlbums();
            var allPhotos = _photos.GetPhotos();

            List<PhotoAlbum> result = new List<PhotoAlbum>();

            foreach(Photo photo in allPhotos)
            {
                PhotoAlbum photoAlbum = new PhotoAlbum()
                {
                    AlbumId = photo.AlbumId,
                    PhotoTitle = photo.PhotoTitle,
                    ThumbnailUrl = photo.ThumbnailUrl,
                    Url = photo.Url,
                    PhotoId = photo.PhotoId
                };
                result.Add(photoAlbum);
            }
            result.ForEach(x => x.AlbumName = allAlbums.FirstOrDefault(y => y.AlbumId == x.AlbumId).AlbumTitle);
            return result;

        }
    }
}
