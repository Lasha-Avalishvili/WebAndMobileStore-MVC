using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAndMobileStore.Models;

namespace WebAndMobileStore.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            var items = new List<Item>
    {
        new Item { Name = "Item 1", Description = "Description of Item 1", Price = 10.99m, ImageUrl = "https://static.vecteezy.com/vite/assets/photo-masthead-375-b8ae1548.webp" },
        new Item { Name = "Item 2", Description = "Description of Item 2", Price = 15.99m, ImageUrl = "https://static.vecteezy.com/vite/assets/photo-masthead-375-b8ae1548.webp" },
        new Item { Name = "Item 3", Description = "Description of Item 3", Price = 20.99m, ImageUrl = "https://static.vecteezy.com/vite/assets/photo-masthead-375-b8ae1548.webp" },
        new Item { Name = "Item 1", Description = "Description of Item 1", Price = 10.99m, ImageUrl = "https://static.vecteezy.com/vite/assets/photo-masthead-375-b8ae1548.webp" },
        new Item { Name = "Item 2", Description = "Description of Item 2", Price = 15.99m, ImageUrl = "https://static.vecteezy.com/vite/assets/photo-masthead-375-b8ae1548.webp" },
        new Item { Name = "Item 3", Description = "Description of Item 3", Price = 20.99m, ImageUrl = "https://static.vecteezy.com/vite/assets/photo-masthead-375-b8ae1548.webp" },
        new Item { Name = "Item 1", Description = "Description of Item 1", Price = 10.99m, ImageUrl = "https://static.vecteezy.com/vite/assets/photo-masthead-375-b8ae1548.webp" },
        new Item { Name = "Item 2", Description = "Description of Item 2", Price = 15.99m, ImageUrl = "https://static.vecteezy.com/vite/assets/photo-masthead-375-b8ae1548.webp" },
        new Item { Name = "Item 3", Description = "Description of Item 3", Price = 20.99m, ImageUrl = "https://static.vecteezy.com/vite/assets/photo-masthead-375-b8ae1548.webp" }
    };

            return View(items);
        }



    }
}