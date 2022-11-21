using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDExam.TeacherListModels
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }

        public string MiddleName { get; set; }

        public string DateofEmployment { get; set; }

        public string Experience { get; set; }

    }
}
