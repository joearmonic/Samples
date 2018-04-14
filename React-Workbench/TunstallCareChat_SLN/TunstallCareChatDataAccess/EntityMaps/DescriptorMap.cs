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

    [Table("TCC_Descriptors", Schema = "Admin")]
    public class Descriptor: IEntityTypeConfiguration<DescriptorModel>
    {
        public int Id { get; set; }

        [Required]
        [StringLength(254)]
        public string Meta { get; set; }

        public void Configure(EntityTypeBuilder<DescriptorModel> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Meta)
            .HasMaxLength(254)
            .IsRequired(true)
            .IsUnicode(false);
        }
    }
}
