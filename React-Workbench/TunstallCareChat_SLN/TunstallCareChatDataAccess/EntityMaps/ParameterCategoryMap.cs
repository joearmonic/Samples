namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TunstallCareChatDataAccess.Models;

    [Table("TCC_ParameterCategories", Schema = "Admin")]
    public class ParameterCategory: IEntityTypeConfiguration<ParameterCategoryModel>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ParameterCategory()
        {
            Parameters = new HashSet<Parameter>();
        }

        public int Id { get; set; }

        public int TitleId { get; set; }

        public virtual Descriptor Descriptor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parameter> Parameters { get; set; }

        public void Configure(EntityTypeBuilder<ParameterCategoryModel> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}