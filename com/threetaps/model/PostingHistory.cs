using System;
using System.Collections.Generic;

namespace com.threetaps.model
{
    public class PostingHistory
    {
        private DateTime timestamp { get; set; }
        private List<Message> errors { get; set; }
        private Dictionary<String, Object> attributes { get; set; }
    }
}