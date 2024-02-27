using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using s17_l1.Models;

namespace s17_l1.Controllers;

public class EmployeesController : Controller
{
    private readonly ILogger<EmployeesController> _logger;

    public EmployeesController(ILogger<EmployeesController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        return View(StaticDb.GetAll());
    }

    public IActionResult Details(int? id)
    {
        if (id.HasValue)
        {
            return View(StaticDb.GetById(id));
        }
        else
        {
            return RedirectToAction("Index", "Employees");
        }
    }
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(string nome, string cognome, string indirizzo, bool coniugato, int numeroFigli, string mansione)
    {
        var employee = StaticDb.Add(nome, cognome, indirizzo, coniugato, numeroFigli, mansione);
        return RedirectToAction("Details", new { id = employee.Id });
    }

    public IActionResult Edit()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}