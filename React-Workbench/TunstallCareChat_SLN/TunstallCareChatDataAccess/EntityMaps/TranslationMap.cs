using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TCC.Web.Services.DAL.TerminalProgramming;
using TunstallCareChatDataAccess.Models;

namespace TunstallCareChatDataAccess.EntityMaps
{
    
    [Table("TCC_Translations", Schema = "Admin")]  
    public class Translations: IEntityTypeConfiguration<TranslationModel>
    {
        public void Configure(EntityTypeBuilder<TranslationModel> builder)
        {
            builder.HasKey(b => new {b.DescriptorId, b.LocaleId});
        }
    }
}