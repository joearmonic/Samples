using TCC.Web.Services.DAL.TerminalProgramming;
using System;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using TunstallCareChatDataAccess.EntityMaps;
using TunstallCareChatDataAccess.Models;

namespace TCC.Web.Services.DAL.TerminalProgramming
{

    public class TCCDbContext : DbContext
    {
        public TCCDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ConfigurationModel> Configurations { get; set; }
        public DbSet<TemplateModel> ConfigurationTemplates { get; set; }
        public DbSet<DescriptorModel> Descriptors { get; set; }
        public DbSet<LanguageModel> Languages { get; set; }
        public DbSet<LocaleModel> Locales { get; set; }
        public DbSet<OptionModel> Options { get; set; }
        public DbSet<ParameterCategoryModel> ParameterCategories { get; set; }
        public DbSet<ParameterModel> Parameters { get; set; }
        public DbSet<ProgrammationModel> Programmations { get; set; }
        public DbSet<ProgramOrderModel> ProgramOrders { get; set; }
        public DbSet<TemplateParameterModel> TemplateParameters { get; set; }
        public DbSet<TerminalModel> Terminals { get; set; }
        public DbSet<UITypeModel> UITypes { get; set; }
        public DbSet<VersionModel> Versions { get; set; }
        public DbSet<TranslationModel> Translations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurations
            modelBuilder.Entity<ConfigurationModel>()
            .HasKey(conf => new { conf.TerminalId, conf.TemplateId, conf.ParameterId });

            modelBuilder.Entity<ConfigurationModel>()
                .Property(e => e.Value)
                .IsUnicode(false);

            // Templates
            modelBuilder.Entity<TemplateModel>()
                .HasMany(e => e.Configurations)
                .WithOne(e => e.ConfigurationTemplate)
                .HasForeignKey(e => e.TemplateId);

            modelBuilder.Entity<TemplateModel>()
                .HasMany(e => e.TemplateParameters)
                .WithOne(e => e.Template)
                .HasForeignKey(e => e.TemplateId);

            modelBuilder.Entity<TemplateModel>()
                .HasMany(e => e.Terminals)
                .WithOne(e => e.ConfigurationTemplate)
                .HasForeignKey(e => e.TemplateId);

            // Descriptor
            modelBuilder.Entity<Descriptor>()
                .Property(e => e.Meta)
                .IsUnicode(false);

            modelBuilder.Entity<DescriptorModel>()
                .HasMany(e => e.ConfigurationTemplates)
                .WithOne(e => e.DescriptionDescriptor)
                .HasForeignKey(e => e.DescriptionId);

            modelBuilder.Entity<DescriptorModel>()
                .HasMany(e => e.Options)
                .WithOne(e => e.Descriptor)
                .HasForeignKey(e => e.NameId);

            modelBuilder.Entity<DescriptorModel>()
                .HasMany(e => e.ParameterCategories)
                .WithOne(e => e.TitleDescriptor)
                .HasForeignKey(e => e.TitleId);

            modelBuilder.Entity<DescriptorModel>()
                .HasMany(e => e.Parameters)
                .WithOne(e => e.TitleDescriptor)
                .HasForeignKey(e => e.DescriptionId);

            modelBuilder.Entity<DescriptorModel>()
                .HasMany(e => e.Parameters1)
                .WithOne(e => e.DescriptionDescriptor)
                .HasForeignKey(e => e.TitleId);

            modelBuilder.Entity<DescriptorModel>()
                .HasMany(e => e.Translations)
                .WithOne(e => e.Descriptor)
                .HasForeignKey(e => e.DescriptorId);

            modelBuilder.Entity<LanguageModel>()
                .Property(e => e.LangCode)
                .HasMaxLength(2)
                .IsUnicode(false);

            modelBuilder.Entity<LanguageModel>()
                .HasMany(e => e.Locales)
                .WithOne(e => e.Language)
                .HasForeignKey(e => e.LangCodeId);

            modelBuilder.Entity<Option>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<ParameterCategoryModel>()
                .HasMany(e => e.Parameters)
                .WithOne(e => e.ParameterCategory)
                .HasForeignKey(e => e.CategoryId);

            // Parameter
            modelBuilder.Entity<ParameterModel>()
            .Property(b => b.Id).ValueGeneratedNever();
            
            modelBuilder.Entity<ParameterModel>()
                .HasMany(e => e.Options)
                .WithOne(e => e.Parameters)
                .HasForeignKey(e => e.ParameterId);

            modelBuilder.Entity<ParameterModel>()
                .HasMany(e => e.Programmations)
                .WithOne(e => e.Parameter)
                .HasForeignKey(e => e.ParameterId);

            modelBuilder.Entity<ParameterModel>()
                .HasMany(e => e.TemplateParameters)
                .WithOne(e => e.Parameter)
                .HasForeignKey(e => e.ParameterId);

            // Programmation
            modelBuilder.Entity<ProgrammationModel>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<ProgramOrder>()
                .Property(e => e.Emitter)
                .IsUnicode(false);

            modelBuilder.Entity<ProgramOrder>()
                .HasMany(e => e.Programmations)
                .WithOne(e => e.ProgramOrder)
                .HasForeignKey(e => e.ProgramOrderId);

            modelBuilder.Entity<TemplateParameterModel>()
            .HasKey(tp => new { tp.ParameterId, tp.TemplateId });

            modelBuilder.Entity<TemplateParameterModel>()
                .Property(e => e.Value)
                .IsUnicode(false);
                
            // Terminal
            modelBuilder.Entity<TerminalModel>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<TerminalModel>()
                .HasMany(e => e.Configurations)
                .WithOne(e => e.Terminal)
                .HasForeignKey(e => e.TerminalId);

            modelBuilder.Entity<TerminalModel>()
                .HasMany(e => e.Programmations)
                .WithOne(e => e.Terminal)
                .HasForeignKey(e => e.TerminalId);

            modelBuilder.Entity<TerminalModel>()
                .HasMany(e => e.ProgramOrders)
                .WithOne(e => e.Terminal)
                .HasForeignKey(e => e.TerminalId);

            // UI Type
            modelBuilder.Entity<UITypeModel>()
                .Property(e => e.ReflectionType)
                .IsUnicode(false);

            modelBuilder.Entity<UITypeModel>()
                .Property(e => e.ValueType)
                .IsUnicode(false);

            modelBuilder.Entity<UITypeModel>()
                .HasMany(e => e.Parameters)
                .WithOne(e => e.UIType)
                .HasForeignKey(e => e.UITypeId);

            modelBuilder.Entity<VersionModel>()
                .Property(e => e.VersionNumber)
                .IsUnicode(false);

            modelBuilder.Entity<VersionModel>()
                .HasMany(e => e.Terminals)
                .WithOne(e => e.Version)
                .HasForeignKey(e => e.VersionId);z


            modelBuilder.Entity<LocaleModel>()
                .HasMany(e => e.Descriptors)
                .WithOne(e => e.Locale)
                .HasForeignKey(e => e.LocaleId);

            modelBuilder.Entity<TranslatiosModel>()
            .HasKey(tran => new { tran.DescriptorId, tran.LocaleId });
        }

        // public virtual int OnACKDumpProgrammations(Nullable<int> orderId)
        // {
        //     var orderIdParameter = orderId.HasValue ?
        //         new ObjectParameter("OrderId", orderId) :
        //         new ObjectParameter("OrderId", typeof(int));

        //     return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TUNApps.Admin.TCC_OnACKDumpProgrammations", orderIdParameter);
        // }
    }
}