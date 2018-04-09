namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TunstallCareChatDataAccess.Models;

    [Table("TCC_TemplateParameters", Schema = "Admin")]
    public class TemplateParameter: IEntityTypeConfiguration<TemplateModel>
    {
        public int ParameterId { get; set; }

        public int TemplateId { get; set; }

        [StringLength(254)]
        public string Value { get; set; }

        public virtual ConfigurationTemplateMap ConfigurationTemplate { get; set; }

        public virtual Parameter Parameter { get; set; }

        public void Configure(EntityTypeBuilder<TemplateModel> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}