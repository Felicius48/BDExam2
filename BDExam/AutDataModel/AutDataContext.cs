using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDExam.AutDataModel
{
    public class AutDataContext: DbContext
    {
        public  AutDataContext(): base ("DefaultConnection")
        {

        }
        public DbSet<AutData> AutDatas { get; set; }
    }
}
