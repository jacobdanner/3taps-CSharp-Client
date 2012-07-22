using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using com.threetaps.dto.geocoder;

namespace com.threetaps.client
{
  public class GeocoderClient : Client
  {
    private static GeocoderClient instance;
    // TODO: synchronize this
    public static GeocoderClient getInstance()
    {
      if (instance == null)
        instance = new GeocoderClient();
      return instance;
    }

    public List<GeocoderResponse> geocode(List<GeocoderRequest> geocoderRequests)
    {
      Dictionary<string, string> parameters = new Dictionary<string, string>();
      JsonSerializerSettings set = new JsonSerializerSettings();
      set.NullValueHandling = NullValueHandling.Ignore;
      set.MissingMemberHandling = MissingMemberHandling.Ignore;
      set.Formatting = Formatting.None; 
      set.DefaultValueHandling = DefaultValueHandling.Ignore;//.IgnoreAndPopulate;
      

      parameters.Add("data", JsonConvert.SerializeObject(geocoderRequests, set));
      List<List<string>> responseList = (List<List<string>>)callAndConvert("/geocoder/geocode/",
                                                   new List<List<string>>().GetType(), 
                                                   parameters, skipEncode:true);
      List<GeocoderResponse> geocoderResponses = new List<GeocoderResponse>(responseList.Count);
      foreach(List<string> response in responseList)
      {
        if (response.Count >= 3)
        {
          GeocoderResponse resp = new GeocoderResponse();
          resp.code = response.ElementAt(0);
          resp.latitude = float.Parse(response.ElementAt(1));
          resp.longitude = float.Parse(response.ElementAt(2));
          geocoderResponses.Add(resp);
        }
      }
      return geocoderResponses;
    }
  }
}