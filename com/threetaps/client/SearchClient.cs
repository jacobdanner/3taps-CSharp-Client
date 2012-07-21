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
	private SearchClient(){}
		
    public SearchResponse search(SearchRequest searchRequest)
    {
      throw new NotImplementedException("Implement me");
    }

    public RangeResponse range(RangeRequest rangeRequest)
    {
      throw new NotImplementedException("Implement me");
    }

    public SummaryResponse summary(SummaryRequest summaryRequest)
    {
      throw new NotImplementedException("Implement me");
    }

    public int count(SearchRequest searchRequest)
    {
      throw new NotImplementedException("Implement me");
    }
  }
}