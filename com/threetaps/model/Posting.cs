using System;
using System.Collections.Generic;

namespace com.threetaps.model
{
  public class Posting
  {
    public string postKey { get; set; }
    public string heading { get; set; }
    public string body { get; set; }
    public string category { get; set; }
    public string source { get; set; }
    public string location { get; set; }

    public float longitude { get; set; }
    public float latitude { get; set; }

    public string language { get; set; }

    public float price { get; set; }
    public string currency { get; set; }

    public string externalURL { get; set; }
    public string externalID { get; set; }
    public string accountName { get; set; }
    public string accountID { get; set; }

    public DateTime timestamp { get; set; }
    public DateTime expires { get; set; }
    public DateTime indexed { get; set; }

    public List<Dictionary<string, string>> errors { get; set; }

    public Dictionary<string, Object> annotations { get; set; }

    public bool exists { get; set; }
    public List<PostingHistory> history { get; set; }
    public string status { get; set; }
  }
}