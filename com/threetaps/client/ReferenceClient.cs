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
      return  (List<Category>)JsonConvert.DeserializeObject(getResponseAsString(response), responseList.GetType());
    }

    public Category getCategory(String categoryCode)
    {
      HttpWebResponse response = (HttpWebResponse)this.executeGet("/reference/category/"+categoryCode);
      return (Category)JsonConvert.DeserializeObject(getResponseAsString(response), new Category().GetType());
    }

    public List<Location> getLocations()
    {
      HttpWebResponse response = (HttpWebResponse)this.executeGet("/reference/location");
      List<Location> responseList = new List<Location>() { };
      return (List<Location>)JsonConvert.DeserializeObject(getResponseAsString(response), new List<Location>().GetType());
    }

    public List<Source> getSources()
    {
      HttpWebResponse response = (HttpWebResponse)this.executeGet("/reference/source", null);
      return (List<Source>)JsonConvert.DeserializeObject(getResponseAsString(response), new List<Source>().GetType());
    }
  }
}