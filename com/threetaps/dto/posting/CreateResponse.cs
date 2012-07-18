using System;
using com.threetaps.model;

namespace com.threetaps.dto.posting
{
  public class CreateResponse
  {
    public string postKey { get; set; }
    public Message error { get; set; }
  }
}