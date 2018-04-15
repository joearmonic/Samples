namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TunstallCareChatDataAccess.Models;

    public class Configuration : IEntityTypeConfiguration<ConfigurationModel>
    {
        public void Configure(EntityTypeBuilder<ConfigurationModel> builder)
        {
            builder.ToTable("TCC_Configurations", "Admin");
        }
    }
}
