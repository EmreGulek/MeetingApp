using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;

namespace MeetingApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        int saat = DateTime.Now.Hour;
        ViewBag.Selamlama  = saat > 12 ? "İyi Günler" : "Günaydın";
        
        int UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();

        var meetingInfo = new MeetingInfo()
        {
         MeetingId = 1,
         Location = "İstanbul - Harbiye Kongre Merkezi",
         Date = new DateTime(2024,01,20,20,0,0),
         NumberOfPeople = UserCount
        };
        return View(meetingInfo);
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