using Autofac;
using Autofac.Configuration;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutoFacTest
{
    //http://niuyi.github.io/blog/2012/04/06/autofac-by-unit-test/
    //
    //

    /// <summary>
    /// 
    /// </summary>
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var builder = new ContainerBuilder();
            //一、注册PinYinConverter 注册ConvertClass
            //builder.RegisterType<ConverterClass>();//registertype 注册为类
           // builder.RegisterType<PinYinConverter>().As<IChineseConverter>(); //注册为接口
            //二、读取配置文件中的autofac实现注入
            //builder.RegisterType<ConverterClass>();
            //builder.RegisterModule(new ConfigurationSettingsReader("autofac"));
            //三、和ConverterClass 带参数
            builder.RegisterModule(new ConfigurationSettingsReader("autofac"));
            builder.RegisterType<PinYinConverter>();
            builder.Register(c => new ConverterClass(c.Resolve<PinYinConverter>()));//构造函数
            //四、

            //builder.RegisterModule<IChineseConverter>();

            //Type baseType = typeof(Common.IChineseConverter);
            //var assembly = Assembly.GetAssembly(baseType);
            // builder.RegisterAssemblyTypes(assembly);
            //// builder.RegisterType<ConverterClass>();


            string str = string.Empty;
            using (var container = builder.Build())
            {
                var manager = container.Resolve<ConverterClass>();
                str= manager.Get("你好张靥");
               // manager.Add("INSERT INTO USER ...");
            }

            this.TextBox1.Text += str;
        }
    }

   
}