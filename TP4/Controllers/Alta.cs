using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP4.Models;

namespace TP4.Controllers;

public class AltaController : Controller
{
    private readonly ILogger<AltaController> _logger;

    public AltaController(ILogger<AltaController> logger)
    {
        _logger = logger;
    }


    public IActionResult AltaPedido()
    {
        return View();
    }

}
