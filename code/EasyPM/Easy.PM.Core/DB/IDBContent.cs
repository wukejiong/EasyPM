using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy.PM.Core.DB
{
    public interface IDBContent
    {
        void SetContent(DbContext content);
    }
}
