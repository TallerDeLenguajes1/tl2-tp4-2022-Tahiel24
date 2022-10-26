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
    public IActionResult MostrarCadete(string Nombre, string Direccion, string Telefono1,int Id)
    {
        Ayuda nuevaAyuda=new Ayuda();
        Cadete nuevoCadete= new Cadete(Id,Nombre,Direccion,Telefono1);
        nuevaAyuda.GuardarCadete(nuevoCadete);
        List<Cadete>listaCadetes=new List<Cadete>();
        listaCadetes=nuevaAyuda.DevolverCadetes();
        return View(listaCadetes);
    }

    public IActionResult MostrarCadetesPrincipal()
    {
        Ayuda nuevaAyuda=new Ayuda();
        List<Cadete>listaCadetes=new List<Cadete>();
        listaCadetes=nuevaAyuda.DevolverCadetes();
        return View(listaCadetes);
    }

    public IActionResult IntermedioBorrar()
    {
        Ayuda nuevaAyuda=new Ayuda();
        List<Cadete>listaCadetes=new List<Cadete>();
        listaCadetes=nuevaAyuda.DevolverCadetes();
        return View(listaCadetes);
    }
    
    [HttpPost]
    public RedirectToActionResult EliminarCadetes(int Id, string Nombre, string Direccion, string Telefono1)
    {   
        Ayuda nuevaAyuda=new Ayuda();
        Cadete cadeteEliminado= new Cadete(Id, Nombre, Direccion, Telefono1);
        nuevaAyuda.EliminarCadetes(cadeteEliminado);
        return RedirectToAction("MostrarCadetesPrincipal");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
