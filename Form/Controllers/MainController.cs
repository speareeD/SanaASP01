using Microsoft.AspNetCore.Mvc;

namespace Form.Controllers;

public class MainController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}