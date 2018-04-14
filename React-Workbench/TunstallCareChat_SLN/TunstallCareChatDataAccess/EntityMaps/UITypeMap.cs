namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using TunstallCareChatDataAccess.Models;

    [Table("TCC_UITypes", Schema = "Admin")]
    public class UITypeMap: IEntityTypeConfiguration<UITypeModel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<UITypeModel> builder)
        {
            builder.HasKey(b=> b.Id);
            builder.Property(b=> b.Id).ValueGeneratedNever();
            builder.Property(b => b.ReflectionType).IsRequired(true).HasMaxLength(250).IsUnicode(false);
            builder.Property(b => b.ValueType).IsRequired(true).HasMaxLength(250).IsUnicode(false);
            builder
                .HasMany(e => e.Parameters)
                .WithOne(e => e.UIType)
                .HasForeignKey(e => e.UITypeId);
        }
    }
}
