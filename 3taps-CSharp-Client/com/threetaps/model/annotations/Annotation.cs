using System;
using System.Collections.Generic;

namespace com.threetaps.model.annotations
{
	public class Annotation
	{
		private String name;
		private AnnotationJava.AnnotationType annotationType;
		private List<AnnotationOption> options;
		
		public String getName() {
			return name;
		}
		
		public void setName(String name) {
			this.name = name;
		}
		
		public AnnotationJava.AnnotationType getAnnotationType() {
			return annotationType;
		}
		
		public void setAnnotationType(AnnotationJava.AnnotationType annotationType) {
			this.annotationType = annotationType;
		}
		
		public List<AnnotationOption> getOptions() {
			return options;
		}
		
		public void setOptions(List<AnnotationOption> options) {
			this.options = options;
		}
	}
}

