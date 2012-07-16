using System;

namespace com.threetaps.model
{
    public class Location
    {
        private string code { get; set; }
        private int countryRank { get; set; }
        private string country { get; set; }
        private int cityRank { get; set; }
        private string city { get; set; }
        private string stateCode { get; set; }
        private string stateName { get; set; }
        private bool hidden { get; set; }
        private float latitude { get; set; }
        private float longitude { get; set; }
    }
}