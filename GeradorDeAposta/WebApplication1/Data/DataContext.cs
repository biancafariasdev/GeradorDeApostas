using Microsoft.EntityFrameworkCore;
using ApostaGenerator.Models;

namespace ApostaGenerator.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Aposta> Apostas { get; set; }
    }
}
