using JPP.Models.Customer.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JPP.Services.Interfaces
{
    public interface ICustomerStoreDropdownService
    {
        Task<IEnumerable<CustomerStoreDropdownDto>> GetDropdownListAsync();
    }
}