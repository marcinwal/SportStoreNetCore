using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepositiry repositiry;

        public HomeController(IStoreRepositiry repo)
        {
            repositiry = repo;
        }

        public IActionResult Index() => View(repositiry.Products);
    }
}
