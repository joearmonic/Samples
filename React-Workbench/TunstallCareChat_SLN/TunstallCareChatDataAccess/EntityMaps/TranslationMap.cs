using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TCC.Web.Services.DAL.TerminalProgramming;
using TunstallCareChatDataAccess.Models;

namespace TunstallCareChatDataAccess.EntityMaps
{
    public class TranslationMap : IEntityTypeConfiguration<TranslationModel>
    {
        public void Configure(EntityTypeBuilder<TranslationModel> builder)
        {
            builder.ToTable("TCC_Translations", "Admin");
            builder.HasKey(b => new { b.DescriptorId, b.LocaleId });
        }
    }
}