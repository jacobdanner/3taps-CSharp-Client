using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
	private GeocoderClient(){}
		
    public List<GeocoderResponse> geocode(List<GeocoderRequest> geocoderRequests)
    {
      throw new NotImplementedException("Implement me");
    }
  }
}