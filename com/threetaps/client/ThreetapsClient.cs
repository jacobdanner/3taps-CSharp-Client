using System;

namespace com.threetaps.client
{
  public class ThreetapsClient
  {
    private static ThreetapsClient instance;

    public static readonly String AUTH_ID_KEY = "authID";
    private String authID;

    public ReferenceClient referenceClient { get; private set; }
    public PostingClient postingClient { get; private set; }
    public SearchClient searchClient { get; private set; }
    public GeocoderClient geocoderClient { get; private set; }
    public StatusClient statusClient { get; private set; }

    private ThreetapsClient()
    {
      referenceClient = ReferenceClient.getInstance();
      postingClient = PostingClient.getInstance();
      searchClient = SearchClient.getInstance();
      geocoderClient = GeocoderClient.getInstance();
      statusClient = StatusClient.getInstance();
    }

    public static ThreetapsClient getInstance()
    {
      if (instance == null) instance = new ThreetapsClient();
      return instance;
    }

    public String getAuthID()
    {
      return authID;
    }

    public ThreetapsClient setAuthID(String authID)
    {
      this.authID = authID;
      return this;
    }
  }
}