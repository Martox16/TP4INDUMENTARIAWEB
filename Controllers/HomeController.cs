using Microsoft.AspNetCore.Mvc;

namespace TPBase.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.EquiposIndumentaria = Equipos.EquiposIndumentaria;
        return View();
    }
    public IActionResult SelectIndumentaria()
    {
        ViewBag.EquiposIndumentaria = Equipos.EquiposIndumentaria;
        ViewBag.ListaMedias = Equipos.ListaMedias;
        ViewBag.ListaPantalones = Equipos.ListaPantalones;
        ViewBag.ListaRemeras = Equipos.ListaRemeras;
        ViewBag.ListaEquipos = Equipos.ListaEquipos;
        return View();
    }
    public IActionResult GuardarIndumentaria(string Equipo, int numMedias, int numPantalones, int numRemera)
    {
        bool ingresoInd = false;
        Indumentaria objeto = new Indumentaria(Equipos.ListaMedias[numMedias-1], Equipos.ListaPantalones[numPantalones-1], Equipos.ListaRemeras[numRemera-1]);
        ingresoInd = Equipos.IngresarIndumentaria(Equipo, objeto);

        ViewBag.EquiposIndumentaria = Equipos.EquiposIndumentaria;
        ViewBag.ListaMedias = Equipos.ListaMedias;
        ViewBag.ListaPantalones = Equipos.ListaPantalones;
        ViewBag.ListaRemeras = Equipos.ListaRemeras;
        ViewBag.ListaEquipos = Equipos.ListaEquipos;
        return View("Index");
    }

}

