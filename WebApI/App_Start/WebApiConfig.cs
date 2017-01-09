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
            //1.默认路由
            config.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { id = RouteParameter.Optional }
            );
            ////2.自定义路由一：匹配到action
            //config.Routes.MapHttpRoute(
            //name: "ActionApi",
            //routeTemplate: "actionapi/{controller}/{action}/{id}",
            //defaults: new { id = RouteParameter.Optional }
            //);
            ////3.自定义路由二
            //config.Routes.MapHttpRoute(
            //name: "TestApi",
            //routeTemplate: "testapi/{controller}/{ordertype}/{id}",
            //defaults: new { ordertype = "aa", id = RouteParameter.Optional }
            //);
        }
    }
}
