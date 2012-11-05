using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using com.threetaps.dto.posting;
using com.threetaps.model;

namespace com.threetaps.client
{
  public class PostingClient : Client
  {
    private static PostingClient instance;
    // TODO: synchronize this
    public static PostingClient getInstance()
    {
      if (instance == null)
        instance = new PostingClient();
      return instance;
    }

    private PostingClient()
    {
    }

    public Posting get(String postKey)
    {
      // TODO: should we urlencode postKey
      return (Posting) callAndConvert("/posting/get/" + postKey, new Posting().GetType());
    }

    public List<CreateResponse> create(List<Posting> postingsToCreate)
    {
      Dictionary<string, string> parameters = new Dictionary<string, string>();
      parameters.Add("postings", JsonConvert.SerializeObject(postingsToCreate, getClientJsonSerializerSettings()));
      return (List<CreateResponse>) callAndConvert("/posting/create", new List<CreateResponse>().GetType(), parameters);
    }

    /**
     * The update method differs a bit from our API protocol, as it's not very friendly for type-safe languages.
     * 
     * @param postingsToUpdate a list of posting objects to be updated. Each posting object must have a postKey. The other
     * fields of the posting are optional. Each included posting field will be used to override the values for that posting 
     * currently in 3taps.
     * @return  
     * @throws IOException
     */

    public UpdateResponse update(List<Posting> postingsToUpdate)
    {
      List<List<object>> updateParam = new List<List<object>>();
      foreach (Posting posting in postingsToUpdate)
      {
        List<object> postingList = new List<object>();

        //postingList.Add(posting.postKey);
        
        //posting.postKey = null;
        postingList.Add(posting);

        updateParam.Add(postingList);
      }

      Dictionary<string, string> parameters = new Dictionary<string, string>();
      parameters.Add("data", JsonConvert.SerializeObject(updateParam, getClientJsonSerializerSettings()));
      return (UpdateResponse) callAndConvert("/posting/update", new UpdateResponse().GetType(), parameters);
    }

    public DeleteResponse delete(List<String> postKeysToDelete)
    {
      Dictionary<string, string> parameters = new Dictionary<string, string>();
      parameters.Add("data", JsonConvert.SerializeObject(postKeysToDelete, getClientJsonSerializerSettings()));
      return (DeleteResponse) callAndConvert("/posting/delete", new DeleteResponse().GetType(), parameters);
    }
  }
}