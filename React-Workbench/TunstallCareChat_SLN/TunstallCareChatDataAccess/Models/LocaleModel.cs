using System.Collections.Generic;

namespace TunstallCareChatDataAccess.Models
{
    public class LocaleModel
    {
        public int Id { get; set; }

        public string LocaleString { get; set; }

        public int? LangCodeId { get; set; }

        public LanguageModel Language { get; set; }

        public ICollection<TranslationModel> Translations { get; set; }
    }
}