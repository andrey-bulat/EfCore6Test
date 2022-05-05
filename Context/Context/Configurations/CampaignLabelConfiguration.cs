﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Context.Context;
using Context.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Context.Context.Configurations
{
    public partial class CampaignLabelConfiguration : IEntityTypeConfiguration<CampaignLabel>
    {
        public void Configure(EntityTypeBuilder<CampaignLabel> entity)
        {
            entity.HasKey(e => e.LabelId)
                .HasName("PK_CAMPAIGN_LABEL");

            entity.ToTable("campaign_label");

            entity.HasIndex(e => new { e.Name, e.CategoryId }, "AK_CAMPAIGN_LABEL_NAME_CATEGORY")
                .IsUnique();

            entity.Property(e => e.LabelId).HasColumnName("LabelID");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(75);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CampaignLabel> entity);
    }
}
