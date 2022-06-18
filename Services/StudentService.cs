using StuGradeManSys.Entities;
using StuGradeManSys.Repositories;
using System.Data;

namespace StuGradeManSys.Services
{
    public class StudentService : Service<Student>
    {
        StudentRepository Repository = new StudentRepository();
        public override bool DeleteEntity(Entity entity)
        {
            return Repository.DeleteEntity(entity.ID);
        }

        public override DataTable? GetEntities()
        {
            return Repository.GetEntities();
        }

        public override DataTable? GetEntitiesBylimits(string limits)
        {
            return Repository.GetEntitiesBylimits(limits);
        }

        public override Student? GetEntity(long id)
        {
            return Repository.GetEntity(id);
        }

        public override bool PostEntity(Entity entity)
        {
            return Repository.PostEntity(entity);
        }
        public override long GetNextId()
        {
            return Repository.GetNextId();
        }

    }
}
