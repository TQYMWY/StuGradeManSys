namespace StuGradeManSys.Entities
{
    public class Student : Entity
    {
        public Student() { }
        public Student(long id, string name, string clazz, string department, string gender, string mailbox, DateTime enrolltime) =>
            (ID, Name, Class, Department, Gender, Mailbox, EnrollTime) = (id, name, clazz, department, gender, mailbox, enrolltime);
        public string Name { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty; 
        public string Mailbox { get; set; } = string.Empty;
        public DateTime EnrollTime { get; set; } = DateTime.Now;
    }
}
