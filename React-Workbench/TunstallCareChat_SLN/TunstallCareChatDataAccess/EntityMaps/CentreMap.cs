using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TunstallCareChatDataAccess.Models;

namespace TunstallCareChatDataAccess.EntityMaps
{
    public class CentreMap : IEntityTypeConfiguration<CentreModel>
    {
        public void Configure(EntityTypeBuilder<CentreModel> builder)
        {
            builder
                .ToTable("TIB_CENTRE_DEF", "dbo").HasKey(item => item.Id); 
            builder
                .Property(item => item.Id).HasColumnName("TIB_CENTRE_DEF").IsRequired();
            builder.Property(item => item.IP).HasColumnName("IP").IsRequired().HasMaxLength(32);
            builder.Property(item => item.Name).HasColumnName("TIB_CENTRE_NAME").IsRequired().HasMaxLength(32);
            builder.Property(item => item.BackupId).HasColumnName("ID_CENTRE_BCK_REF");

            builder
            .HasMany(item => item.Terminals)
            .WithOne(item => item.ControlCentre).HasForeignKey(item => item.CentreId);
        }
    }
}
