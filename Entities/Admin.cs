using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuGradeManSys.Entities
{
    public class Admin : Entity
    {
        public string Name { get; set; } = string.Empty;
        public string Mailbox { get; set; } = string.Empty;
    }
}
