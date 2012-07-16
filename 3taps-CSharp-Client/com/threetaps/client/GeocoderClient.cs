using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.threetaps.client
{
    public class GeocoderClient : Client
    {
        private static GeocoderClient instance;
        // TODO: synchronize this
        public static GeocoderClient getInstance() {
            if (instance == null) 
                instance = new GeocoderClient();
            return instance;
        }
    }
}
