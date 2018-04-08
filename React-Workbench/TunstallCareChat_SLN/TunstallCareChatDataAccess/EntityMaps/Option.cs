namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TCC_Options", Schema = "Admin")]
    public partial class Option
    {
        public int Id { get; set; }

        [Required]
        [StringLength(120)]
        public string Value { get; set; }

        public int NameId { get; set; }

        public int ParameterId { get; set; }

        public virtual Descriptor Descriptor { get; set; }

        public virtual Parameter Parameters { get; set; }
    }
}