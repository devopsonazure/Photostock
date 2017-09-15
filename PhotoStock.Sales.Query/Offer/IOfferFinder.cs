using CQRS.Base.Query;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace PhotoStock.Sales.Query.Offer
{
  public interface IProductFinder
  {
    PaginatedResult<ProductDto> GetPage(OfferQuery query);
  }
}