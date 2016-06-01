using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Easy.PM.Core.DB;

namespace Easy.PM.Store.DB
{
    public abstract class EFRepository<T> : IRepository<T> where T : class
    {
        private PMEntities EF = new PMEntities();
        private DbSet<T> Entities
        {
            get { return EF.Set<T>(); }
        }

        public DataResult<T> Add(T model)
        {
            Entities.Add(model);
            EF.SaveChanges();
            return new DataResult<T>(model);
        }

        public DataResult<bool> Delete(int id)
        {
            Entities.Remove(Entities.Find(id));
            return new DataResult<bool>(EF.SaveChanges() > 0);
        }

        public DataResult<bool> Delete(T model)
        {
            Entities.Remove(model);
            return new DataResult<bool>(EF.SaveChanges() > 0);
        }

        public List<T> Get()
        {
            return Entities.ToList<T>();
        }

        public T Get(int id)
        {
            return Entities.Find(id);
        }

        public DataResult<bool> Update(T model)
        {
            EF.Entry(model).State = EntityState.Modified;
            return new DataResult<bool>(EF.SaveChanges() > 0);
        }
    }
}
