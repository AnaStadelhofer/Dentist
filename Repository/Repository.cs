using Models;
using Microsoft.EntityFrameworkCore;
namespace Repository
{
    public class Context : DbContext
    {
        public DbSet<Sala> Salas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseMySql("Server=localhost;User Id=root;Database=dentista");
    }
}