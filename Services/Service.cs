using StuGradeManSys.Entities;
using System.Data;

namespace StuGradeManSys.Services
{
    public abstract class Service<TEntity> where TEntity : new()
    {
        public abstract TEntity? GetEntity(long id);
        public abstract DataTable? GetEntities();
        public abstract DataTable? GetEntitiesBylimits(string limits);
        public abstract bool DeleteEntity(Entity entity);
        public abstract bool PostEntity(Entity entity);
        public abstract long GetNextId();
    }
}
