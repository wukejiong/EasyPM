using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Easy.PM.Core.DB;

namespace Easy.PM.Store.DB
{
    public class UnitOfWork :ObjectContext, IUnitOfWork
    {
        public void Save()
        {
            base.SaveChanges();
        }
    }
}
