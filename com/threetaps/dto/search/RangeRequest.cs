using System;
using System.Collections.Generic;
using com.threetaps.util;

namespace com.threetaps.dto.search
{
  public class RangeRequest : IQueryRequest
  {
    public RangeRequest()
    {
      this.fields = new List<string>();
    }

    public SearchRequest searchRequest { get; set; }
    public List<string> fields { get; set; }

    public void addField(string field)
    {
      fields.Add(field);
    }

    public Dictionary<string, string> getQueryParams()
    {
      Dictionary<string, string> queryParams = searchRequest.getQueryParams();
      queryParams["fields"] = Utils.Join(fields);

      return queryParams;
    }
  }
}