namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TunstallCareChatDataAccess.Models;

    [Table("TCC_Languages", Schema = "Admin")]
    public class Language : IEntityTypeConfiguration<LanguageModel>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Language()
        {
            Locales = new HashSet<Locale>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(2)]
        public string LangCode { get; set; }

        public bool IsDefault { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Locale> Locales { get; set; }

        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ConfigurationModel> builder)
        {
            throw new NotImplementedException();
        }

        public void Configure(EntityTypeBuilder<LanguageModel> builder)
        {
            throw new NotImplementedException();
        }
    }
}
