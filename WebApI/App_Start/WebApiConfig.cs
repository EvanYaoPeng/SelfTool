using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API 路由
            config.MapHttpAttributeRoutes();


            //config.Routes.MapHttpRoute(name: "DefaultApi", routeTemplate: "api/{controller}/{action}/{id}",
            //    defaults: new { id = RouteParameter.Optional });

            //1.默认路由 可以访问 api/Order/2 or api/user/2
            config.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { id = RouteParameter.Optional }//,constraints: new { id = @"d*" } 
            );

            //2.自定义路由一：匹配到action 可以访问两个
            config.Routes.MapHttpRoute(
            name: "ActionApi",
            routeTemplate: "actionapi/{controller}/{action}/{id}",
            defaults: new { id = RouteParameter.Optional }
            );
            //二
            //http://localhost:39398/actionapi/user/GetAllUsers
            //http://localhost:39398/actionapi/user/getuserbyid/2
            //http://localhost:39398/actionapi/order/getall
            //http://localhost:39398/actionapi/order/TestActionName/2 
            //TestActionName 是action 别名



            //3.自定义路由二
            config.Routes.MapHttpRoute(
            name: "TestApi",
            routeTemplate: "testapi/{controller}/{ordertype}/{id}",
            defaults: new { ordertype = "aa", id = RouteParameter.Optional }
            );
            //三访问方式
            //http://localhost:39398/testapi/user/aa
            //http://localhost:39398/testapi/user/aa/1
            //http://localhost:39398/testapi/Order/aa/
            //http://localhost:39398/testapi/Order/aa/1
        }
    }
}
