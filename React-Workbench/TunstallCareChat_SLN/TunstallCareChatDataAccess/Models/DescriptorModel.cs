using System.Collections.Generic;

namespace TunstallCareChatDataAccess.Models
{
     public class DescriptorModel
     {
        public int Id { get; set; }

        public string Meta { get; set; }

        public IEnumerable<TemplateModel> ConfigurationTemplates { get; set; }

        public IEnumerable<OptionModel> Options { get; set; }

        public IEnumerable<ParameterCategoryModel> ParameterCategories { get; set; }

       
        public IEnumerable<ParameterModel> Parameters { get; set; }

       
        public virtual IEnumerable<ParameterModel> Parameters1 { get; set; }

       
        public virtual IEnumerable<LocaleModel> Locales { get; set; }
    }
}