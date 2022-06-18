namespace StuGradeManSys.Entities
{
    public class StuCoz : Entity
    {
        public StuCoz() { }
        public StuCoz(long id, long studentId, long courseId, int grade) => (ID, StudentId, CourseId, Grade)=(id, studentId, courseId, grade);
        public long StudentId { get; set; } = 0;
        public long CourseId { get; set; } = 0;
        public int Grade { get; set; } = 0;
    }
}
