using Microsoft.AspNetCore.Mvc;

namespace TaskCreator.Controllers;
public class MainTaskController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
