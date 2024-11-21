using BlazorApp3.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp3.Data
{
    public class PermissaoDbContext : DbContext
    {

        public PermissaoDbContext(DbContextOptions<PermissaoDbContext> options) : base(options)
        {
        }

        public DbSet<PermissaoCliente> permissaoClientes { get; set; }
        public DbSet<PermissaoFormaEnvio> permissaoFormaEnvios { get; set; }
        public DbSet<PermissaoEnviarPara> permissaoEnviarPara { get; set; }
        public DbSet<PermissaoTipo> permissaoTipos { get; set; }
    }
}
