using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AL_VALHALLA.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string NombreCompleto { get; set; }
        public string Rol { get; set; }
    }
}
