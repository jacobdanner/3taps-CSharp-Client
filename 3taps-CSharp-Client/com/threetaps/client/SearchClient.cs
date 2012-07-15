using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.threetaps.client
{
    public class SearchClient
    {
        private static SearchClient instance;
        // TODO: synchronize this
        public static SearchClient getInstance()
        {
            if (instance == null)
                instance = new SearchClient();
            return instance;
        }
    }
}
