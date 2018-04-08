using System.Collections.Generic;

namespace TunstallCareChatDataAccess.Models
{
     public class VersionModel
     {
         public int Id { get; set; }
        
         public string Version { get; set; }

         public ICollection<TerminalModel> Terminals { get; set; }
     }
}