using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using Newtonsoft.Json;
using com.threetaps.util;

namespace com.threetaps.client
{
  public class Client
  {

    
    private static readonly string DEFAULT_URL = Constants.DEFAULT_API_URL;
    private static readonly int DEFAULT_PORT = Constants.DEFAULT_API_PORT;

    protected string baseURL;
    protected int port;

    protected Client() : this(Client.DEFAULT_URL, Client.DEFAULT_PORT)
    {
    }

    protected Client(String url, int port)
    {
      this.baseURL = url;
      this.port = port;
    }

    // TODO: would these methods be better suited to use/exapnd 
    // with WebClient
    // TODO: what about async features
    // TODO: add tests to verify behavior
    // TODO: handle exceptions
    // TODO: investigate response values to JSON and then clean up connections
    protected WebResponse execute(WebRequest request)
    {
      return request.GetResponse();
    }

    protected WebResponse executeGet(string endpoint)
    {
      return executeGet(endpoint, null);
    }

    protected WebResponse executeGet(string endpoint, Dictionary<string, string> parameters, bool skipEncode = false)
    {
      HttpWebRequest req =
        (HttpWebRequest) WebRequest.Create(this.baseURL + endpoint +
                                           "?" +
                                           createEncodedString(parameters));
      req.Method = "GET";
      return req.GetResponse();
    }

    protected WebResponse executePost(string endpoint, Dictionary<string, string> parameters, bool skipEncode = false)
    {
      HttpWebRequest req =
        (HttpWebRequest) WebRequest.Create(this.baseURL + endpoint);
      req.Method = "POST";
      string postData = createEncodedString(parameters);
      byte[] byteArray = Encoding.UTF8.GetBytes(postData);
      req.ContentType = "application/x-www-form-urlencoded";
      req.ContentLength = byteArray.Length;

      using (Stream newStream = req.GetRequestStream())
      {
        newStream.Write(byteArray, 0, byteArray.Length);
      }
      return req.GetResponse();
    }

    private string createEncodedString(Dictionary<string, string> parameters, bool skipEncode=false)
    {
      StringBuilder sb = new StringBuilder();
      if (parameters != null && parameters.Any())
      {
        foreach (KeyValuePair<string, string> entry in parameters)
        {
          if (skipEncode)
          {
            sb.Append(entry.Key).Append("=").Append(entry.Value).Append("&");
          }
          else
          {
            sb.Append(entry.Key).Append("=").Append(HttpUtility.UrlEncode(entry.Value)).Append("&");
          }
        }
      }
      sb.Append(ThreetapsClient.AUTH_ID_KEY).Append("=").Append(ThreetapsClient.getInstance().getAuthID());
      Console.WriteLine(sb.ToString());
      return sb.ToString();
    }
  


    protected String getResponseAsString(WebResponse resp)
    {
      StringBuilder sb = new StringBuilder();
      using (StreamReader r = new StreamReader(resp.GetResponseStream()))
      {
        sb.Append(r.ReadToEnd());
      }
      Console.WriteLine(sb.ToString());
      return sb.ToString();
    }

    protected Object callAndConvert(String urlPath, Type expectedType)
    {
      HttpWebResponse response = (HttpWebResponse) this.executeGet(urlPath);
      return JsonConvert.DeserializeObject(getResponseAsString(response), expectedType);
    }
    protected Object callAndConvert(String urlPath, Type expectedType, Dictionary<string, string> parameters, bool skipEncode = false)
    {
      HttpWebResponse response = (HttpWebResponse)this.executeGet(urlPath, parameters, skipEncode);
      return JsonConvert.DeserializeObject(getResponseAsString(response), expectedType);
    }
  }

}