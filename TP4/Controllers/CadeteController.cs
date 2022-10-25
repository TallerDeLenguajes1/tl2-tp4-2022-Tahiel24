using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP4.Models;


public class CadeteController : Controller
{
    private readonly ILogger<CadeteController> _logger;

    public CadeteController(ILogger<CadeteController> logger)
    {
        _logger = logger;
    }

    public IActionResult CadeteRecibir()
    {  
        return View();
    }

    [HttpPost]
    public IActionResult MostrarCadete(string Nombre, string Direccion, string Telefono1)
    {
        int id=1;
        Cadete nuevoCadete= new Cadete(id,Nombre,Direccion,Telefono1);
        return View(nuevoCadete);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
