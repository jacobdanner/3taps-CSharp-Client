using System;
using System.Collections.Generic;
using com.threetaps.model.annotations;

namespace com.threetaps.model
{
  /*
   * {
          "categoryClassName": "Animals",
          "categoryClass": "AAAA",
          "categories": [
               {
                    "category": "APET",
                    "categoryName": "Pets"
               },
               {
                    "category": "ASUP",
                    "categoryName": "Supplies"
               },
               {
                    "category": "AOTH",
                    "categoryName": "Other"
               }
          ]
     }*/


  public class Category
  {
    public string categoryClassName { get; set; }
    public string categoryClass { get; set; }
    public List<SubCategory> categories { get; set; }

    public class SubCategory
    {
      public string category { get; set; }
      public string categoryName { get; set; }
    }
  }


}