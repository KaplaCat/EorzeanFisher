using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EorzeanFisher.Services.Http
{
    public interface IHttpService
    {
        Task<object> GetDataAsync(string url);
    }
}
