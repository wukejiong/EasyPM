using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Easy.PM.Core.DB;
using Easy.PM.Service.VO.PM;

namespace Easy.PM.Service.PM
{
    public interface IProjectService
    {
        /// <summary>
        /// 全部
        /// </summary>
        /// <param name="status">状态</param>
        /// <returns></returns>
        ListResult<ProjectVo> All(int? status=0);

        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="Id"></param>  
        /// <returns></returns>
        DataResult<ProjectVo> Get(long Id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        DataResult<bool> Update(ProjectVo vo);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataResult<bool> Delete(long id);
    }
}
