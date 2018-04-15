using System;
using System.Collections.Generic;

namespace TunstallCareChatDataAccess.Models
{
     public class CentreModel
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public String IP { get; set; }

        public int? BackupId { get; set; }

        public ICollection<TerminalModel> Terminals { get; set; }
    }
}