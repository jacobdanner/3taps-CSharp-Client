using System;
using System.Collections.Generic;
using com.threetaps.model;

namespace com.threetaps.dto.search
{
    class SearchResponse
    {
        private bool success;
        private int numResults;
        private int execTimeMs;
        private List<Posting> results;
    }
}
