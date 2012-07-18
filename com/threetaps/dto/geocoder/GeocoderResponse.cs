using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.threetaps.dto.geocoder
{
  public class GeocoderResponse
  {
    public string code { get; set; }
    public float latitude { get; set; }
    public float longitude { get; set; }
  }
}