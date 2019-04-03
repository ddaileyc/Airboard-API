using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DW_Access;

namespace Airboard_API.Controllers
{
    public class GananciasPerdidasController : ApiController
    {
        public IEnumerable<dwGananciasPerdidas> Get() { 
        using (dwdashboardEntities entities = new dwdashboardEntities())
            {
                return entities.dwGananciasPerdidas.ToList();
            }
        }
    }
}
