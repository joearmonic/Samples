namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TunstallCareChatDataAccess.EntityMaps;
    using TunstallCareChatDataAccess.Models;

    public class LocaleMap : IEntityTypeConfiguration<LocaleModel>
    {
        public void Configure(EntityTypeBuilder<LocaleModel> builder)
        {
            builder.ToTable("TCC_Locales", "Admin");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).ValueGeneratedNever();
            builder.Property(b => b.LocaleString)
                .HasMaxLength(254)
                .IsUnicode(false)
                .IsRequired(false);

            builder
                .HasMany(e => e.Translations)
                .WithOne(e => e.Locale)
                .HasForeignKey(e => e.LocaleId);
        }
    }
}