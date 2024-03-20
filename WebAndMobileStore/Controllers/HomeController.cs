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
        new Item { Name = "Item 2", Description = "Description of Item 2", Price = 15.99m, ImageUrl = "https://img.freepik.com/free-photo/painting-mountain-lake-with-mountain-background_188544-9126.jpg" },
        new Item { Name = "Item 3", Description = "Description of Item 3", Price = 20.99m, ImageUrl = "https://media.istockphoto.com/id/1160446488/photo/tbilisi-downtown-georgia-taken-in-april-2019.jpg?s=612x612&w=0&k=20&c=yybfqVCUZsy8qNWMnpmX1AjAmbuXtj5Kg5aekaeHj7M=" },
        new Item { Name = "Item 1", Description = "Description of Item 1", Price = 10.99m, ImageUrl = "https://letsenhance.io/static/8f5e523ee6b2479e26ecc91b9c25261e/1015f/MainAfter.jpg" },
        new Item { Name = "Item 2", Description = "Description of Item 2", Price = 15.99m, ImageUrl = "https://images.pexels.com/photos/674010/pexels-photo-674010.jpeg?cs=srgb&dl=pexels-anjana-c-674010.jpg&fm=jpg" },
        new Item { Name = "Item 3", Description = "Description of Item 3", Price = 20.99m, ImageUrl = "https://static.vecteezy.com/vite/assets/photo-masthead-375-b8ae1548.webp" },
        new Item { Name = "Item 1", Description = "Description of Item 1", Price = 10.99m, ImageUrl = "https://static.vecteezy.com/vite/assets/photo-masthead-375-b8ae1548.webp" },
        new Item { Name = "Item 2", Description = "Description of Item 2", Price = 15.99m, ImageUrl = "https://static.vecteezy.com/vite/assets/photo-masthead-375-b8ae1548.webp" },
        new Item { Name = "Item 3", Description = "Description of Item 3", Price = 20.99m, ImageUrl = "https://static.vecteezy.com/vite/assets/photo-masthead-375-b8ae1548.webp" }
    };

            return View(items);
        }



    }
}