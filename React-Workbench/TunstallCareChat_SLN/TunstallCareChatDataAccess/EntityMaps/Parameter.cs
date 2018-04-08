namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TCC_Parameters", Schema = "Admin")]
    public partial class Parameter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parameter()
        {
            Options = new HashSet<Option>();
            Programmations = new HashSet<Programmation>();
            TemplateParameters = new HashSet<TemplateParameter>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int DescriptionId { get; set; }

        public int? UITypeId { get; set; }

        public int CategoryId { get; set; }

        public int TitleId { get; set; }

        public byte Priority { get; set; }

        public short MobileKey { get; set; }

        public short Length { get; set; }

        public virtual Descriptor TitleDescriptor { get; set; }

        public virtual Descriptor DescriptionDescriptor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Option> Options { get; set; }

        public virtual ParameterCategory ParameterCategory { get; set; }

        public virtual UIType UIType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Programmation> Programmations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TemplateParameter> TemplateParameters { get; set; }
    }
}