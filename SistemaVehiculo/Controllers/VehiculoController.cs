using Microsoft.AspNetCore.Mvc;
using SistemaVehiculo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVehiculo.Controllers
{
    public class VehiculoController : Controller
    {
        ServiceVehiculos services = new ServiceVehiculos();
        public IActionResult Index()
        {
            return View();
        }


        public ActionResult ListaVehiculo(string marca)
        {
           var lista = services.listar(marca);
            return View(lista);
        }


        




    }
}
