using StuGradeManSys.Entities;
using StuGradeManSys.Repositories;
using System.Data;

namespace StuGradeManSys.Services
{
    public class CourseService : Service<Course>
    {
        CourseRepository Repository = new CourseRepository();
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

        public override Course? GetEntity(long id)
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
