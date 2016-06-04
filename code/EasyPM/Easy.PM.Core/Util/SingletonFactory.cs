using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Easy.PM.Core.DB;

namespace Easy.PM.Core.Util
{
    public class SingletonFactory
    {
        private static Dictionary<string,object> _instances=new Dictionary<string,object>();

        /// <summary>
        /// 注册接口和类的关系
        /// </summary>
        /// <typeparam name="Interface"></typeparam>
        /// <typeparam name="Implement"></typeparam>
        public static void Map<Interface,Implement>() where Implement:new() {
            var key = typeof(Interface).ToString();
            _instances.Add(key,typeof(Implement));
        }

       
        /// <summary>
        /// 注册接口和类的关系
        /// </summary>
        /// <typeparam name="Interface">Implement</typeparam>
        /// <param name="t"></param>
        public static void Map<Interface>(Interface t)
        {
            var key = typeof(Interface).ToString();
            _instances.Add(key, t);
        }

        /// <summary>
        /// 获取实现类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Resolves<T>()
        {
            var type=typeof(T).ToString();
            return (T)Activator.CreateInstance((Type)_instances[type], true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T ResolvesUnitWork<T>(IUnitOfWork uow) where T: IDBContent
        {
            var type = typeof(T).ToString();
            IDBContent result=(T)Activator.CreateInstance((Type)_instances[type], true);
            result.SetContent(uow.GetContent());
            return (T)result;
        }
    }
}
