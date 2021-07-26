using SistemaVehiculo.Data;
using SistemaVehiculo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVehiculo.Services
{
    public class ServiceVehiculos
    {
        Context db = new Context();

        public List<MVehiculos> listar()
        {
            var query = db.vehiculos.ToList();
            return query;
        } 



    }
}
