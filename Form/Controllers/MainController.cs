using Form.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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

    public IActionResult UserDataForm()
    {
        var model = new UserData();
        return View(model);
    }

    [HttpPost]
    public IActionResult UserDataForm(UserData model)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction("SuccessForm", new
            {
                country = model.SelectedCountry, 
                firstName = model.FirstName,
                lastName = model.LastName,
                gender = model.Gender,
                subscribeToNewsletter = model.SubscribeToNewsletter
            });
        }
        return View(model);
    }

    public IActionResult SuccessForm(string country, string firstName, string lastName, string gender, bool subscribeToNewsletter)
    {
        ViewBag.Country = country;
        ViewBag.FirstName = firstName;
        ViewBag.LastName = lastName;
        ViewBag.Gender = gender;
        ViewBag.SubscribeToNewsletter = subscribeToNewsletter;
        return View();
    }
}