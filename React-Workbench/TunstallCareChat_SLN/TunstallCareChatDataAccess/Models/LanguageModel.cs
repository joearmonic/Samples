using System.Collections.Generic;

namespace TunstallCareChatDataAccess.Models
{
    public class LanguageModel
    {
        public int Id { get; set; }

        public string LangCode { get; set; }

        public bool IsDefault { get; set; }

        public ICollection<LocaleModel> Locales { get; set; }
    }
}