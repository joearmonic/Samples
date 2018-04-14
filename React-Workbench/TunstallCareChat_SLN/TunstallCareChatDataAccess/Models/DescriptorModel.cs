using System.Collections.Generic;

namespace TunstallCareChatDataAccess.Models
{
     public class DescriptorModel
     {
        public int Id { get; set; }

        public string Meta { get; set; }

        public ICollection<TemplateModel> ConfigurationTemplates { get; set; }

        public ICollection<OptionModel> Options { get; set; }

        public ICollection<ParameterCategoryModel> ParameterCategories { get; set; }
       
        public ICollection<ParameterModel> ParametersOfTitles { get; set; }

        public ICollection<ParameterModel> ParametersOfDescriptions { get; set; }
       
        public ICollection<TranslationModel> Translations { get; set; }
    }
}