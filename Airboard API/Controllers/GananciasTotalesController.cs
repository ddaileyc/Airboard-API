using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DW_Access;

namespace Airboard_API.Controllers
{
    public class GananciasTotalesController : ApiController
    {
        public IEnumerable<dwGananciasTotales> Get()
        {
            using (dwdashboardEntities entities = new dwdashboardEntities())
            {
                return entities.dwGananciasTotales.ToList();
            }
        }
    }
}
