namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TunstallCareChatDataAccess.Models;

    [Table("TCC_ParameterCategories", Schema = "Admin")]
    public class ParameterCategoryMap : IEntityTypeConfiguration<ParameterCategoryModel>
    {
        public void Configure(EntityTypeBuilder<ParameterCategoryModel> builder)
        {
            builder.HasKey(b => b.Id);
        }
    }
}