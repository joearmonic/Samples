namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TunstallCareChatDataAccess.Models;

    [Table("TCC_Versions", Schema = "Admin")]
    public class Version: IEntityTypeConfiguration<VersionModel>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Version()
        {
            ConfigurationTemplates = new HashSet<ConfigurationTemplateMap>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(12)]
        [Column("Version")]
        public string VersionNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConfigurationTemplateMap> ConfigurationTemplates { get; set; }

        public void Configure(EntityTypeBuilder<VersionModel> builder)
        {
            throw new NotImplementedException();
        }
    }
}
