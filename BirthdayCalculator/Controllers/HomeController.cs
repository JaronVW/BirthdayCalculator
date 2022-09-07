using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BirthdayCalculator.Models;

namespace BirthdayCalculator.Controllers;

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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpGet]
    public IActionResult CalculatorForm()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CalculatorForm(BirthDate birthDate)
    {
        Repository.addBirthDate(birthDate);
        var today = DateTime.Today;
        Console.WriteLine(birthDate.Name);
        
        if (birthDate.Day == today.Day && birthDate.Month == today.Month)
        {
            return View("HappyBirthday", birthDate);
        }
        return View("DaysUntillBirthday", birthDate);
    }
}   