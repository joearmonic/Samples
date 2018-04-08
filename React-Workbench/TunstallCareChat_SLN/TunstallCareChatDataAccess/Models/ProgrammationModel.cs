namespace TunstallCareChatDataAccess.Models
{
    public class ProgrammationModel
    {
        public int Id { get; set; }

        public ParameterModel Parameter { get; set; }

public TerminalModel Terminal { get; set; }

public int TerminalId { get; set; }

        public string Value { get; set; }
    }
}