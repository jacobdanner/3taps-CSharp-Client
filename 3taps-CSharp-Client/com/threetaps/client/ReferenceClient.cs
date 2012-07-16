using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.threetaps.client
{
    public class ReferenceClient
    {
        private static ReferenceClient instance;
        // TODO: synchronize this
        public static ReferenceClient getInstance()
        {
            if (instance == null)
                instance = new ReferenceClient();
            return instance;
        }
    }
}
