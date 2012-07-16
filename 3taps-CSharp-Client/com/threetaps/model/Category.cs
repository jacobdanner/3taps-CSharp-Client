using System;
using System.Collections.Generic;
using com.threetaps.model.annotations;

namespace com.threetaps.model
{
    class Category
    {
        private string group;
        private string code;
        private string category;

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

