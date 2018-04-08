namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TCC_TemplateParameters", Schema = "Admin")]
    public partial class TemplateParameter
    {
        public int ParameterId { get; set; }

        public int TemplateId { get; set; }

        [StringLength(254)]
        public string Value { get; set; }

        public virtual ConfigurationTemplateMap ConfigurationTemplate { get; set; }

        public virtual Parameter Parameter { get; set; }
    }
}