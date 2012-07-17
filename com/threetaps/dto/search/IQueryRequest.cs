using System;
using System.Collections.Generic;

namespace com.threetaps.dto.search
{
    public interface IQueryRequest
    {
        Dictionary<string, string> getQueryParams();
    }
}