using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.threetaps.client
{
    public class PostingClient
    {

        private static PostingClient instance;
        // TODO: synchronize this
        public static PostingClient getInstance()
        {
            if (instance == null)
                instance = new PostingClient();
            return instance;
        }
    }
}
