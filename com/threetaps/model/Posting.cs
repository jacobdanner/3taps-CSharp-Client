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
    public string postKey { get; set; }
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

    [JsonConverter(typeof(ThreeTapsDateTimeConverter))]
    public DateTime timestamp { get; set; }
    [JsonConverter(typeof(ThreeTapsDateTimeConverter))]
    public DateTime expires { get; set; }
    [JsonConverter(typeof(ThreeTapsDateTimeConverter))]
    public DateTime indexed { get; set; }

    public List<Dictionary<string, string>> errors { get; set; }

    public Dictionary<string, Object> annotations { get; set; }

    public bool? exists { get; set; }
    public List<PostingHistory> history { get; set; }
    public string status { get; set; }

  }

  public class ThreeTapsDateTimeConverter : IsoDateTimeConverter  
  {
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
      String formattedDate = null;
      if (value is DateTime)
      {
        DateTime dateTime = (DateTime)value;
        formattedDate = dateTime.ToString(Constants.DATE_FORMAT);
      }
#if !PocketPC && !NET20
      else if (value is DateTimeOffset)
      {
        DateTimeOffset dateTimeOffset = (DateTimeOffset)value;
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