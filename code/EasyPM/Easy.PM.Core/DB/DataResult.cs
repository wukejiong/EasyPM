using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy.PM.Core.DB
{
    public class DataResult<T>
    {
        public DataResult() { }
        public DataResult(T t){
         Data =t;
        }
        public int Status { get; set; }

        public string Message { get; set; }

        public T Data { get; set; }
    }
}
