namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TunstallCareChatDataAccess.Models;

    [Table("TCC_Programmations", Schema = "Admin")]
    public class ProgrammationMap : IEntityTypeConfiguration<ProgrammationModel>
    {
        public void Configure(EntityTypeBuilder<ProgrammationModel> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Value).HasMaxLength(254);
        }
    }
}