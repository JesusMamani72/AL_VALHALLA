using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AL_VALHALLA.Models
{
    public class DestinoModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; } // Ruta de la imagen
    }

}
