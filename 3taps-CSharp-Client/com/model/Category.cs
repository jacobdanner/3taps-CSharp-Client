using System;

namespace ThreeTaps
{
	public class Category
	{
		private String group;
		private String code;
		private String category;

		private List<Annotation> annotations;

		public String getGroup() {
			return group;
		}

		public void setGroup(String group) {
			this.group = group;
		}

		public String getCategory() {
			return category;
		}
		
		public void setCategory(String category) {
			this.category = category;
		}

		public String getCode() {
			return code;
		}

		public void setCode(String code) {
			this.code = code;
		}

		public List<Annotation> getAnnotations() {
			return annotations;
		}

		public void setAnnotations(List<Annotation> annotations) {
			this.annotations = annotations;
		}
	}
}

