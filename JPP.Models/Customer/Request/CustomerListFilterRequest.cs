using JPP.Models.Shared.Requests;

namespace JPP.Models.Customer.Request
{
    public class CustomerListFilterRequest : PaginationRequest
    {
        public string? Keyword { get; set; }

        public int? StoreId { get; set; } = 0;
        public int? EventId { get; set; } = 0;

    }
}