using System;
using System.Collections.Generic;

namespace TunstallCareChatDataAccess.Models
{
   public class ParameterCategoryModel
    {
        public int Id { get; set; }
        
        public int TitleId { get; set; }

        public DescriptorModel TitleDescriptor { get; set; }
        
        public ICollection<ParameterModel> Parameters { get; set; }
    }
}