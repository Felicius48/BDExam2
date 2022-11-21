using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDExam.TeacherListModels
{
    public class TeacherListContext: DbContext
    {
        public TeacherListContext(): base("DefaultConnection")
        {

        }
        public DbSet<Teacher> Teacher { get; set; }
    }
}
