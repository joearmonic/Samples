using System;
using System.Collections.Generic;

namespace TunstallCareChatDataAccess.Models
{
    /// <summary>
    /// Defines a parameter for programming a Mobile Phone with TCC installed.  
    /// TODO: When refactor the UI generation, don't forget the decorator Pattern.
    /// </summary>
    public class ParameterModel
    {
        public int Id { get; set; }

        public int DescriptionId { get; set; }

        public DescriptorModel DescriptionDescriptor { get; set; }
        
        public int? UITypeId { get; set; }
        
        public UITypeModel UIType { get; set; }
        
        public int CategoryId { get; set; }

        public ParameterCategoryModel ParameterCategory { get; set; }
        
        public int TitleId { get; set; }

        public DescriptorModel TitleDescriptor { get; set; }

        public byte Priority { get; set; }

        public short MobileKey { get; set; }

        public short Length { get; set; }

        public ICollection<OptionModel> Options { get; set; }

        public ICollection<ProgrammationModel> Programmations { get; set; }
        
        public ICollection<TemplateParameterModel> TemplateParameters { get; set; }
    }
}