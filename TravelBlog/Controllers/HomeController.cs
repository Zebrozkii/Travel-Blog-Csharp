using Microsoft.AspNetCore.Mvc;
using Blog.Models;

namespace Blog.Model.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }



  }
}
