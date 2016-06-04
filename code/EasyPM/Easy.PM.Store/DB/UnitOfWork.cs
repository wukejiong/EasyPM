using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Easy.PM.Core.DB;

namespace Easy.PM.Store.DB
{
    public class UnitOfWork:IUnitOfWork
    {
        private DbContext  _context =new PMEntities();

        public DbContext GetContent(){
            return _context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }

        ~UnitOfWork()
        {
            this.Dispose(false);
        }

    }
}
