using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.threetaps.client
{
    public class StatusClient
    {
        private static StatusClient instance;
        // TODO: synchronize this
        public static StatusClient getInstance()
        {
            if (instance == null)
                instance = new StatusClient();
            return instance;
        }
    }
}
