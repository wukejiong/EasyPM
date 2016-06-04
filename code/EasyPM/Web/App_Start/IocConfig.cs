using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Easy.PM.Core.Util;
using Easy.PM.Store.PM;

namespace Web
{
    public class IocConfig
    {
        public static void Register(){
             SingletonFactory.Map<IProjectRepository,ProjectRepository>();
        }
    }
}