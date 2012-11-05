using System;

namespace com.threetaps.model
{
  /**
   * "location": {
     "latitude": 42.33143,
     "longitude": -83.04575,
     "accuracy": 4,
     "countryCode": "USA",
     "regionCode": "USA-DET-WAY",
     "stateCode": "USA-MI",
     "metroCode": "CAN-YQG",
     "countyCode": "USA-MI-WAY",
     "cityCode": "USA-DET-DET",
     "localityCode": "USA-DET-DOW",
     "zipCode": "USA-48226"
  }*/
  public class Location
  {
    public float latitude { get; set; }

    public float longitude { get; set; }
    public int accuracy { get; set; }
    public string countryCode { get; set; }
    public string regionCode { get; set; }
    public string stateCode { get; set; }
    public string metroCode { get; set; }
    public string countyCode { get; set; }
    public string cityCode { get; set; }
    public string localityCode { get; set; }
    public string zipCode { get; set; }

    /* old version
     * public string code { get; set; }
    public int countryRank { get; set; }
    public string country { get; set; }
    public int cityRank { get; set; }
    public string city { get; set; }
    public string stateCode { get; set; }
    public string stateName { get; set; }
    public bool hidden { get; set; }
    public float latitude { get; set; }
    public float longitude { get; set; }
     **/

  }
}