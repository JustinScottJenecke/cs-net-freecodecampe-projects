using Microsoft.AspNetCore.Mvc;
using FoodMenuApp.Data;
using FoodMenuApp.Models;

namespace FoodMenuApp.Controllers
{
    public class MenuController : Controller
    {
        // GET: MenuController
        private readonly FoodMenuContext _dbContext

        public ActionResult Index()
        {
            return View();
        }

    }
}
