using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.threetaps.dto.search;

namespace com.threetaps.client
{
  public class SearchClient : Client
  {
    private static SearchClient instance;
    // TODO: synchronize this
    public static SearchClient getInstance()
    {
      if (instance == null)
        instance = new SearchClient();
      return instance;
    }

    public SearchResponse search(SearchRequest searchRequest)
    {
      return (SearchResponse) callAndConvert("/search",
                                             new SearchResponse().GetType(),
                                             searchRequest.getQueryParams());
    }

    public RangeResponse range(RangeRequest rangeRequest)
    {
      return (RangeResponse) callAndConvert("/search",
                                            new RangeResponse().GetType(),
                                            rangeRequest.getQueryParams());
    }

    public SummaryResponse summary(SummaryRequest summaryRequest)
    {
      return (SummaryResponse) callAndConvert("/search",
                                              new SummaryResponse().GetType(),
                                              summaryRequest.getQueryParams());
    }

    public int count(SearchRequest searchRequest)
    {
      Dictionary<string, int> responseMap = (Dictionary<string, int>) callAndConvert("/search/count",
                                                                                     new Dictionary<string, int>().
                                                                                       GetType(),
                                                                                     searchRequest.getQueryParams());
      return responseMap["count"];
    }
  }
}