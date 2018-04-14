using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TunstallCareChatDataAccess.Models;

namespace TunstallCareChatDataAccess.EntityMaps
{
    [Table("TCC_TemplateParameters", Schema = "Admin")]
    public class TemplateParameterMap : IEntityTypeConfiguration<TemplateParameterModel>
    {
        public void Configure(EntityTypeBuilder<TemplateParameterModel> builder)
        {
        }
    }
}