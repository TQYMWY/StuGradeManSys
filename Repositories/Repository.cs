using StuGradeManSys.Databases;
using StuGradeManSys.Entities;
using System.Data;

namespace StuGradeManSys.Repositories
{
    public class Repository<TEntity> where TEntity : new()
    {
        public Repository()
        {
            var type = typeof(TEntity);
            TableName = 'T' + type.Name;
        }
        public string TableName = string.Empty;

        public TEntity? GetEntity(long id)
        {
            return this.GetEntity<TEntity>(id);
        }
        public DataTable? GetEntities()
        {
            return this.GetEntities<TEntity>();
        }
        public DataTable? GetEntitiesBylimits(string limits)
        {
            return this.GetEntitiesByLimits<TEntity>(limits);
        }
        public long GetNextId()
        {
            return this.GetNextId<TEntity>();
        }
        public bool DeleteEntity(long id)
        {
            
            if (this.DeleteEntity<TEntity>(id) == 0)
                return false;
            return true;
        }
        public bool AddEntity(Entity entity)
        {
            if (this.AddEntity<TEntity>(entity) == 0)
                return false;
            return true;
        }
        public bool UpdateEntity(Entity entity)
        {
            if (this.UpdateEntity<TEntity>(entity) == 0)
                return false;
            return true;
        }
        public bool PostEntity(Entity entity)
        {
            if (GetEntity(entity.ID) == null)
            {
                return AddEntity(entity);
            }
            else
            {
                return UpdateEntity(entity);
            }

        }
        public DataSet? Get(string limits)
        {
            return this.Get<TEntity>(limits);
        }
    }
}
