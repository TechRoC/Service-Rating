using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using App12.DataClasses;
using App12.Service;

namespace App12.Services
{
    public class ClassRoomServices
    {
        public async Task<List<Detailstuff>> GetClassRoomAsync()
        {
            RestClient<Detailstuff> restClient = new RestClient<Detailstuff>();
            var classRoomList = await restClient.GetAsync();
            return classRoomList;
        }
    }
}
