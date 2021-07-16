using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RegistroUsuarios.Models;

namespace RegistroUsuarios.Data
{
    public class ApplicationDbContext : IdentityDbContext<Usuarios, IdentityRole<int>, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
