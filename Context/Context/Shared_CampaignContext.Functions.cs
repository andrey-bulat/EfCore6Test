﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using Context.Model;

namespace Context.Context
{
    public partial class Shared_CampaignContext
    {

        [DbFunction("campaign_label_find_udf", "dbo")]
        public IQueryable<campaign_label_find_udfResult> campaign_label_find_udf(DataTable LabelIds, int? CampaignID, int? CampaignIDSort, int? CategoryID, string Name)
        {
            return FromExpression(() => campaign_label_find_udf(LabelIds, CampaignID, CampaignIDSort, CategoryID, Name));
        }

        protected void OnModelCreatingGeneratedFunctions(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<campaign_label_find_udfResult>().HasNoKey();
        }
    }
}