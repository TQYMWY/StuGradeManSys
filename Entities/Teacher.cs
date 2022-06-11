using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuGradeManSys.Entities
{
    public class Teacher : Entity
    {
        public Teacher() { }
        public Teacher(long id, string name, string department, string gender, string mailbox, DateTime dateTime) => 
            (ID, Name, Department, Gender, Mailbox, EnrollTime) = (id, name, department, gender, mailbox, dateTime);
        public string Name { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Mailbox { get; set; } = string.Empty;
        public DateTime EnrollTime { get; set; } = DateTime.Now;
    }
}
