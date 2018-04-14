using System.Collections.Generic;

namespace TunstallCareChatDataAccess.Models
{
     public class UITypeModel
     {
         public int Id { get; set; }

         public string ReflectionType { get; set; }

         public string ValueType { get; set; }
 
        public ICollection<ParameterModel> Parameters { get; set; }           
     }
}