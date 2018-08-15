using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;
using BusinessLayer.Models;
using BusinessLayer.Business;
using Moq;
using BusinessLayer.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class BusinessTests
    {
        [TestMethod]
        public void TestGetPhotoAlbums()
        {
            //Mocking Albums and Photos for testing

            var albums = new Mock<IAlbums>();
            albums
                .Setup(m => m.GetAlbums())
                .Returns(new List<Album>()
                {
                    new Album() { AlbumId = 1, AlbumTitle = "Mock 1", UserId = 1},
                    new Album() { AlbumId = 2, AlbumTitle = "Mock 2", UserId = 1},
                    new Album() { AlbumId = 3, AlbumTitle = "Mock 3", UserId = 1}
                });

            var photos = new Mock<IPhotos>();
            photos
                .Setup(m => m.GetPhotos())
                .Returns(new List<Photo>()
                {
                    new Photo() { AlbumId = 1, PhotoId = 1, PhotoTitle = "Photo 1 - Album 1", ThumbnailUrl = "thumb1", Url = "url1"},
                    new Photo() { AlbumId = 1, PhotoId = 2, PhotoTitle = "Photo 2 - Album 1", ThumbnailUrl = "thumb2", Url = "url2"},
                    new Photo() { AlbumId = 2, PhotoId = 3, PhotoTitle = "Photo 3 - Album 2", ThumbnailUrl = "thumb3", Url = "url3"},
                    new Photo() { AlbumId = 2, PhotoId = 4, PhotoTitle = "Photo 4 - Album 2", ThumbnailUrl = "thumb4", Url = "url4"},
                    new Photo() { AlbumId = 3, PhotoId = 5, PhotoTitle = "Photo 5 - Album 3", ThumbnailUrl = "thumb5", Url = "url5"},
                });

            PhotoAlbums photoAlbums = new PhotoAlbums(albums.Object, photos.Object);
            var photoAlbumList = photoAlbums.BuildPhotoAlbumsList();
            Assert.IsNotNull(photoAlbumList);   //failing!

            Assert.IsTrue(photoAlbumList.Count == 5);

            Assert.IsTrue(photoAlbumList.Where(a => a.AlbumId == 1).ToList().Count == 2);
            Assert.IsTrue(photoAlbumList.Where(a => a.AlbumId == 2).ToList().Count == 2);
            Assert.IsTrue(photoAlbumList.Where(a => a.AlbumId == 3).ToList().Count == 1);
            Assert.IsTrue(photoAlbumList.FirstOrDefault(a => a.PhotoId == 1).PhotoTitle == "Photo 1 - Album 1");
            Assert.IsTrue(photoAlbumList.FirstOrDefault(a => a.PhotoId == 1).AlbumName == "Mock 1");

        }

        [TestMethod]
        public void TestGetPhotos()
        {
            Photos photos = new Photos();
            var photoList = photos.GetPhotos();
            Assert.IsNotNull(photoList); 
            Assert.IsTrue(photoList.Count > 0);
        }

        [TestMethod]
        public void TestGetAlbums()
        {
            Albums albums = new Albums();
            var albumList = albums.GetAlbums();
            Assert.IsNotNull(albumList); 
            Assert.IsTrue(albumList.Count > 0);
        }

    }
}
