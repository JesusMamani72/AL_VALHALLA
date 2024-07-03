using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AL_VALHALLA.Models
{
    public class ReservaModel
    {
        public int Id { get; set; }
        public string NombreCliente { get; set; }
        public string CI { get; set; }
        public int CantidadPersonas { get; set; }
        public DateTime FechaReserva { get; set; }
        public string Comprobante { get; set; } // Ruta del comprobante de pago
        public int DestinoId { get; set; }
        public DestinoModel Destino { get; set; }
    }

}
