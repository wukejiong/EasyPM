using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy.PM.Core.DB
{
    public class ListResult<T>
    {
        public int Status { get; set; }

        public string Message { get; set; }

        public List<T> Data { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        public int TotalCount { get; set; }
    }
}
