using App12.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App12.Services
{
    class LibraryServices
    {
        public async Task<List<Detailstuff>> GetLibraryAsync()
        {
            RestClient<Detailstuff> restClient = new RestClient<Detailstuff>();
            var libraryList = await restClient.GetAsync1();
            return libraryList;
        }
    }
}
