using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP4.Models;
namespace TP4.Controllers;

public class AltaCadetesController: Controller
{
    private readonly ILogger<AltaCadetesController> _logger;

    public AltaCadetesController(ILogger<AltaCadetesController> logger)
    {
        _logger = logger;
    }

    public IActionResult CadeteAlta(){
        return View();
    }
}