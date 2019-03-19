using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DW_Access;

namespace Airboard_API.Controllers
{
    public class TopDestinosController : ApiController
    {
        public IEnumerable<dwMapaTopDestinos> Get()
        {
            using (dwdashboardEntities entities = new dwdashboardEntities())
            {
                return entities.dwMapaTopDestinos.ToList();
            }
        }
    }
}
