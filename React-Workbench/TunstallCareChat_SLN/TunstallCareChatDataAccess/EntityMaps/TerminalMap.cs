namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TunstallCareChatDataAccess.Models;

    [Table("TCC_Terminals", Schema = "Admin")]
    public class TerminalMap : IEntityTypeConfiguration<TerminalModel>
    {
        public void Configure(EntityTypeBuilder<TerminalModel> builder)
        {
            builder.Property(b => b.Number).HasMaxLength(14).IsRequired(true);
            builder.HasKey(b => b.Id);
        }
    }
}
