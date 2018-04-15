using System.Collections.Generic;

namespace TunstallCareChatDataAccess.Models
{
     public class VersionModel
     {
         public int Id { get; set; }
        
         public string Number { get; set; }

         public ICollection<TemplateModel> Templates { get; set; }
     }
}