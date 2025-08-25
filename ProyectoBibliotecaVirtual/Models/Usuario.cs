using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBibliotecaVirtual.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string nombreCompleto { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int edad {  get; set; }
        public string nombreUsuario { get; set; }
        public string correo { get; set; }
        private string contraseña { get; set; }

    }
}
