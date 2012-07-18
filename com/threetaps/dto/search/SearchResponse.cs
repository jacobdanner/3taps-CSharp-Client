using System;
using System.Collections.Generic;
using com.threetaps.model;

namespace com.threetaps.dto.search
{
  public class SearchResponse
  {
    public bool success { get; set; }
    public int numResults { get; set; }
    public int execTimeMs { get; set; }
    public List<Posting> results { get; set; }
  }
}