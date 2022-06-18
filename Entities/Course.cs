using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuGradeManSys.Entities
{
    public class Course : Entity
    {
        public string Name { get; set; } = string.Empty;
        public long TeacherId { get; set; } = 0;
        public int Credit { get; set; } = 0;
        public int Term { get; set; } = 0;
        public string Type { get; set; } = string.Empty;
    }
}
