using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy.PM.Service.VO.PM
{
    public class ProjectVo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int CreateUser { get; set; }
        public System.DateTime CreateTime { get; set; }
    }
}
