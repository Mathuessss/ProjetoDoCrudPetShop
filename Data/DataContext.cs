
using Crud_do_petshop.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_do_petshop.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Servico> Servico { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}