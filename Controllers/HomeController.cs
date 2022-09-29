using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dojosurverymodel1.Models;

namespace dojosurverymodel1.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]

    public ViewResult Index()
    {
        return View("Index");
    }

[HttpPost("/result")]

    public IActionResult Submit(Result result)
    {
        if(ModelState.IsValid){
            return View("result", result);
        }else{
            return View("Index");
        }
        
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
