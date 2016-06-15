using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rename
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"D:\tt");
            int idx = 0;

            foreach (FileInfo fi in di.GetFiles())//可以用 di.GetFiles("*.jpg") 只重名jpg文件
            {
                //确定是增加前缀，还是后缀
                string toFileName = fi.Name.Replace("希赛软件设计师视频教程", "");
                //if (fi.Name.StartsWith("希赛软件设计师视频教程"))
                //{
                    
                //}
                //执行重命名
                fi.MoveTo(Path.Combine(fi.DirectoryName, toFileName + fi.Extension));

                idx++;
            }
        }
    }
}
