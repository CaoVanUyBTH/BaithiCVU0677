using Microsoft.AspNetCore.Mvc;

namespace CVUMvc.Controllers;

public class CVUCau3Controller : Controller
{
    private readonly ILogger<HomeController> _logger;

    public CVUCau3Controller(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }
     public IActionResult Edit()
    {
        return View();
    }
     public IActionResult Delete()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View();
    }
}