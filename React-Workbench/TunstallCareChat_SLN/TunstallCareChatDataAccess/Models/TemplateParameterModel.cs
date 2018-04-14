namespace TunstallCareChatDataAccess.Models
{
    public class TemplateParameterModel
    {
        public int ParameterId { get; set; }

        public ParameterModel Parameter { get; set; }
        
        public int TemplateId { get; set; }

        public TemplateModel Template { get; set; }
        
        public string Value { get; set; }
    }
}