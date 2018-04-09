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
    public class ConfigurationTemplateMap : IEntityTypeConfiguration<ConfigurationModel>
    {
        public void Configure(EntityTypeBuilder<ConfigurationModel> builder)
        {
            builder.Property(b => b.Value).HasMaxLength(254).IsRequired(true);
        }
    }
}
