using System.ComponentModel.DataAnnotations.Schema;
using TCC.Web.Services.DAL.TerminalProgramming;

namespace TunstallCareChatDataAccess.EntityMaps
{
    
    [Table("TCC_Translations", Schema = "Admin")]  
    public class Translations
    {
        public int LocaleId { get; set; }

        public Locale Locale { get; set; }

        public Descriptor Descriptor{ get; set; }

        public int DescriptorId { get; set; }
    }
}