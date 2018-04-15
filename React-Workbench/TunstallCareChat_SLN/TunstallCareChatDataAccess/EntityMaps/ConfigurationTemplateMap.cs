namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TunstallCareChatDataAccess.Models;

    [Table("TCC_ConfigurationTemplates", Schema = "Admin")]
    public class ConfigurationTemplateMap : IEntityTypeConfiguration<TemplateModel>
    {
        public void Configure(EntityTypeBuilder<TemplateModel> builder)
        {
            builder.ToTable("TCC_ConfigurationTemplates", "Admin");
            builder.HasKey(b => b.Id);
            
            builder
                .HasMany(e => e.Configurations)
                .WithOne(e => e.ConfigurationTemplate)
                .HasForeignKey(e => e.TemplateId);

            builder
                .HasMany(e => e.TemplateParameters)
                .WithOne(e => e.Template)
                .HasForeignKey(e => e.TemplateId);

           builder
                .HasMany(e => e.Terminals)
                .WithOne(e => e.ConfigurationTemplate)
                .HasForeignKey(e => e.TemplateId);            
        }
    }
}
