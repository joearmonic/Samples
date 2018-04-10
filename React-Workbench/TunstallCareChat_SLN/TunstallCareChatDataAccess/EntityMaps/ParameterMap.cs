namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TunstallCareChatDataAccess.Models;

    [Table("TCC_Parameters", Schema = "Admin")]
    public class ParameterMap: IEntityTypeConfiguration<ParameterModel>
    { 
        public void Configure(EntityTypeBuilder<ParameterModel> builder)
        {
            builder.HasKey(b => b.Id);
        }
    }
}