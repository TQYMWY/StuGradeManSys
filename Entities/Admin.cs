namespace StuGradeManSys.Entities
{
    public class Admin : Entity
    {
        public Admin() { }
        public Admin(long id, string name, string mailbox) => (ID, Name, Mailbox) = (id, name, mailbox);
        public string Name { get; set; } = string.Empty;
        public string Mailbox { get; set; } = string.Empty;
    }
}
