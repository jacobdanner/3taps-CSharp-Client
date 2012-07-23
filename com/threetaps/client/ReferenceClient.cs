using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using com.threetaps.model;

namespace com.threetaps.client
{
  public class ReferenceClient : Client
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
      return (List<Category>) callAndConvert("/reference/category",
                                             new List<Category>().GetType());
    }

    public Category getCategory(String categoryCode)
    {
      // TODO: should we urlencode postKey
      List<Category> catList = (List<Category>) callAndConvert("/reference/category/" + categoryCode,
                                                               new List<Category>().GetType());
      return catList.Any() ? catList.First() : null;
    }

    public List<Location> getLocations()
    {
      return (List<Location>) callAndConvert("/reference/location",
                                             new List<Location>().GetType());
    }

    public List<Source> getSources()
    {
      return (List<Source>) callAndConvert("/reference/source",
                                           new List<Source>().GetType());
    }
  }
}