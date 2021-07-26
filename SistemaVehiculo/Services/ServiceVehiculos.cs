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

        public List<MVehiculos> listar(string marca)
        {
            var query = db.vehiculos.Where(x => x.tipo == marca || marca == null || x.modelo == marca || x.modelo == null).ToList();
            return query;
        } 



    }
}
