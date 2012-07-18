using System;
using System.Collections.Generic;
using com.threetaps.model.annotations;

namespace com.threetaps.model
{
  public class Category
  {
    public string group { get; set; }
    public string code { get; set; }
    public string category { get; set; }
    public List<Annotation> annotations { get; set; }
  }
}