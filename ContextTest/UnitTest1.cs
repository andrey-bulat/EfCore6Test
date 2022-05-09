using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Context;
using Context.Context;
using Context.Entries;
using Microsoft.Data.SqlClient;
using Xunit;

namespace ContextTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestUdf()
        {
            using (var ctx = new Shared_CampaignContext())
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Value", typeof(int));

                var result = ctx.campaign_label_find_udf(dataTable, null, null, null, null)
                    .ToList();
            }
        }

        [Fact]
        public async Task TestSp()
        {
            using (var ctx = new Shared_CampaignContext())
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Value", typeof(int));

                var result = await ctx.Procedures.campaign_label_find_spAsync(dataTable, null, null, null, null);
            }
        }
    }
}