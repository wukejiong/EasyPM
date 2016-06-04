using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Easy.PM.Core.Util;
using Easy.PM.Store.PM;

namespace Easy.PM.Service.PM
{
    public class ProjectService:IProjectService
    {
        private IProjectRepository _repository=SingletonFactory.Resolves<IProjectRepository>();
       
    }
}
