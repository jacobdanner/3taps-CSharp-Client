using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.threetaps.model;

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

    public Message update(List<Posting> postingsToUpdate)
    {
      throw new NotImplementedException("Implement me");
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