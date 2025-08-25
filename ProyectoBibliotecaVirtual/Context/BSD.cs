using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBibliotecaVirtual.Context
{
    public class BSD: DbContext
    {
        public DbSet<Models.Administradores> Admins => Set<Models.Administradores>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Frenk\\FRANKIE;Database=BibliotecaVirtual;Trusted_Connection=True;TrustServerCertificate=True");
        }


    }
}
