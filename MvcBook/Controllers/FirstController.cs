using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcBook.Models;

namespace MvcBook.Controllers;

public class FirstController : Controller
{
    private readonly ILogger<FirstController> _logger;

    public FirstController(ILogger<FirstController> logger)
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
    public IActionResult Welcome()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
