using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDExam.StudentListModels
{
    public class StudentListContext: DbContext
    {
        public StudentListContext(): base("DefaultConnection")
        {

        }
        public DbSet<Student> Student { get; set; }
    }
}
