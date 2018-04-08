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
        public DbSet<Descriptor> Descriptors { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Locale> Locales { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<ParameterCategory> ParameterCategories { get; set; }
        public DbSet<Parameter> Parameters { get; set; }
        public DbSet<Programmation> Programmations { get; set; }
        public DbSet<ProgramOrder> ProgramOrders { get; set; }
        public DbSet<TemplateParameter> TemplateParameters { get; set; }
        public DbSet<TerminalModel> Terminals { get; set; }
        public DbSet<UIType> UITypes { get; set; }
        public DbSet<Version> Versions { get; set; }
        public DbSet<Translations> Translations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConfigurationModel>()
            .HasKey(conf => new { conf.TerminalId, conf.TemplateId, conf.ParameterId });

            modelBuilder.Entity<ConfigurationModel>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<TemplateModel>()
                .HasMany(e => e.Configurations)
                .WithOne(e => e.ConfigurationTemplate)
                .HasForeignKey(e => e.TemplateId);

            modelBuilder.Entity<TemplateModel>()
                .HasMany(e => e.Parameters)
                .WithOne(e => e.Template)
                .HasForeignKey(e => e.TemplateId);

            modelBuilder.Entity<TemplateModel>()
                .HasMany(e => e.Terminals)
                .WithOne(e => e.ConfigurationTemplate)
                .HasForeignKey(e => e.TemplateId);

            modelBuilder.Entity<Descriptor>()
                .Property(e => e.Meta)
                .IsUnicode(false);

            modelBuilder.Entity<DescriptorModel>()
                .HasMany(e => e.ConfigurationTemplates)
                .WithOne(e => e.DescriptionDescriptor)
                .HasForeignKey(e => e.DescriptionId);

            modelBuilder.Entity<Descriptor>()
                .HasMany(e => e.Options)
                .WithOne(e => e.Descriptor)
                .HasForeignKey(e => e.NameId);

            modelBuilder.Entity<Descriptor>()
                .HasMany(e => e.ParameterCategories)
                .WithOne(e => e.Descriptor)
                .HasForeignKey(e => e.TitleId);

            modelBuilder.Entity<Descriptor>()
                .HasMany(e => e.Parameters)
                .WithOne(e => e.TitleDescriptor)
                .HasForeignKey(e => e.DescriptionId);

            modelBuilder.Entity<Descriptor>()
                .HasMany(e => e.Parameters1)
                .WithOne(e => e.DescriptionDescriptor)
                .HasForeignKey(e => e.TitleId);

            modelBuilder.Entity<Descriptor>()
                .HasMany(e => e.Translations)
                .WithOne(e => e.Descriptor)
                .HasForeignKey(e => e.DescriptorId);

            modelBuilder.Entity<Language>()
                .Property(e => e.LangCode)
                .HasMaxLength(2)
                .IsUnicode(false);

            modelBuilder.Entity<Language>()
                .HasMany(e => e.Locales)
                .WithOne(e => e.Language)
                .HasForeignKey(e => e.LangCodeId);

            modelBuilder.Entity<Option>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<ParameterCategory>()
                .HasMany(e => e.Parameters)
                .WithOne(e => e.ParameterCategory)
                .HasForeignKey(e => e.CategoryId);

            modelBuilder.Entity<Parameter>()
                .HasMany(e => e.Options)
                .WithOne(e => e.Parameters)
                .HasForeignKey(e => e.ParameterId);

            modelBuilder.Entity<Parameter>()
                .HasMany(e => e.Programmations)
                .WithOne(e => e.Parameter)
                .HasForeignKey(e => e.ParameterId);

            modelBuilder.Entity<Parameter>()
                .HasMany(e => e.TemplateParameters)
                .WithOne(e => e.Parameter)
                .HasForeignKey(e => e.ParameterId);

            modelBuilder.Entity<Programmation>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<ProgramOrder>()
                .Property(e => e.Emitter)
                .IsUnicode(false);

            modelBuilder.Entity<ProgramOrder>()
                .HasMany(e => e.Programmations)
                .WithOne(e => e.ProgramOrder)
                .HasForeignKey(e => e.ProgramOrderId);

            modelBuilder.Entity<TemplateParameter>()
            .HasKey(tp => new { tp.ParameterId, tp.TemplateId });

            modelBuilder.Entity<TemplateParameter>()
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
            modelBuilder.Entity<UIType>()
                .Property(e => e.ReflectionType)
                .IsUnicode(false);

            modelBuilder.Entity<UIType>()
                .Property(e => e.ValueType)
                .IsUnicode(false);

            modelBuilder.Entity<UIType>()
                .HasMany(e => e.Parameters)
                .WithOne(e => e.UIType)
                .HasForeignKey(e => e.UITypeId);

            modelBuilder.Entity<Version>()
                .Property(e => e.VersionNumber)
                .IsUnicode(false);

            modelBuilder.Entity<VersionModel>()
                .HasMany(e => e.Terminals)
                .WithOne(e => e.Version)
                .HasForeignKey(e => e.VersionId);


            modelBuilder.Entity<Locale>()
                .HasMany(e => e.Descriptors)
                .WithOne(e => e.Locale)
                .HasForeignKey(e => e.LocaleId);

            modelBuilder.Entity<Translations>()
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