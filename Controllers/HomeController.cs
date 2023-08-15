using DECK_OF_CARDS_API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DECK_OF_CARDS_API.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        //[HttpGet] //Default
        public IActionResult Show5Cards()
        {
            
            DeckModel result = DeckDAL.GetCards(5);
            return View(result);
        }
        public IActionResult NewDeck()
        {
            DeckDAL.ResetCards();
            return RedirectToAction("Show5Cards");
        }
        //[HttpPost] //form posts
        //public IActionResult Show5Cards(bool nothing)
        //{
        //    DeckDAL.ResetCards();
        //    DeckModel result = DeckDAL.GetCards(5);
        //    return View(result);
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}