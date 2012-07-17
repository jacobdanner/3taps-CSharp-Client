using System;
using System.Collections.Generic;

namespace com.threetaps.dto.search
{
    public class RangeResponse
    {
        public Dictionary<string, Range> ranges { get; set; }


        public class Range
        {
            public int min { get; set; }
            public int max { get; set; }
        }
    }
}