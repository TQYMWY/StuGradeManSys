using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuGradeManSys.Entities
{
    public class Course : Entity
    {
        public Course() { }
        public Course(long id, string name, long teacherId, int credit, int term, string type) =>
            (ID, Name, TeacherId, Credit, Term, Type) = (id, name, teacherId, credit, term, type);
        public string Name { get; set; } = string.Empty;
        public long TeacherId { get; set; } = 0;
        public int Credit { get; set; } = 0;
        public int Term { get; set; } = 0;
        public string Type { get; set; } = string.Empty;
    }
}
