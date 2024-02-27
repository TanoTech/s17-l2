using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using s17_l1.Models;

namespace s17_l1.Controllers;

public class PaymentController : Controller
{
    private readonly ILogger<PaymentController> _logger;

    public PaymentController(ILogger<PaymentController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        return View(StaticDb.GetAllPayment());
    }

    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add( DateOnly periodoPagamento, decimal totale, bool stipendioAcconto)
    {
        
        StaticDb.Add(periodoPagamento, totale, stipendioAcconto);
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}