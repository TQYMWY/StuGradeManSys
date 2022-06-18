namespace StuGradeManSys.Entities
{
    public class User : Entity
    {
        public User() { }
        public User(long id, string pwd, string role, string name) =>(ID, Pwd, Role, Name) = (id, pwd, role, name);
        public string Pwd { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}
