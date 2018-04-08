namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TunstallCareChatDataAccess.EntityMaps;

    [Table("TCC_Locales", Schema = "Admin")]
    public partial class Locale
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
    }
}