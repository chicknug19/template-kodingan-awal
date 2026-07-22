using JPP.Data.Interfaces;
using JPP.Models.Customer.Responses;
using JPP.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JPP.Services.Services
{
    public class CustomerStoreDropdownService : ICustomerStoreDropdownService
    {
        private readonly ICustomerStoreDropdownRepository _storeRepo;

        public CustomerStoreDropdownService(ICustomerStoreDropdownRepository storeRepo)
        {
            _storeRepo = storeRepo;
        }

        public async Task<IEnumerable<CustomerStoreDropdownDto>> GetDropdownListAsync()
        {
            return await _storeRepo.GetAllStoresAsync();
        }
    }
}