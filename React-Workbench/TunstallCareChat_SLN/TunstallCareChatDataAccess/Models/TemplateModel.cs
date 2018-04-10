using System.Collections.Generic;

namespace TunstallCareChatDataAccess.Models
{
     public class TemplateModel
     {
         public int Id { get; set; }

        public int DescriptionId { get; set; }
        
        public DescriptorModel DescriptionDescriptor { get; set; }

        public int VersionId { get; set; }
        
        public VersionModel Version { get; set; }

        public IEnumerable<TemplateParameterModel> TemplateParameters { get; set; }
        
        public IEnumerable<ConfigurationModel> Configurations { get; set; }

        public IEnumerable<TerminalModel> Terminals { get; set; }
        
     }
}