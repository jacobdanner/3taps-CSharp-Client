using System;
using System.Collections.Generic;

namespace com.threetaps.model
{
  public class Posting
  {
    private string postKey { get; set; }
    private string heading { get; set; }
    private string body { get; set; }
    private string category { get; set; }
    private string source { get; set; }
    private string location { get; set; }

    private float longitude { get; set; }
    private float latitude { get; set; }

    private string language { get; set; }

    private float price { get; set; }
    private string currency { get; set; }

    private string externalURL { get; set; }
    private string externalID { get; set; }
    private string accountName { get; set; }
    private string accountID { get; set; }

    private DateTime timestamp { get; set; }
    private DateTime expires { get; set; }
    private DateTime indexed { get; set; }

    private List<Dictionary<string, string>> errors { get; set; }

    private Dictionary<string, Object> annotations { get; set; }

    private bool exists { get; set; }
    private List<PostingHistory> history { get; set; }
    private string status { get; set; }
  }
}