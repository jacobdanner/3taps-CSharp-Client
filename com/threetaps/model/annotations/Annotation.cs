using System;
using System.Collections.Generic;

namespace com.threetaps.model.annotations
{
  public class Annotation
  {
    public String name { get; set; }
    public AnnotationType annotationType { get; set; }
    public List<AnnotationOption> options { get; set; }
  }
}