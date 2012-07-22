using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using com.threetaps.util;

namespace com.threetaps.client
{
  public class Client
  {
    private const String DEFAULT_URL = Constants.DEFAULT_API_URL;
    private const int DEFAULT_PORT = Constants.DEFAULT_API_PORT;

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

    protected WebResponse executeGet(string endpoint, Dictionary<string, string> parameters)
    {
      HttpWebRequest req =
        (HttpWebRequest) WebRequest.Create(this.baseURL + endpoint +
                                           "?" +
                                           createEncodedString(parameters));
      req.Method = "GET";
      return req.GetResponse(); 
    }

    protected WebResponse executePost(string endpoint, Dictionary<string, string> parameters)
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

    private String createEncodedString(Dictionary<string, string> parameters)
    {
      StringBuilder sb = new StringBuilder();
      if (parameters != null && parameters.Any())
      {
        foreach (KeyValuePair<string, string> entry in parameters)
        {
          sb.Append(entry.Key).Append("=").Append(HttpUtility.UrlEncode(entry.Value)).Append("&");
        }
      }
      sb.Append(ThreetapsClient.AUTH_ID_KEY).Append(ThreetapsClient.getInstance().getAuthID());
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
  }
}