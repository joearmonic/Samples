namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TunstallCareChatDataAccess.EntityMaps;
    using TunstallCareChatDataAccess.Models;

    [Table("TCC_Locales", Schema = "Admin")]
    public class Locale : IEntityTypeConfiguration<LocaleModel>
    {
        public Locale()
        {
            Descriptors = new HashSet<Translations>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(254)]
        public string LocaleString { get; set; }

        public int? LangCodeId { get; set; }

        public Language Language { get; set; }

        public ICollection<Translations> Descriptors { get; set; }

        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ConfigurationModel> builder)
        {
            throw new System.NotImplementedException();
        }

        public void Configure(EntityTypeBuilder<LocaleModel> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}