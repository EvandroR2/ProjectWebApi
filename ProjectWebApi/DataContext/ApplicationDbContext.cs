using Microsoft.EntityFrameworkCore;
using ProjectWebApi.Models;

namespace ProjectWebApi.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }

        
    }
}
