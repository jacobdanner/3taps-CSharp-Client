using System;
using System.Collections.Generic;

namespace com.threetaps.model.annotations
{
    public class Annotation
    {
        private String name { get; set; }
        private AnnotationType annotationType { get; set; }
        private List<AnnotationOption> options { get; set; }
        
    }
}

