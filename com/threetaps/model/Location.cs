using System;

namespace com.threetaps.model
{
  public class Location
  {
    public string code { get; set; }
    public int countryRank { get; set; }
    public string country { get; set; }
    public int cityRank { get; set; }
    public string city { get; set; }
    public string stateCode { get; set; }
    public string stateName { get; set; }
    public bool hidden { get; set; }
    public float latitude { get; set; }
    public float longitude { get; set; }
  }
}