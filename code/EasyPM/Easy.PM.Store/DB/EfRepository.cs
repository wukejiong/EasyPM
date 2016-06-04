using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Easy.PM.Core.DB;

namespace Easy.PM.Store.DB
{
    public abstract class EFRepository<T> : IRepository<T> where T : class
    {
        private bool _isCommit = true;
        private DbContext _content = null;

        public EFRepository(){
            _content = new PMEntities();
        }

        public void SetContent(DbContext content) {
            _content = content;
            _isCommit = false;
        }

        private DbSet<T> Entities
        {
            get { return _content.Set<T>(); }
        }

        public DataResult<T> Add(T model)
        {
            Entities.Add(model);
            if (_isCommit)
            {
                _content.SaveChanges();
                return new DataResult<T>(model);
            }
            return null;
        }

        public DataResult<bool> Delete(int id)
        {
            Entities.Remove(Entities.Find(id));
            if (_isCommit) {
                var isOK = (_content.SaveChanges() > 0);
                return new DataResult<bool>(isOK);
            }
            return null;
        }

        public DataResult<bool> Delete(T model)
        {
            Entities.Remove(model);
            if (_isCommit)
            {
                var isOK = (_content.SaveChanges() > 0);
                return new DataResult<bool>(isOK);
            }
            return null;
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
            _content.Entry(model).State = EntityState.Modified;
            if (_isCommit)
            {
                var isOK = (_content.SaveChanges() > 0);
                return new DataResult<bool>(isOK);
            }
            return null;
        }

        public virtual IQueryable<T> Filter(Expression<Func<T, bool>> filter, out int total, int index = 0,
                                              int size = 50)
        {
            var skipCount = index * size;
            var resetSet = filter != null
                                ? Entities.Where<T>(filter).AsQueryable()
                                : Entities.AsQueryable();
            resetSet = skipCount == 0 ? resetSet.Take(size) : resetSet.Skip(skipCount).Take(size);
            total = resetSet.Count();
            return resetSet.AsQueryable();
        }
    }
}
