using Microsoft.AspNetCore.Mvc;
using ApiAuthorization.Models;

namespace ApiAuthorization.Controllers
{
  public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allArticles = TopStory.GetArticles("KcK6fDjAAqo2gIv9e0LJboxvgQW8tcpD");
            return View(allArticles);
        }
    }
}