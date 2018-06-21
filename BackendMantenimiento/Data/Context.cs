using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackendMantenimiento.Models;

namespace BackendMantenimiento.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
        {
        }
        public DbSet<Marca> Marcas{ get; set;  }
    }
}
