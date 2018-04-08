using System.Collections.Generic;

namespace TunstallCareChatDataAccess.Models
{
     public class TemplateModel
     {
         public int TemplateId { get; set; }

        public TemplateModel Template { get; set; }

        public int DescriptionId { get; set; }
        
        public DescriptorModel DescriptionDescriptor { get; set; }

        public int VersionId { get; set; }
        
        public VersionModel Version { get; set; }

        public IEnumerable<ParameterModel> Parameters { get; set; }
        
        public IEnumerable<ConfigurationModel> Configurations { get; set; }

        public IEnumerable<TerminalModel> Terminals { get; set; }
        
     }
}