using System;

namespace com.threetaps.model.annotations
{
  public class AnnotationOption
  {
    public String value { get; set; }
    public Annotation subAnnotation { get; set; }
  }
}