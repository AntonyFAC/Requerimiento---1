using System.Collections;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using rt.Models;
using rt.Services;

namespace rt.Controllers;

public class HomeController : Controller
{
Servicios servicios = new Servicios();
    ArrayList clientes = new ArrayList();
    ArrayList equifax = new ArrayList();
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public Boolean validarCliente(string id)
    {
        clientes = servicios.generarClientes();

        foreach (Cliente cliente in clientes)
        {
            if (cliente.id == id)
            {
                return true;
            }
        }
        return false;
    }

    public Boolean validarEquifax(string id)
    {
        equifax = servicios.generarEquifax();

        foreach (Equifax equifax in equifax)
        {
            if (equifax.id == id)
            {
                return true;
            }
        }
        return false;
    }

    public Boolean validarScore(String id)
    {
        equifax = servicios.generarEquifax();
        foreach (Equifax equifax in equifax)
        {
            if (equifax.id == id)
            {
                if (equifax.score >= 200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        return false;
    }

    public IActionResult Index()
    {
        String id = "12";
        Boolean valid = validarCliente(id);
        if (valid)
        {
            Boolean validEquifax = validarEquifax(id);
            if (validEquifax)
            {
                Boolean validScore = validarScore(id);
                if (validScore)
                {
                    ViewData["Message"] = "Si tiene una buen score en Equifax";
                }
                else
                {
                    ViewData["Message"] = "No tiene una buen score en Equifax";
                }
            }
            else
            {
                ViewData["Message"] = "No registrado en Equifax";
            }
        }
        else
        {
            ViewData["Message"] = "No registrado en el sistema";
            return View(equifax);
        }

        return View();
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
