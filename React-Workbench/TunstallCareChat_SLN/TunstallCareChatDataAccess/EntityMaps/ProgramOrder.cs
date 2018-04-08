namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TunstallCareChatDataAccess.Models;

    [Table("TCC_ProgramOrders", Schema = "Admin")]
    public partial class ProgramOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProgramOrder()
        {
            Programmations = new HashSet<Programmation>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(254)]
        public string Emitter { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Ordered { get; set; }

        public bool ACK { get; set; }

        public bool Direction { get; set; }

        public int TerminalId { get; set; }

        public int? OrderCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Programmation> Programmations { get; set; }

        public virtual TerminalModel Terminal { get; set; }
    }
}
