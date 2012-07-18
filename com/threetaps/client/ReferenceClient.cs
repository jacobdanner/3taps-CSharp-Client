using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.threetaps.model;

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

    public List<Category> getCategories()
    {
      throw new NotImplementedException("Implement me");
    }

    public Category getCategory(String categoryCode)
    {
      throw new NotImplementedException("Implement me");
    }

    public List<Location> getLocations()
    {
      throw new NotImplementedException("Implement me");
    }

    public List<Source> getSources()
    {
      throw new NotImplementedException("Implement me");
    }
  }
}