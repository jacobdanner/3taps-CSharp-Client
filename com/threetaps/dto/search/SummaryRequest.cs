using System;
using System.Collections.Generic;

namespace com.threetaps.dto.search
{
  public class SummaryRequest : IQueryRequest
  {
    public SearchRequest searchRequest { get; set; }
    public String dimension { get; set; }

    public Dictionary<string, string> getQueryParams()
    {
      Dictionary<string, string> queryParams = searchRequest.getQueryParams();
      if (dimension != null)
      {
        queryParams["dimension"] = dimension;
      }
      return queryParams;
    }
  }
}