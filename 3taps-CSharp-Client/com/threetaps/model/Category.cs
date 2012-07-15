using System;
using System.Collections.Generic;
using com.threetaps.model.annotations;

namespace com.threetaps.model
{
    public class Category
    {
        private string group { get; set; }
        private string code { get; set; }
        private string category { get; set; }
        private List<Annotation> annotations { get; set; }
    }
}

