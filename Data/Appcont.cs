using CRUD_Cli.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Cli.Data
{
    public class Appcont : DbContext
    {       
            public Appcont(DbContextOptions<Appcont> options) : base(options)
            {

            }
            public DbSet<Usuario> Usuario { get; set; }
     
    }
}
