namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TunstallCareChatDataAccess.EntityMaps;
    using TunstallCareChatDataAccess.Models;

    public class DescriptorMap : IEntityTypeConfiguration<DescriptorModel>
    {
        public int Id { get; set; }

        [Required]
        [StringLength(254)]
        public string Meta { get; set; }

        public void Configure(EntityTypeBuilder<DescriptorModel> builder)
        {
            builder.ToTable("TCC_Descriptors", "Admin");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Meta)
                .HasMaxLength(254)
                .IsRequired(true)
                .IsUnicode(false);

            builder
                .HasMany(e => e.ConfigurationTemplates)
                .WithOne(e => e.DescriptionDescriptor)
                .HasForeignKey(e => e.DescriptionId);

            builder
                .HasMany(e => e.Options)
                .WithOne(e => e.NameDescriptor)
                .HasForeignKey(e => e.NameId);

            builder
                .HasMany(e => e.ParameterCategories)
                .WithOne(e => e.TitleDescriptor)
                .HasForeignKey(e => e.TitleId);

            builder
                .HasMany(e => e.ParametersOfTitles)
                .WithOne(e => e.TitleDescriptor)
                .HasForeignKey(e => e.DescriptionId);

            builder
                .HasMany(e => e.ParametersOfDescriptions)
                .WithOne(e => e.DescriptionDescriptor)
                .HasForeignKey(e => e.TitleId);

            builder
                .HasMany(e => e.Translations)
                .WithOne(e => e.Descriptor)
                .HasForeignKey(e => e.DescriptorId);
        }
    }
}
