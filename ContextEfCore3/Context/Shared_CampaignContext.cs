// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Context.Context.Configurations;
using Context.Model;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;
#nullable disable

namespace Context.Context
{
    public partial class Shared_CampaignContext : DbContext
    {
        public Shared_CampaignContext()
        {
        }

        public Shared_CampaignContext(DbContextOptions<Shared_CampaignContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CampaignLabel> CampaignLabels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=EfCore6Test;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Connect Timeout=60;Encrypt=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Configurations.CampaignLabelConfiguration());

            OnModelCreatingGeneratedProcedures(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
