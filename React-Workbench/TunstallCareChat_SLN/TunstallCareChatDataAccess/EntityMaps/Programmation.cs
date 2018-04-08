namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TunstallCareChatDataAccess.Models;

    [Table("TCC_Programmations", Schema = "Admin")]
    public partial class Programmation
    {
        public int Id { get; set; }

        public int TerminalId { get; set; }

        public int ParameterId { get; set; }

        public int ProgramOrderId { get; set; }

        [StringLength(254)]
        public string Value { get; set; }

        public virtual Parameter Parameter { get; set; }

        public virtual ProgramOrder ProgramOrder { get; set; }

        public virtual TerminalModel Terminal { get; set; }
    }
}