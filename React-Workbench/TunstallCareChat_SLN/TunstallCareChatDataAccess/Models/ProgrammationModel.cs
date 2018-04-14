using System.Collections.Generic;

namespace TunstallCareChatDataAccess.Models
{
    public class ProgrammationModel
    {
        public int Id { get; set; }

        public int ParameterId { get; set; }
        
        public ParameterModel Parameter { get; set; }

        public int TerminalId { get; set; }
        
        public TerminalModel Terminal { get; set; }

        public string Value { get; set; }

        public int ProgramOrderId { get; set; }
        
        public ProgramOrderModel ProgramOrder { get; set; }
    }
}