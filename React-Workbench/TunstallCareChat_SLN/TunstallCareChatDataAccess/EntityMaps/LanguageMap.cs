namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TunstallCareChatDataAccess.Models;

    public class LanguageMap : IEntityTypeConfiguration<LanguageModel>
    {
        public void Configure(EntityTypeBuilder<LanguageModel> builder)
        {
            builder.ToTable("TCC_Languages", "Admin");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.LangCode)
            .HasMaxLength(2)
            .IsRequired(false)
            .IsUnicode(false);

            builder
               .Property(e => e.LangCode)
               .HasMaxLength(2)
               .IsUnicode(false);

            builder
                .HasMany(e => e.Locales)
                .WithOne(e => e.Language)
                .HasForeignKey(e => e.LangCodeId);

        }
    }
}
