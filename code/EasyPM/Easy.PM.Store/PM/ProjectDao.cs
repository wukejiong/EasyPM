using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Easy.PM.Store.DB;

namespace Easy.PM.Store.PM
{
    public class ProjectDao : EFRepository<PM_Project>, IProjectDao
    {
    }
}
