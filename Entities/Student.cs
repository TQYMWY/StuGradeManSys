using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuGradeManSys.Entities
{
    public class Student : Entity
    {
        public string Name { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty; 
        public string Mailbox { get; set; } = string.Empty;
        public DateTime EnrollTime { get; set; } = DateTime.Now;
    }
}
