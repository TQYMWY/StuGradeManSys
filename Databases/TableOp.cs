using StuGradeManSys.Entities;
using StuGradeManSys.Repositories;
using StuGradeManSys.Utils;
using System.Data;

namespace StuGradeManSys.Databases
{
    public static class TableOp
    {
        // 增
        public static int AddEntity<T>(this Repository<T> rep, Entity entity) where T : new()
        {
            var map = entity.getProperties();
            var keys = map.Keys.ToList();
            var values = map.Values.ToList();
            string sql = "insert into " + rep.TableName + " (";
            for (int i = 0; i < keys.Count; i++)
            {
                if (i != keys.Count - 1)
                {
                    sql += keys[i] + ",";
                }
                else
                {
                    sql += keys[i] + ") values ('";
                }
            }
            for (int i = 0; i < values.Count; i++)
            {
                if (i != values.Count - 1)
                {
                    sql += values[i] + "','";
                }
                else
                {
                    sql += values[i] + "')";
                }
            }
            return DataBase.ExecuteSql(sql);
        }
        // 删
        public static int DeleteEntity<T>(this Repository<T> rep, long id) where T : new()
        {
            string sql = "delete from " + rep.TableName + " where ID=" + id;
            return DataBase.ExecuteSql(sql);
        }
        // 查
        public static T? GetEntity<T>(this Repository<T> rep, long id) where T : new()
        {
            string sql = "select * from " + rep.TableName + " where ID=" + id;
            var dataset = DataBase.Query(sql);
            var entity = default(T);
            if (dataset == null)
                return entity;
            var rows = dataset.Tables[0].Rows;
            if (rows.Count == 0)
                return entity;
            entity = new T();
            var row = rows[0]; 
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                property.SetValue(entity, row[property.Name]);
            }
            return entity;
        }
        public static DataTable? GetEntities<T>(this Repository<T> rep) where T : new()
        {
            return GetEntitiesByLimits(rep, "1=1");
        }
        public static DataTable? GetEntitiesByLimits<T>(this Repository<T> rep, string limits) where T : new()
        {
            string sql = "select * from " + rep.TableName + " where " + limits;
            return DataBase.Query(sql)?.Tables[0];
        }
        public static long GetNextId<T>(this Repository<T> rep) where T: new()
        {
            string sql = "select max(ID) as ID from " + rep.TableName;
            var dataset = DataBase.Query(sql);
            if (dataset == null) return 0;
            var rows = dataset.Tables[0].Rows;
            if (rows.Count == 0) return 0;
            var row = rows[0];
            long id;
            try
            {
                id = (long)row["ID"];
            } catch(Exception)
            {
                id = 1000;
            }
            return id + 1;
        }
        public static DataSet? Get<T>(this Repository<T> rep, string sql) where T : new()
        {
            return DataBase.Query(sql);
        }
        // 改
        public static int UpdateEntity<T>(this Repository<T> rep, Entity entity) where T: new()
        {
            string sql = "update " + rep.TableName + " set ";
            var map = entity.getProperties();
            var keys = map.Keys.ToList();
            var values = map.Values.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                if (i != keys.Count - 1)
                {
                    sql += keys[i] + "='" + values[i] + "',";
                }
                else
                {
                    sql += keys[i] + "='" + values[i] + "' ";
                }
            }
            sql += "where ID=" + entity.ID;
            return DataBase.ExecuteSql(sql);
        }
    }
}
