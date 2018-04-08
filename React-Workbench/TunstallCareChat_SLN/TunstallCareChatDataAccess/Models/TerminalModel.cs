using System.Collections.Generic;

namespace TunstallCareChatDataAccess.Models
{
     public class TerminalModel
    {
        public int Id { get; set; }
        
        public string Number { get; set; }
        
        public int? TemplateId { get; set; }

        public TemplateModel Template { get; set; }
        
        public int? CentreId { get; set; }

        public CentreModel ControlCentre { get; set; }

        public int VersionId { get; set; }
        
        public VersionModel Version { get; set; }
       
        public ICollection<ConfigurationModel> Configurations { get; set; }
        
        public TemplateModel ConfigurationTemplate { get; set; }

        public ICollection<ProgrammationModel> Programmations { get; set; }

        public ICollection<ProgramOrderModel> ProgramOrders { get; set; }
    }
}