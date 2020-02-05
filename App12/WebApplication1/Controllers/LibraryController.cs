using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LibraryAccess;

namespace WebApplication1.Controllers
{
    public class LibraryController : ApiController
    { 
        public IEnumerable<Library> Get()
       {

            using (LibraryEntities entities = new LibraryEntities())
            {
                return entities.Libraries.ToList();
            }
        }
        public Library Get(string id)
        {
            using (LibraryEntities entities = new LibraryEntities())
            {
                return entities.Libraries.FirstOrDefault(e => e.Id == id);
            }
        }

    }
}
