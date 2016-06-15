using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFacTest
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

           //builder.RegisterAssemblyTypes(typeof().Assembly);
            
            //注册通用的增加修改删除类 泛型类注册实例
            //builder.RegisterGeneric(typeof(BaseDAL<>)).As(typeof(IBaseDAL<>));
            //builder.RegisterGeneric(typeof(BaseBLL<>)).As(typeof(IBaseBLL<>));
            ////注册用户管理模块 非泛型类注册实例
            //builder.RegisterType(typeof(Sys_UserManage)).As(typeof(ISys_UserManage));
            //builder.RegisterType(typeof(Sys_UserService)).As(typeof(ISys_UserService));
           // var container = builder.Build();

            // Set MVC DI resolver to use our Autofac container
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}