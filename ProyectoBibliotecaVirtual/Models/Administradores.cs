using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBibliotecaVirtual.Models
{
    [Table("ADMINISTRADORES")]
    public class Administradores
    {
        public Administradores(string adminUsuario, DateTime fechaNacimiento, string adminContraseña)
        {            
            this.adminUsuario = adminUsuario;
            this.adminUserId = adminUsuario + tag;
            this.FechaNacimiento = fechaNacimiento;
            this.edad = DateTime.Now.Year - fechaNacimiento.Year;
            this.adminContraseña = adminContraseña;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id {  get; set; }

        [Required]
        [MaxLength(100)]
        [Column("USER_ADMIN")]
        public string adminUsuario { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("ADMIN_TAG")]
        public string tag { get; set; } = " #0010";

        [Required]
        [MaxLength(100)]
        [Column("ADMIN_ID")]
        public string adminUserId { get; set; }

        [Required]
        [Column("FECHA_NACIMIENTO")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [Column("FECHA_REGISTRO")]
        public DateTime fechaRegistro { get; set; } = DateTime.Now;

        [Required]
        [MaxLength(100)]
        [Column("ADMIN_EDAD")]
        public int edad {  get; set; }

        [Required]
        [Column("CLAVE_ADMIN")]
        public string adminContraseña { get; set; }

        public void ImprimirADMIN()
        {
            Console.WriteLine("══════════════════════════════════════════════");
            Console.WriteLine(" DATOS DE ADMINISTRADOR:");
            Console.WriteLine(" ID: " + this.id);
            Console.WriteLine(" ADMIN: " + this.adminUserId);
            Console.WriteLine(" Edad: " + this.edad);
        }
    }
}
