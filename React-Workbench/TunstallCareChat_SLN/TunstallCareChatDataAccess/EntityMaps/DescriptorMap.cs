namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TunstallCareChatDataAccess.EntityMaps;
    using TunstallCareChatDataAccess.Models;

    [Table("TCC_Descriptors", Schema = "Admin")]
    public class Descriptor: IEntityTypeConfiguration<DescriptorModel>
    {
        public Descriptor()
        {
            Options = new HashSet<Option>();
            ParameterCategories = new HashSet<ParameterCategory>();
            Parameters = new HashSet<ParameterMap>();
            Parameters1 = new HashSet<ParameterMap>();
            Translations = new HashSet<Translations>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(254)]
        public string Meta { get; set; }

        public ICollection<TemplateModel> ConfigurationTemplates { get; set; }

        public virtual ICollection<Option> Options { get; set; }

        public virtual ICollection<ParameterCategory> ParameterCategories { get; set; }

        public virtual ICollection<ParameterMap> Parameters { get; set; }

        public virtual ICollection<ParameterMap> Parameters1 { get; set; }

        public virtual ICollection<Translations> Translations { get; set; }

        public void Configure(EntityTypeBuilder<ConfigurationModel> builder)
        {
            throw new NotImplementedException();
        }

        public void Configure(EntityTypeBuilder<DescriptorModel> builder)
        {
            throw new NotImplementedException();
        }
    }
}
