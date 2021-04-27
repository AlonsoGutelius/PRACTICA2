using Microsoft.EntityFrameworkCore;
using PRACTICA2.Models;

namespace PRACTICA2.Data
{
    public class UsuarioContext : DbContext
    {
        
        public DbSet<Usuario> Usuarios { get; set; }

        public UsuarioContext(DbContextOptions dco) : base(dco) {

        }
    }
    
}