using System.Collections.Generic;

namespace TunstallCareChatDataAccess.Models
{
    public class ConfigurationModel
    {
        public int TemplateId { get; set; }

        public int TerminalId { get; set; }

        public int ParameterId { get; set; }

        public string Value { get; set; }

        public TemplateModel ConfigurationTemplate { get; set; }

        public TerminalModel Terminal { get; set; }
    }
}