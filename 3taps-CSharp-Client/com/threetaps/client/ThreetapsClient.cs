using System;

namespace com.threetaps.client
{
    public class ThreetapsClient
    {
        private static ThreetapsClient instance;

        public static readonly String AUTH_ID_KEY = "authID";
        private String authID;

        protected ReferenceClient referenceClient { get; private set; }
        protected PostingClient postingClient { get; private set; }
        protected SearchClient searchClient { get; private set; }
        protected GeocoderClient geocoderClient { get; private set; }
        protected StatusClient statusClient { get; private set; }

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