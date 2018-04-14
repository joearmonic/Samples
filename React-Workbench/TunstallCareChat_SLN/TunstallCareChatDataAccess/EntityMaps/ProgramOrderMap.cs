namespace TCC.Web.Services.DAL.TerminalProgramming
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TunstallCareChatDataAccess.Models;

    [Table("TCC_ProgramOrders", Schema = "Admin")]
    public class ProgramOrderMap: IEntityTypeConfiguration<ProgramOrderModel>
    {
        public void Configure(EntityTypeBuilder<ProgramOrderModel> builder)
        {
            builder.HasKey(b => b.Id);
        }
    }
}
