using HERNANDEZ_T3.WEB.DB;
using HERNANDEZ_T3.WEB.Models;
using HERNANDEZ_T3.WEB.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HERNANDEZ_T3.WEB.Controllers
{
    [Authorize]
    public class MascotaController : Controller
    {

        private readonly IMascotaRepositorio mascotaRepositorio;

        public MascotaController( IMascotaRepositorio mascotaRepositorio)
        {
            this.mascotaRepositorio = mascotaRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ViewList()
        {
            var ListaM = mascotaRepositorio.ObtenerMascotas();
            return View(ListaM);
        }

        [HttpGet]
        public IActionResult CreateNew()
        {
            return View(new Mascota());
        }

        [HttpPost]
        public IActionResult CreateNew(Mascota mascota)
        {
            mascota.FechaRegistro = DateTime.Now;
            if (mascota.Nombre==null || mascota.Nombre == "")
            {
                ModelState.AddModelError("Nombre", "Falto el Ingreso del nombre");
            }
            if (mascota.FechaNacimiento == Convert.ToDateTime("01/01/0001 0:00:00"))
            {
                ModelState.AddModelError("FechaNacimiento", "Falto el Ingreso de la fecha");
            }
            if (mascota.FechaNacimiento > DateTime.Now)
            {
                ModelState.AddModelError("FechaNacimiento", "La fecha no es valida");
            }
            if (mascota.Sexo == null || mascota.Sexo == "Elige")
            {
                ModelState.AddModelError("Sexo", "Falto el Ingreso del sexo");
            }
            if (mascota.Especie == null || mascota.Especie == "Elige")
            {
                ModelState.AddModelError("Especie", "Falto el Ingreso de la especie");
            }
            if (mascota.Raza == null || mascota.Raza == "Elige")
            {
                ModelState.AddModelError("Raza", "Falto el Ingreso de la raza");
            }
            if (mascota.Tamano == null || mascota.Tamano == 0)
            {
                ModelState.AddModelError("Tamano", "Falto el Ingreso del tamaño");
            }
            if (mascota.NombreDueño == null || mascota.NombreDueño == "")
            {
                ModelState.AddModelError("NombreDueño", "Falto el Ingreso del Nombre");
            }
            if (mascota.Direccion == null || mascota.Direccion == "")
            {
                ModelState.AddModelError("Direccion", "Falto el Ingreso de la direccion");
            }
            if (mascota.Telefono == null || mascota.Telefono == "")
            {
                ModelState.AddModelError("Telefono", "Falto el Ingreso del telefono");
            }
            if (mascota.Email == null || mascota.Email == "")
            {
                ModelState.AddModelError("Email", "Falto el Ingreso del E-mail");
            }
            if (mascota.DatosParticulares==null)
            {
                mascota.DatosParticulares = "";
            }


            if (!ModelState.IsValid)
            {
                return View("CreateNew", mascota);
            }

            mascotaRepositorio.SaveMascota(mascota);

            var ListaM = mascotaRepositorio.ObtenerMascotas();
            return View("ViewList",ListaM);
        }
    }
}
