using System.Collections.Generic;

namespace TunstallCareChatDataAccess.Models
{
     public class TranslationModel
     {
         public int LocaleId { get; set; }

         public int DescriptorId { get; set; }

        public LocaleModel Locale { get; set; }

        public DescriptorModel Descriptor{ get; set; }

     }
}