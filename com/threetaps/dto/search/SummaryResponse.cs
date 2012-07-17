using System;
using System.Collections.Generic;

namespace com.threetaps.dto.search
{
    public class SummaryResponse
    {
        private Dictionary<string, int> totals { get; set; }
        private int execTimeMs { get; set; }
    }
}