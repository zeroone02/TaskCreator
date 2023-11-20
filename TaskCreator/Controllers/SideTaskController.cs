using Microsoft.AspNetCore.Mvc;

namespace TaskCreator.Controllers;
public class SideTaskController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
