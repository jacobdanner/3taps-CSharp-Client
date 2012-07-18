using System;
using System.Collections.Generic;

namespace com.threetaps.model
{
  public class PostingHistory
  {
    public DateTime timestamp { get; set; }
    public List<Message> errors { get; set; }
    public Dictionary<String, Object> attributes { get; set; }
  }
}