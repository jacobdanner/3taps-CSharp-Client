using System;
using System.Collections.Generic;

namespace com.threetaps.dto.search
{
    class SummaryResponse
    {
        private Dictionary<string, int> totals { get; set; }
        private int execTimeMs { get; set; }
    }
}
