namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TunstallCareChatDataAccess.Models;

    public class ProgrammationMap : IEntityTypeConfiguration<ProgrammationModel>
    {
        public void Configure(EntityTypeBuilder<ProgrammationModel> builder)
        {
            builder.ToTable("TCC_Programmations", "Admin");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Value).HasMaxLength(254);
        }
    }
}