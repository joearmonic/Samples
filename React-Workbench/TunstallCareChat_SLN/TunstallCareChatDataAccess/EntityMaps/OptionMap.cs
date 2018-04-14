namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TunstallCareChatDataAccess.Models;

    [Table("TCC_Options", Schema = "Admin")]
    public class OptionMap : IEntityTypeConfiguration<OptionModel>
    {
        public void Configure(EntityTypeBuilder<OptionModel> builder)
        {
            builder.HasKey(b => b.Id);
        }
    }
}