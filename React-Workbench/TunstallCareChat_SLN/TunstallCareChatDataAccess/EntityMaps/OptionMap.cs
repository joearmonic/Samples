namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TunstallCareChatDataAccess.Models;

    [Table("TCC_Options", Schema = "Admin")]
    public class Option : IEntityTypeConfiguration<OptionModel>
    {
        public int Id { get; set; }

        [Required]
        [StringLength(120)]
        public string Value { get; set; }

        public int NameId { get; set; }

        public int ParameterId { get; set; }

        public virtual Descriptor Descriptor { get; set; }

        public virtual ParameterMap Parameters { get; set; }

        public void Configure(EntityTypeBuilder<OptionModel> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}