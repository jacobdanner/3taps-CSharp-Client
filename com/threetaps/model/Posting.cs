using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using com.threetaps.util;

namespace com.threetaps.model
{
  public class Posting
  {
    /*public string postKey { get; set; }
    public string heading { get; set; }
    public string body { get; set; }
    public string category { get; set; }
    public string source { get; set; }
    public string location { get; set; }

    public float? longitude { get; set; }
    public float? latitude { get; set; }

    public string language { get; set; }

    public float? price { get; set; }
    public string currency { get; set; }

    public string externalURL { get; set; }
    public string externalID { get; set; }
    public string accountName { get; set; }
    public string accountID { get; set; }

    [JsonConverter(typeof (ThreeTapsDateTimeConverter))]
    public DateTime timestamp { get; set; }

    [JsonConverter(typeof (ThreeTapsDateTimeConverter))]
    public DateTime expires { get; set; }

    [JsonConverter(typeof (ThreeTapsDateTimeConverter))]
    public DateTime indexed { get; set; }

    public List<Dictionary<string, string>> errors { get; set; }

    public Dictionary<string, Object> annotations { get; set; }

    public bool? exists { get; set; }
    public List<PostingHistory> history { get; set; }
    public string status { get; set; }
    */

    public string accountId { get; set; }
    public Dictionary<string, string> annotations { get; set; }
    public string body { get; set; }
    public string category { get; set; }
    public string categoryClass { get; set; }
    public string categoryClassName { get; set; }
    public string categoryName { get; set; }
    public string currency { get; set; }

    // TODO: date parsing
    //[JsonConverter(typeof(ThreeTapsDateTimeConverter))]
    //public DateTime expirationTimestamp { get; set; }
    public string expirationTimestamp { get; set; }
    
    public int flags { get; set; }
    public bool hasImage { get; set; }
    public string heading { get; set; } // title
    public string html { get; set; }
    public string id { get; set; }
    /**
     * This needs further testing, the JSON is
     * "images": [
     {
          "full": "http://images.craigslist.org/3n83k23N85L25Gf5M6cag0d8db9c0325d1933.jpg"
     },
     {
          "full": "http://images.craigslist.org/thumb/3n83k23N85L25Gf5M6cag0d8db9c0325d1933.jpg"
     },
     {
          "full": "http://images.craigslist.org/thumb/3K63Mb3Ha5L45Fa5H3cag7d182234cf0415a9.jpg"
     }
],
     */
    public Dictionary<string, string> images { get; set; }
    public bool immortal { get; set; }
    // TODO: date parsing
    //[JsonConverter(typeof(ThreeTapsDateTimeConverter))]
    //public DateTime indexed { get; set; }
    public string indexed { get; set; }
    
    public string language { get; set; }
    public Location location { get; set; }

    // TODO: date parsing
    //[JsonConverter(typeof(ThreeTapsDateTimeConverter))]
    //public DateTime postingTimestamp { get; set; }
    public string postingTimestamp { get; set; }
    
    public float? price { get; set; }
    public string source { get; set; }
    public string sourceId { get; set; }
    public string sourceUrl { get; set; }
      
      
    }

  public class ThreeTapsDateTimeConverter : IsoDateTimeConverter
  {
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
      String formattedDate = null;
      if (value is DateTime)
      {
        DateTime dateTime = (DateTime) value;
        formattedDate = dateTime.ToString(Constants.DATE_FORMAT);
      }
#if !PocketPC && !NET20
      else if (value is DateTimeOffset)
      {
        DateTimeOffset dateTimeOffset = (DateTimeOffset) value;
        formattedDate = dateTimeOffset.DateTime.ToString(Constants.DATE_FORMAT);
      }
#endif
      else
      {
        throw new Exception("Expected date object value.");
      }

      writer.WriteValue(formattedDate);
    }
  }
}