using System;
using System.Collections.Generic;

namespace TunstallCareChatDataAccess.Models
{
   public class ParameterCategoryModel
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public IEnumerable<ParameterModel> Parameters { get; set; }
    }
}