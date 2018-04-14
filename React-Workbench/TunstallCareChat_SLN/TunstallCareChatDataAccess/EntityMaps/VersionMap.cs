namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TunstallCareChatDataAccess.Models;

    [Table("TCC_Versions", Schema = "Admin")]
    public class Version: IEntityTypeConfiguration<VersionModel>
    {
        public void Configure(EntityTypeBuilder<VersionModel> builder)
        {
            builder.HasKey(b => b.Id);
        }
    }
}
