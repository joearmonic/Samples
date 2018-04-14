namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TunstallCareChatDataAccess.Models;

    [Table("TCC_Languages", Schema = "Admin")]
    public class Language : IEntityTypeConfiguration<LanguageModel>
    {
        public void Configure(EntityTypeBuilder<LanguageModel> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.LangCode)
            .HasMaxLength(2)
            .IsRequired(false)
            .IsUnicode(false);

        }
    }
}
