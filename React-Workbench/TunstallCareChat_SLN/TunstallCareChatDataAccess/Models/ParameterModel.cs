using System;

namespace TunstallCareChatDataAccess.Models
{
    /// <summary>
    /// Defines a parameter for programming a Mobile Phone with TCC installed.  
    /// TODO: When refactor the UI generation, don't forget the decorator Pattern.
    /// </summary>
    public class ParameterModel
    {
        public int Id { get; set; }
        public String Key { get; set; }
        public String Name { get; set; }
        public String Summary { get; set; }
        public int MaxLength { get; set; }
        public int Priority { get; set; }
        public String UIType { get; set; }
        public ParameterCategoryModel Category { get; set; }

        public TemplateModel Template { get; set; }

        public int TemplateId { get; set; }
        
    }
}