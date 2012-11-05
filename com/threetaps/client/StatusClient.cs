using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using com.threetaps.model;
using System.Net;

namespace com.threetaps.client
{
  public class StatusClient : Client
  {
    private static StatusClient instance;
    // TODO: synchronize this
    public static StatusClient getInstance()
    {
      if (instance == null)
        instance = new StatusClient();
      return instance;
    }

    private StatusClient()
    {
    }

    public Message update(List<Posting> postingsToUpdate)
    {
      Dictionary<string, string> parameters = new Dictionary<string, string>();

      parameters.Add("postings", JsonConvert.SerializeObject(postingsToUpdate, getClientJsonSerializerSettings()));
      return (Message) callAndConvert("/status/update",
                                      new Message().GetType(),
                                      parameters);
    }

    public List<Posting> get(List<Posting> postingsToCheck)
    {
      Dictionary<string, string> parameters = new Dictionary<string, string>();

      parameters.Add("postings", JsonConvert.SerializeObject(postingsToCheck, getClientJsonSerializerSettings()));
      return (List<Posting>) callAndConvert("/status/get",
                                            new List<Posting>().GetType(),
                                            parameters);
    }

    public Message system()
    {
      return (Message) callAndConvert("/status/system", new Message().GetType());
    }
  }
}