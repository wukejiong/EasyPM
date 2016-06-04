using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Easy.PM.Core.DB
{
    public interface IUnitOfWork:IDisposable
    {
        DbContext GetContent();

        void Save();
    }
}
