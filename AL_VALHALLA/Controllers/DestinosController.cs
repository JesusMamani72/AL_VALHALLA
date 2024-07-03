using Microsoft.AspNetCore.Mvc;
using AL_VALHALLA.Models;
using System.Collections.Generic;


namespace AL_VALHALLA.Controllers
{


    public class DestinosController : Controller
    {
        private static List<DestinoModel> destinos = new List<DestinoModel>();

        public IActionResult Index()
        {
            return View(destinos);
        }

        public IActionResult Details(int id)
        {
            var destino = destinos.Find(d => d.Id == id);
            if (destino == null) return NotFound();
            return View(destino);
        }

        public IActionResult Reservar(int id)
        {
            var destino = destinos.Find(d => d.Id == id);
            if (destino == null) return NotFound();
            return View(new ReservaModel { DestinoId = id, Destino = destino });
        }

        [HttpPost]
        public IActionResult Reservar(ReservaModel model)
        {
            if (ModelState.IsValid)
            {
                // Lógica para manejar la reserva
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
