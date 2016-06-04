using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy.PM.Core.DB
{
    public interface IRepository<T>:IDBContent where T:class
    {
        T Get(int id);
        List<T> Get();

        DataResult<bool> Update(T model);

        DataResult<T> Add(T model);

        DataResult<bool> Delete(T model);

        DataResult<bool> Delete(int id);
    }
}
