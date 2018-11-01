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
            builder.ToTable("TIB_CENTRE_DEF", "dbo");            
        }
    }
}
