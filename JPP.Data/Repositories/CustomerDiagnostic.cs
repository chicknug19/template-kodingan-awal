using Dapper;
using JPP.Data.DataAccess;
using JPP.Data.Interfaces;
using JPP.Models.Customer.Responses;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JPP.Data.Repositories
{
    public class CustomerDiagnosticRepository : ICustomerDiagnosticRepository
    {
        private readonly ICrmDbConnectionFactory _crmDbConnectionFactory;

        public CustomerDiagnosticRepository(ICrmDbConnectionFactory crmDbConnectionFactory)
        {
            _crmDbConnectionFactory = crmDbConnectionFactory;
        }

        public async Task<List<CustomerDiagnosticDto>> GetCustomerDiagnosticAsync(int customerId, int eventId)
        {
            const string sql = @"
                SELECT 
                    Id,
                    CustomerId,
                    EventId,
                    Type,
                    Description,
                    LogDate
                FROM Customer_Diagnostic
                WHERE CustomerId = @CustomerId
                  AND (@EventId = 0 OR EventId = @EventId)
                ORDER BY LogDate DESC;";

            using var conn = _crmDbConnectionFactory.Create();

            var result = await conn.QueryAsync<CustomerDiagnosticDto>(
                sql,
                new
                {
                    CustomerId = customerId,
                    EventId = eventId
                });

            return result.ToList();
        }
    }
}