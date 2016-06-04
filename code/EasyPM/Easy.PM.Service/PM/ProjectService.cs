using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Easy.PM.Core.DB;
using Easy.PM.Core.Util;
using Easy.PM.Service.VO.PM;
using Easy.PM.Store.PM;

namespace Easy.PM.Service.PM
{
    public class ProjectService:IProjectService
    {
        private IProjectRepository _repository=SingletonFactory.Resolves<IProjectRepository>();

        public ListResult<ProjectVo> All(int? status = 0)
        {
            throw new NotImplementedException();
        }

        public DataResult<bool> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public DataResult<ProjectVo> Get(long Id)
        {
            throw new NotImplementedException();
        }

        public DataResult<bool> Update(ProjectVo vo)
        {
            throw new NotImplementedException();
        }
    }
}
