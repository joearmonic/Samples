namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TunstallCareChatDataAccess.EntityMaps;
    using TunstallCareChatDataAccess.Models;

    [Table("TCC_Descriptors", Schema = "Admin")]
    public class Descriptor
    {
        public Descriptor()
        {
            Options = new HashSet<Option>();
            ParameterCategories = new HashSet<ParameterCategory>();
            Parameters = new HashSet<Parameter>();
            Parameters1 = new HashSet<Parameter>();
            Translations = new HashSet<Translations>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(254)]
        public string Meta { get; set; }

        public ICollection<TemplateModel> ConfigurationTemplates { get; set; }

        public virtual ICollection<Option> Options { get; set; }

        public virtual ICollection<ParameterCategory> ParameterCategories { get; set; }

        public virtual ICollection<Parameter> Parameters { get; set; }

        public virtual ICollection<Parameter> Parameters1 { get; set; }

        public virtual ICollection<Translations> Translations { get; set; }
    }
}
