namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TunstallCareChatDataAccess.Models;

    public class TerminalMap : IEntityTypeConfiguration<TerminalModel>
    {
        public void Configure(EntityTypeBuilder<TerminalModel> builder)
        {
            builder.ToTable("TCC_Terminals", "Admin");
            builder.Property(b => b.Number).HasMaxLength(14).IsRequired(true);
            builder.HasKey(b => b.Id);

            builder
                .Property(e => e.Number)
                .IsUnicode(false)
                .HasMaxLength(14);

            builder
                .HasMany(e => e.Configurations)
                .WithOne(e => e.Terminal)
                .HasForeignKey(e => e.TerminalId);

            builder
                .HasMany(e => e.Programmations)
                .WithOne(e => e.Terminal)
                .HasForeignKey(e => e.TerminalId);

            builder
                .HasMany(e => e.ProgramOrders)
                .WithOne(e => e.Terminal)
                .HasForeignKey(e => e.TerminalId);
        }
    }
}
