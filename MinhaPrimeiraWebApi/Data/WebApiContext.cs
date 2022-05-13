using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraWebApi.Entities;

namespace MinhaPrimeiraWebApi.Data
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }
    }
}