using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BDExam.SalesModels
{
    public class SaleModelContext: DbContext
    {
        public SaleModelContext(): base("DefaultConnection")
        {

        }
        public DbSet<SaleModel> saleModels { get; set; }
    }
}
