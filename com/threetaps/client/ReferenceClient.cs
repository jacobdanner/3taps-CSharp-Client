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
      HttpWebResponse response = (HttpWebResponse)this.executeGet("/reference/category");
      List<Category> responseList = new List<Category>() {};
      List<Category> resList = (List<Category>)JsonConvert.DeserializeObject(getResponseAsString(response), responseList.GetType());
      return resList;
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