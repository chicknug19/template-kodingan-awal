using JPP.Models.Customer.Request;
using JPP.Models.Shared.Requests;

namespace JPP.Commons.Extensions
{
    public static class CustomerListFilterRequestExtensions
    {
        private static readonly string[] AllowedSortColumns =
        {
            "CustomerID",
            "FullName",
            "Address1",
            "PhoneNumber"
        };

        public static void NormalizeFilter(this CustomerListFilterRequest filter)
        {
            ArgumentNullException.ThrowIfNull(filter);

            filter.StoreId = filter.StoreId <= 0 ? 0 : filter.StoreId;
            filter.EventId = filter.EventId <= 0 ? 0 : filter.EventId;

            filter.Keyword = filter.Keyword.NormalizeNullableText();

            filter.NormalizePagingAndSorting(
                defaultSortColumn: "FullName",
                defaultSortDirection: "ASC",
                allowedSortColumns: AllowedSortColumns,
                defaultPageSize: 20,
                maxPageSize: 100);
        }
    }
}