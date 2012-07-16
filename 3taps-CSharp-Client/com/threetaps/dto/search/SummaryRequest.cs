using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.threetaps.dto.search
{
    public class SummaryRequest : IQueryRequest
    {
        private SearchRequest searchRequest { get; set; }
        private String dimension { get; set; }

        public Dictionary<string, string> getQueryParams()
        {
            const Dictionary<string, string> queryParams = searchRequest.getQueryParams();
            if (dimension != null)
            {
                queryParams.Add("dimension", dimension);
            }
            return queryParams;
        }
    }
}
