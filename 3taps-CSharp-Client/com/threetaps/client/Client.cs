using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.threetaps.util;

namespace com.threetaps.client
{
  public class Client
  {
      private static readonly String DEFAULT_URL = Constants.DEFAULT_API_URL;
      private static readonly int DEFAULT_PORT = Constants.DEFAULT_API_PORT;

      protected String baseURL;
      protected int port;

      protected Client() : this(Client.DEFAULT_URL, Client.DEFAULT_PORT)
      {
      }
  
      protected Client(String url, int port)
      {
          this.baseURL = url;
          this.port = port;
      }
  }
}
