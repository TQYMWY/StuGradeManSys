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
    public class UserService : Service<User>
    {
        UserRepository Repository = new UserRepository();
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

        public override User? GetEntity(long id)
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

        public User Authenticate(User user)
        {
            var entity = Repository.GetEntity(user.ID);
            if (entity == null || entity.Pwd != user.Pwd)
            {
                user.ID = -1;
                return user;
            }
            else return entity;
        }

        
    }
}
