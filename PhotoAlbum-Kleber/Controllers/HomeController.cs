using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using PhotoAlbum_Kleber.Models;

namespace PhotoAlbum_Kleber.Controllers
{
    public class HomeController : Controller
    {
        private IPhotoAlbums _photoAlbums;

        public HomeController(IPhotoAlbums photoAlbums)
        {
            _photoAlbums = photoAlbums;
        }

        public IActionResult Index()
        {
            //Done on the home controller to keep it simple
            var list = _photoAlbums.BuildPhotoAlbumsList();
            return View(list);
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
