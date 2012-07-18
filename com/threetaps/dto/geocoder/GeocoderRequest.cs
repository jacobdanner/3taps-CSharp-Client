using System;

namespace com.threetaps.dto.geocoder
{
  public class GeocoderRequest
  {
    public float latitude { get; set; }
    public float longitude { get; set; }
    public string country { get; set; }
    public string state { get; set; }
    public string city { get; set; }
    public string locality { get; set; }
    public string postal { get; set; }
    public string text { get; set; }
  }
}