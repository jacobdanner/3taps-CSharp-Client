using System;
using System.Collections.Generic;

namespace com.threetaps.dto.search
{
  public class SummaryResponse
  {
    public Dictionary<string, int> totals { get; set; }
    public int execTimeMs { get; set; }
  }
}