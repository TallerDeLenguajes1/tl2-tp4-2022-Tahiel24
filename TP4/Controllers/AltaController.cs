using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP4.Models;

namespace TP4.Controllers;

public class AltaCadetesController1 : Controller
{
    private readonly ILogger<AltaCadetesController1> _logger;

    public AltaCadetesController1(ILogger<AltaCadetesController1> logger)
    {
        _logger = logger;
    }


    public IActionResult AltaPedido()
    {
        Ayuda nuevaAyuda = new Ayuda();
        List<Cadete> nuevaLista= nuevaAyuda.Contenido();
        return View(nuevaLista);
    }

}
