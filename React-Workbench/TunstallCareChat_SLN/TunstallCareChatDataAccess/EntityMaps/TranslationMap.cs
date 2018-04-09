using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using TCC.Web.Services.DAL.TerminalProgramming;
using TunstallCareChatDataAccess.Models;

namespace TunstallCareChatDataAccess.EntityMaps
{
    
    [Table("TCC_Translations", Schema = "Admin")]  
    public class Translations: IEntityTypeConfiguration<TranslationModel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TranslationModel> builder)
        {
            
        }
    }
}