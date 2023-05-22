using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04.Models;

namespace TP04.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Paquetes = ORTWorld.Paquetes; 
        ViewBag.VerificarPaquete = ORTWorld.hayPaquete;
        return View();
    }

    public IActionResult SelectPaquete(){
        ViewBag.Destinos = ORTWorld.ListaDestinos;
        ViewBag.Hoteles = ORTWorld.ListaHoteles;
        ViewBag.Aereos = ORTWorld.ListaAereos;
        ViewBag.Excursiones = ORTWorld.ListaExcursiones;
        return View();
    }
    public IActionResult GuardarPaquete(int Destino, int Hotel, int Aereo, int Excursion){
        ViewBag.ListaDestinos = ORTWorld.ListaDestinos;
        ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
        ViewBag.ListaAereos = ORTWorld.ListaAereos;
        ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;
        ViewBag.VerificarPaquete = ORTWorld.hayPaquete;
        string destinoSeleccionado = ORTWorld.ListaDestinos[Destino];
        string hotelSeleccionado = ORTWorld.ListaHoteles[Hotel];
        string aereoSeleccionado = ORTWorld.ListaAereos[Aereo];
        string excursionSeleccionada = ORTWorld.ListaExcursiones[Excursion];
        Paquete paquete = new Paquete(hotelSeleccionado, aereoSeleccionado, excursionSeleccionada);
        bool a = ORTWorld.IngresarPaquete(destinoSeleccionado,paquete);
        if(Destino < 0 && Destino > 10 || Hotel < 0 && Hotel > 10 || Aereo < 0 && Aereo > 10 || Excursion < 0 && Excursion > 10){
            return View("SelectPaquete");
        }
        else{
        ViewBag.Paquetes = ORTWorld.Paquetes;
        return View("Index");
        }
    }public IActionResult BorrarPaquete(string Clave){
        if(Clave != null){
        ORTWorld.Paquetes.Remove(Clave);
        }
        return View("Index");
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
