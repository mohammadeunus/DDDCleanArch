using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DDDCleanArch.Web.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
using IEmailSender = DDDCleanArch.Web.Models.IEmailSender;

namespace DDDCleanArch.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IEmailSender _emailSender;

    public HomeController(ILogger<HomeController> logger, IEmailSender emailSender)
    {
        _logger = logger;
        _emailSender = emailSender;
    }

    public async Task<IActionResult> Index()
    {
        //await _emailSender.SendEmailAsync("100eunus@gmail.com", "hi", "asdfasdfasdfasdf");
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
