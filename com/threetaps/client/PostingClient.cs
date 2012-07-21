using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
	private PostingClient(){}

    public Posting get(String postKey)
    {
      throw new NotImplementedException("Implement me");
    }

    public List<CreateResponse> create(List<Posting> postingsToCreate)
    {
      throw new NotImplementedException("Implement me");
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
      throw new NotImplementedException("Implement me");
    }

    public DeleteResponse delete(List<String> postKeysToDelete)
    {
      throw new NotImplementedException("Implement me");
    }
  }
}