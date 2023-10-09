using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using actionfilter.Models;
using FiltersExtension;
namespace actionfilter.Controllers;

[TypeFilter(typeof(CustomeExceptionfilters))]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    //public IActionResult Index() =>
    //    Content($"- {nameof(HomeController)}.{nameof(Index)}");
    //[Resourcefilter]
    //[SampleActionFilter]
    public IActionResult Index()
    {
        var modal = new Userdetails();
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
}