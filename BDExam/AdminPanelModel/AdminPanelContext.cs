using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDExam.AdminPanelModel
{
    public class AdminPanelContext: DbContext
    {
        public AdminPanelContext(): base("DefaultConnection")
        {

        }
        public DbSet<AdminPanel> adminPanels { get; set; }
    }
}
