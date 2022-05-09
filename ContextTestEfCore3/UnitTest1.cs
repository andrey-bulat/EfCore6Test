using System.Data;
using System.Threading.Tasks;
using Context.Context;
using NUnit.Framework;

namespace ContextTestEfCore3
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Test1()
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