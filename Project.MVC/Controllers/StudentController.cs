using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project.MVC.Models;
using Project.Business.Services.Students;

namespace Project.MVC.Controllers;

public class StudentController(
    StudentServices service,
    ILogger<StudentController> logger) : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
