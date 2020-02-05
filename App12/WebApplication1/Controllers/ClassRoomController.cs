using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LibraryAccess;
using StudentAccessData;

namespace WebApplication1.Controllers
{
    public class ClassRoomController : ApiController
    {
        public IEnumerable<ClassRoom> Get()
        {
            using (FeedbackDatabaseEntities1 entities = new FeedbackDatabaseEntities1())
            {
                return entities.ClassRooms.ToList();
            }
        }
        public ClassRoom Get(string id)
        {
            using (FeedbackDatabaseEntities1 entities = new FeedbackDatabaseEntities1())
            {
                return entities.ClassRooms.FirstOrDefault(e => e.Id == id);
            }
        }

    }
}
