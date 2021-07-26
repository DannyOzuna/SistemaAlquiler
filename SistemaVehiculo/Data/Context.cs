using Microsoft.EntityFrameworkCore;
using SistemaVehiculo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVehiculo.Data
{
    public class Context : DbContext
    {
        public Context() : base (GetOptions())
        {

        }


        private static DbContextOptions GetOptions()
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), "Data Source =SQL5105.site4now.net; Initial Catalog = db_a77dba_vahiculos; User Id = db_a77dba_vahiculos_admin; Password = Ernesto1199").Options;
        }

        public DbSet<MVehiculos> vehiculos { get; set; }






    }
}
