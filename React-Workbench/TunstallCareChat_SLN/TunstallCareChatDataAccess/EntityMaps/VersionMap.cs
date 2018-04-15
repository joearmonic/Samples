namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TunstallCareChatDataAccess.Models;

    public class VersionMap : IEntityTypeConfiguration<VersionModel>
    {
        public void Configure(EntityTypeBuilder<VersionModel> builder)
        {
            builder.ToTable("TCC_Versions", "Admin");
            builder.HasKey(b => b.Id);

            builder
          .Property(e => e.Id)
          .ValueGeneratedNever();

            builder
                .Property(e => e.Number)
                .IsUnicode(false)
                .HasMaxLength(12)
                .IsRequired(true)
                .HasColumnName("Version");

            builder
                .HasMany(e => e.Templates)
                .WithOne(e => e.Version)
                .HasForeignKey(e => e.VersionId);
        }
    }
}
