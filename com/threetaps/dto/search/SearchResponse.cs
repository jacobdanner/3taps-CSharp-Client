using System;
using System.Collections.Generic;
using com.threetaps.model;

namespace com.threetaps.dto.search
{
    public class SearchResponse
    {
        private bool success { get; set; }
        private int numResults { get; set; }
        private int execTimeMs { get; set; }
        private List<Posting> results { get; set; }
    }
}