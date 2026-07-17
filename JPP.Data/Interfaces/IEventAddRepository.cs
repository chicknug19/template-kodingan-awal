using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JPP.Models.Customer.Request;

namespace JPP.Data.Interfaces
{
    public interface IEventAddRepository
    {
        Task<bool> CodeExistsAsync(string code);
        Task<int> CreateEventAsync(EventRequest request);
    }
}
