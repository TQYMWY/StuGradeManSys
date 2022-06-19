using StuGradeManSys.Entities;

namespace StuGradeManSys.Repositories
{
    internal class UserRepository : Repository<User>
    {
        public bool Exist(long id)
        {
            return GetEntity(id) != null;
        }
    }
}
