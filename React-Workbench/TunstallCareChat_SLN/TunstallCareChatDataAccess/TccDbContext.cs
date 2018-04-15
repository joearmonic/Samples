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

        public DbSet<UITypeModel> UITypes { get; set; }
        public DbSet<ParameterModel> Parameters { get; set; }
        public DbSet<OptionModel> Options { get; set; }
        public DbSet<ConfigurationModel> Configurations { get; set; }
        public DbSet<TemplateModel> ConfigurationTemplates { get; set; }
        public DbSet<DescriptorModel> Descriptors { get; set; }
        public DbSet<LanguageModel> Languages { get; set; }
        public DbSet<LocaleModel> Locales { get; set; }
        public DbSet<ParameterCategoryModel> ParameterCategories { get; set; }
        public DbSet<ProgrammationModel> Programmations { get; set; }
        public DbSet<ProgramOrderModel> ProgramOrders { get; set; }
        public DbSet<TemplateParameterModel> TemplateParameters { get; set; }
        public DbSet<TerminalModel> Terminals { get; set; }
        public DbSet<VersionModel> Versions { get; set; }

        public DbSet<TranslationModel> Translations { get; set; }

        public DbSet<CentreModel> ControlCentres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // UITYpes
            modelBuilder.ApplyConfiguration(new UITypeMap());

            // Parameter
            modelBuilder.Entity<ParameterModel>()
            .Property(b => b.Id).ValueGeneratedNever();

            modelBuilder.Entity<ParameterModel>()
                .HasMany(e => e.Options)
                .WithOne(e => e.Parameter)
                .HasForeignKey(e => e.ParameterId);

            modelBuilder.Entity<ParameterModel>()
                .HasMany(e => e.Programmations)
                .WithOne(e => e.Parameter)
                .HasForeignKey(e => e.ParameterId);

            modelBuilder.Entity<ParameterModel>()
                .HasMany(e => e.TemplateParameters)
                .WithOne(e => e.Parameter)
                .HasForeignKey(e => e.ParameterId);

            // Options
            modelBuilder.Entity<OptionModel>()
                .Property(e => e.Value)
                .IsUnicode(false)
                .HasMaxLength(230);

            // Programmations
            modelBuilder.Entity<ProgrammationModel>()
                .Property(e => e.Value)
                .IsUnicode(false)
                .HasMaxLength(254);

            // TemplateParameters
            modelBuilder.Entity<TemplateParameterModel>()
            .HasKey(tp => new { tp.ParameterId, tp.TemplateId });

            modelBuilder.Entity<TemplateParameterModel>()
                .Property(e => e.Value)
                .IsUnicode(false)
                .HasMaxLength(254);

            // ParameterCategories
            modelBuilder.Entity<ParameterCategoryModel>()
                .HasMany(e => e.Parameters)
                .WithOne(e => e.ParameterCategory)
                .HasForeignKey(e => e.CategoryId);

            // ProgramOrders
            modelBuilder.Entity<ProgramOrderModel>()
                .Property(e => e.Emitter)
                .IsUnicode(false)
                .IsRequired(true)
                .HasMaxLength(254);

            modelBuilder.Entity<ProgramOrderModel>()
                .Property(e => e.Ordered).HasColumnType("datetime2");

            modelBuilder.Entity<ProgramOrderModel>()
                .HasMany(e => e.Programmations)
                .WithOne(e => e.ProgramOrder)
                .HasForeignKey(e => e.ProgramOrderId);

            // Terminal
            modelBuilder.ApplyConfiguration(new TerminalMap());

            // ConfigurationTemplates
            modelBuilder.ApplyConfiguration(new ConfigurationTemplateMap());

            // Configurations
            modelBuilder.Entity<ConfigurationModel>()
            .HasKey(conf => new { conf.TerminalId, conf.TemplateId, conf.ParameterId });

            modelBuilder.Entity<ConfigurationModel>()
                .Property(e => e.Value)
                .IsUnicode(false)
                .HasMaxLength(254)
                .IsRequired(true);

            // Versions
            modelBuilder.ApplyConfiguration(new VersionMap());

            // Descriptor
            modelBuilder.ApplyConfiguration(new DescriptorMap());

            // Translations
            modelBuilder.ApplyConfiguration(new TranslationMap());

            // Locales
            modelBuilder.ApplyConfiguration(new LocaleMap());

            // Languages
            modelBuilder.ApplyConfiguration(new LanguageMap());

            // ControlCentres
            modelBuilder.ApplyConfiguration(new CentreMap());
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