using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCYapayZeka_14_04.Models;

namespace MVCYapayZeka_14_04.Controllers;

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

    public IActionResult Iletisim()
    {
        return View();
    }


    public IActionResult YapayZekaNedir()
    {
        return View();
    }

    public IActionResult UygulamaAlanlari()
    {
        return View();
    }

    public IActionResult YapayZekaTarihcesi()
    {
        return View();
    }

    public IActionResult TemelTerimler()
    {
        return View();
    }


    public IActionResult MakineOgrenmesi()
    {
        return View();
    }

    public IActionResult HangiProgramlamaDilleri()
    {
        return View();
    }

    public IActionResult DerinOgrenme()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
