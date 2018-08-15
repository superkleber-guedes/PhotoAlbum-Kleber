using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;
using BusinessLayer.Models;
using BusinessLayer.Business;

namespace Tests
{
    [TestClass]
    public class BusinessTests
    {
        [TestMethod]
        public void TestGetPhotoAlbums()
        {
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
