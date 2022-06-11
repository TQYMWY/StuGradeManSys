using StuGradeManSys.Entities;
using StuGradeManSys.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuGradeManSys.Services
{
    public class AdminService : Service<Admin>
    {
        AdminRepository Repository = new AdminRepository();
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

        public override Admin? GetEntity(long id)
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
