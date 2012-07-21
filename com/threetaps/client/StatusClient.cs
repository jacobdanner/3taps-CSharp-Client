using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.threetaps.model;
using Newtonsoft.Json;
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
	
	private StatusClient(){}

    public Message update(List<Posting> postingsToUpdate)
    {
     		
		Dictionary<string, string> parameters = new Dictionary<string, string>();
		parameters["postings"] = JsonConvert.SerializeObject(postingsToUpdate);
		
		WebResponse response = this.executeGet("/status/update", parameters);
		string responseString = this.getResponseAsString(response);
		
		return (Message)JsonConvert.DeserializeObject(responseString, new Message().GetType());
    }

    public List<Posting> get(List<Posting> postingsToCheck)
    {
      throw new NotImplementedException("Implement me");
    }

    public Message system()
    {
      throw new NotImplementedException("Implement me");
    }
  }
}